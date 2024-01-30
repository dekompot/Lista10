using Lista10.Data;
using Lista10.Models;
using Lista10.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IOFile = System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lista10.Controllers
{
    [Route("api/article")]
    [ApiController]
    public class ArticleApiController : ControllerBase
    {
        private readonly MyDbContext _context;
        string uploadFolder;

        public ArticleApiController(MyDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> Get()
        {
            return await _context.Article.ToListAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> Get(int id)
        {
            var article = await _context.Article
                .Include(a => a.Category)
                .FirstOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }
            else
            {
                return article;
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<Article>> Post([FromBody] ArticleApiViewModel articleView)
        {
            string imageName = null;
            Category category = await _context.Category.FirstOrDefaultAsync(c => c.Name == articleView.CategoryName);
            if (category == null)
            {
                return BadRequest();
            }
            else
            {
                Article article = new Article
                {
                    Name = articleView.Name,
                    Price = articleView.Price,
                    CategoryId = category.CategoryId,
                    Category = category,
                    ExpirationDate = articleView.ExpirationDate,
                    ImageName = imageName,
                };
                _context.Add(article);
                _context.SaveChanges();
                return article;
            }
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public async Task<ActionResult<Article>> Put([FromBody] Article article)
        {
            _context.Entry(article).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Article.Any(a => a.ArticleId == article.ArticleId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return article;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var article = await _context.Article.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            _context.Article.Remove(article);
            await _context.SaveChangesAsync();
            if (article.ImageName is not null)
            {
                string path = Path.Combine(uploadFolder, article.ImageName);
                if (IOFile.File.Exists(path))
                {
                    IOFile.File.Delete(path);
                }
            }
            return Ok();
        }
    }
}

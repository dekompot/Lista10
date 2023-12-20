using System;
using System.IO;
using IOFile = System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lista10.Data;
using Lista10.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Hosting;
using Lista10.ViewModels;
using Microsoft.AspNetCore.Http;

namespace Lista10.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly MyDbContext _context;
        string uploadFolder;

        public ArticlesController(MyDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.Article.Include(a => a.Category);
            return View(await myDbContext.ToListAsync());
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article
                .Include(a => a.Category)
                .FirstOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArticleId,Name,Image,Price,ExpirationDate,CategoryId")] ArticleCreateViewModel articleView)
        {
            if (ModelState.IsValid)
            {
                string imageName = articleView.Image is null ? null : SaveFileAndGetFilename(articleView.Image);
                Article article = new Article
                {
                    ArticleId = articleView.ArticleId,
                    Name = articleView.Name,
                    Price = articleView.Price,
                    CategoryId = articleView.CategoryId,
                    Category = articleView.Category,
                    ExpirationDate = articleView.ExpirationDate,
                    ImageName = imageName,
                };
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name", articleView.CategoryId);
            return View(articleView);
        }

        private string SaveFileAndGetFilename(IFormFile file)
        {
            string name = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            string path = Path.Combine(uploadFolder, name);
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            return name;
        }

        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name", article.CategoryId);
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArticleId,Name,ImageName,Price,ExpirationDate,CategoryId")] Article article)
        {
            if (id != article.ArticleId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ArticleId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name", article.CategoryId);
            return View(article);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article
                .Include(a => a.Category)
                .FirstOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Article.FindAsync(id);
            _context.Article.Remove(article);
            await _context.SaveChangesAsync();
            if (article.ImageName is not null)
            {
                RemoveFile(article.ImageName);
            }
            return RedirectToAction(nameof(Index));
        }

        private void RemoveFile(string fileName)
        {
            string path = Path.Combine(uploadFolder, fileName);
            if (IOFile.File.Exists(path))
            {
                IOFile.File.Delete(path);
            }
        }

        private bool ArticleExists(int id)
        {
            return _context.Article.Any(e => e.ArticleId == id);
        }
    }
}

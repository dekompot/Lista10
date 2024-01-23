using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lista10.Data;
using Lista10.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Lista10.Controllers
{
    public class ShopController : Controller
    {
        private readonly MyDbContext _context;
        public ShopController(MyDbContext context)
        {
            _context = context;
        }

       

        // GET: Shop
        public async Task<IActionResult> Index(string Category)
        {
            Category = Category == null ? "-1" : Category;
            var shopDbContext = _context.Article.Include(a => a.Category);
            List<SelectListItem> categories = new List<SelectListItem>
            {
                new SelectListItem { Text = "All", Value = "-1" }
            };
            foreach (var category in _context.Category)
            {
                categories.Add(new SelectListItem { Text = category.Name, Value = category.CategoryId.ToString() });
            }

            categories.Find(c => c.Value == Category).Selected = true;

            ViewBag.Category = categories;

            var articles = await shopDbContext.ToListAsync();
            if (Category != "-1")
            {
                articles = articles.Where(a => a.CategoryId.ToString() == Category).ToList();
            }

            return View(articles);

        }
        public IActionResult AddToBasket(int id)
        {
            int pieces = GetPieces(id);
            if (pieces > 0)
            {
                SetCookie(id, pieces + 1);
            }
            else
            {
                SetCookie(id, 1);
            }
            return RedirectToAction(nameof(Index));
        }

        public void SetCookie(int key, int value)
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append(key.ToString(), value.ToString(), options);
        }

        public int GetPieces(int articleId)
        {
            string? pieces = Request.Cookies[articleId.ToString()];
            return pieces == null ? 0 : Int32.Parse(pieces);
        }

        private bool ArticleExists(int id)
        {
            return _context.Article.Any(e => e.ArticleId == id);
        }
    }
}

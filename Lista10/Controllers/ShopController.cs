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

namespace Lista10.Controllers
{
    public class ShopController : Controller
    {
        private readonly MyDbContext _context;
        string uploadFolder;
        public ShopController(MyDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");
        }

        // GET: Shop
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.Article.Include(a => a.Category);
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name", myDbContext.FirstOrDefault().CategoryId);
            return View(await myDbContext.ToListAsync());

        }

        private bool ArticleExists(int id)
        {
            return _context.Article.Any(e => e.ArticleId == id);
        }
    }
}

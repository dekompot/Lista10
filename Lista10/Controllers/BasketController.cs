using Lista10.Data;
using Lista10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Lista10.Controllers
{
    public class BasketController : Controller
    {
        private readonly MyDbContext _context;
        public BasketController(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ClearCookies();
            var articlesWithCategories = await _context.Article
                .Include(a => a.Category)
                .ToListAsync();

            var tupleList = articlesWithCategories
                .Select(a => new Tuple<Article, int>(a, GetPieces(a.ArticleId)))
                .Where (t => t.Item2 > 0)
                .ToList();

            ViewBag.Total = tupleList.Select(i => i.Item1.Price * i.Item2).Sum();
            return View(tupleList);
        }

        public void ClearCookies()
        {
            foreach(var cookie in Request.Cookies)
            {
                int value;
                if (cookie.Value == "0" || (Int32.TryParse(cookie.Key, out value) && !_context.Article.Any(a => a.ArticleId == value))) 
                {
                    Response.Cookies.Delete(cookie.Key);
                }
            }
        }

        public int GetPieces(int articleId)
        {
            string? pieces = Request.Cookies[articleId.ToString()];
            return pieces == null ? 0 : Int32.Parse(pieces);
        }

        public IActionResult AddToBasket(int id)
        {
            AddElement(id);
            return RedirectToAction(nameof(Index));
        }

        public void AddElement(int id)
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
        }


        public IActionResult RemoveAllPiecesFromBasket(int id)
        {
            DeleteCookie(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveFromBasket(int id)
        {
            string? pieces = Request.Cookies[id.ToString()];
            if (pieces != null)
            {
                int piecesInt = Int32.Parse(pieces);
                if (piecesInt > 0)
                {
                    SetCookie(id, piecesInt - 1);
                }
                else
                {
                    DeleteCookie(id);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public void SetCookie(int key, int value) 
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append(key.ToString(),value.ToString(),options);
        }

        public void DeleteCookie(int key)
        {
            Response.Cookies.Delete(key.ToString());
        }

    }
}

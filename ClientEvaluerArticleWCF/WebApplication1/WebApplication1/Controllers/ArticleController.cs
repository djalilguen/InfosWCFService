using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace ClientEvaluerArticle.Controllers
{
    public class ArticleController : Controller
    {

        // GET: Article
        public async Task<ActionResult> Index()
        {
            ArticlesWSClient ws = new ArticlesWSClient();
            getListArticlesResponse getarticles = await ws.getListArticlesAsync();
            List<article> articles = getarticles.@return.ToList();
            return View(articles);
        }

        // GET: Article/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ArticlesWSClient ws = new ArticlesWSClient();
            getArticleResponse getarticle = await ws.getArticleAsync(id);
            article art = getarticle.@return;
            return View(art);
        }


        // GET: Articles
        public async Task<ActionResult> Search(String keywords)
        {
            try
            {
                ArticlesWSClient ws = new ArticlesWSClient();
                searchArticlesResponse getarticles = await ws.searchArticlesAsync(keywords);
                List<article> articles = getarticles.@return.ToList();
                return View(articles);
            }
            catch
            {
                return NotFound("Article not found ");// RedirectToAction(nameof(Index));
            }
           
        }

        public async Task<ActionResult> Like(int id)
        {
            try
            {
                ArticlesWSClient ws = new ArticlesWSClient();
                likeResponse l = await ws.likeAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Details));
            }
        }

        public async Task<ActionResult> Dislike(int id)
        {
            try
            {
                ArticlesWSClient ws = new ArticlesWSClient();
                dislikeResponse d = await ws.dislikeAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Details));
            }
        }
    }
}
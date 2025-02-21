using Assignment_1.Data;
using Assignment_1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1.Controllers
{
    [Authorize]
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var articles = _context.Articles
                .Where(a => a.StartDate <= DateTime.UtcNow && a.EndDate >= DateTime.UtcNow)
                .ToList();
            return View(articles);
        }

        [Authorize(Roles = "Contributor")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Contributor")]
        public async Task<IActionResult> Create(Article article)
        {
            article.ContributorUsername = User.Identity?.Name;
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

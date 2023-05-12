using kiyotaka.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kiyotaka.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly kiyotakaDbContext _context;

        public HomeController(kiyotakaDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var animeList = await _context.AnimeHubs.ToListAsync();

            return View(animeList);
        }
    }
}

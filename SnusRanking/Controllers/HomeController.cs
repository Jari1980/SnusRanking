using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnusRanking.Data;
using SnusRanking.Helper;
using SnusRanking.Models;
using System.Diagnostics;

namespace SnusRanking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        const string SessionKey = "SessionKey";

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            int snusInDb = _db.Snus.Count();
            ViewBag.snusFromViewBag = snusInDb;

            Snus snusWithNameLongestName = _db.Snus.OrderByDescending(x => x.Name.Length).ToList().FirstOrDefault();
            TempData["tempDataLongestName"] = snusWithNameLongestName.Name;

            if (HttpContext.Session.Get<Snus>(SessionKey) == default)
            {
                HttpContext.Session.Set<Snus>(SessionKey, new Snus());
            }
            Snus sessionObject = HttpContext.Session.Get<Snus>(SessionKey);
            Snus firstSnus = _db.Snus.OrderBy(x => x.Id).FirstOrDefault();
            sessionObject.Id = firstSnus.Id;
            sessionObject.Name = firstSnus.Name;
            sessionObject.Flavor = firstSnus.Flavor;
            sessionObject.Pic = firstSnus.Pic;
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

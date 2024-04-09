using Microsoft.AspNetCore.Mvc;
using MvcCreditApp.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;

namespace MvcCreditApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CreditContext db;

        public HomeController(ILogger<HomeController> logger, CreditContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            var credits = db.Credits.ToList<Credit>();
            ViewBag.Credits = credits;
            return View();
        }

        private void GiveCredits()
        {
            var credits = db.Credits.ToList<Credit>();
            ViewBag.Credits = credits;
        }

        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits(); 
            var bids = db.Bids.ToList<Bid>();
            ViewBag.Bids = bids;
            return View();
        }

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            db.Bids.Add(newBid);
            db.SaveChanges();
            return "Thank, " + newBid.Name + ", for choosing our jar.Your application will be reviewed within 10 days.";
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
        public ActionResult BidSearch(string name)
        {
            var allBids = db.Bids.Where(a => a.CreditHead.Contains(name)).ToList();
            if (allBids.Count == 0)
            {
                return Content("Specified loan " + name + " not found");
            }
            return PartialView(allBids);
        }
    }
}

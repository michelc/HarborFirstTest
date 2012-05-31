using System.Web.Mvc;
using HarborFirstTest.Models;
using HarborFirstTest.Persistence;

namespace HarborFirstTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly HftContext _context = new HftContext();

        public ActionResult Index()
        {
            return View(_context.Users);
        }

        public ActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

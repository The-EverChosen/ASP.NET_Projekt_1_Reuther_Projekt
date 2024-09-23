using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Projekt_1_Reuther_Projekt.Controllers
{
    public class JopPostingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FormJopPosting()
        {
            return View();
        }

        public IActionResult createdJobPosting()
        {
            return RedirectToAction("Index");
        }
    }
}

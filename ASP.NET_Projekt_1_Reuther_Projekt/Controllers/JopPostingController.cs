using ASP.NET_Projekt_1_Reuther_Projekt.Data;
using ASP.NET_Projekt_1_Reuther_Projekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Projekt_1_Reuther_Projekt.Controllers
{
    public class JopPostingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public JopPostingController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var JopPostingsFromDb = _context.jobPostings.Where(x => x.OwnerUsername == User.Identity.Name).ToList();
            return View(JopPostingsFromDb);

        }

        public IActionResult FormJopPosting()
        {
            return View();
        }

        public IActionResult createdJobPosting()
        {
            return RedirectToAction("Index");
        }

        public IActionResult CreatedEditJop(JopPost jopPost, IFormFile file)
        {
            if (file != null)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var bytes = ms.ToArray();
                    jopPost.CompanyImage = bytes;
                }
            }
            return RedirectToAction("Index");
        }
    }
}
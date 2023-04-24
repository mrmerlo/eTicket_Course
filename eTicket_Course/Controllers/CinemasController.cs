using Microsoft.AspNetCore.Mvc;

namespace eTicket_Course.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using eTicket_Course.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eTicket_Course.Controllers
{
    public class ProducersController : Controller
    {
        public readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public  async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View();
        }
    }
}

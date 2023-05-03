using Microsoft.AspNetCore.Mvc;
using eTicket_Course.Data;
using eTicket_Course.Data.Services;
using eTicket_Course.Models;

namespace eTicket_Course.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;

        public ActorsController(IActorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")]Actor actor)
        {
            actor.Actors_Movies = new List<Actor_Movie>();
            if (!ModelState.IsValid && false)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id) {

            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("Empty");
            }
            else { 
                return View(actorDetails);
            }
        
        }
    }
}

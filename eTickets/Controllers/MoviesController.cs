using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _Db;

        public MoviesController(AppDbContext db)
        {
            _Db = db;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _Db.Movies.Include(n=>n.Cinema).ToListAsync();
            return View(data);
        }
    }
}

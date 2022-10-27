using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {

        private readonly AppDbContext _Db;

        public CinemasController(AppDbContext db)
        {
            _Db = db;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _Db.Cinemas.ToListAsync();
            return View(data);
        }
    }
}

using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _Db; //我们定义好的db

        public ActorsController(AppDbContext db) //constructor 用我们定义好的DB
        {
            _Db = db;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _Db.Actors.ToListAsync();
            return View(data);
        }
    }
}

using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _Db;

        public ProducersController(AppDbContext db)
        {
            _Db = db;
        }

        public async Task<IActionResult> Index() //可以把这个写成一个异步函数然后等待db拿到list
        {
            var data = await _Db.Producers.ToListAsync();  //等待DB拿到list await
            return View(data);
        }
    }
}

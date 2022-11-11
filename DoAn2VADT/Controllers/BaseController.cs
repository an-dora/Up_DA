using DoAn2VADT.Database;
using Microsoft.AspNetCore.Mvc;

namespace DoAn2VADT.Controllers
{
    public class BaseController : Controller
    {
        protected readonly AppDbContext _db;
        public BaseController(AppDbContext db)
        {
            _db = db;
        }
    }
}

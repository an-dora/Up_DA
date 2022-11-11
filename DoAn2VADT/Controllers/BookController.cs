using AutoMapper;
using AutoMapper.QueryableExtensions;
using DoAn2VADT.ViewModels.Book;
using DoAn2VADT.Database;
using DoAn2VADT.Database.Entities;
using DoAn2VADT.WebConfigs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace DoAn2VADT.Controllers
{
    public class BookController : BaseController
    {
        private readonly IMapper _mapper;
        public BookController(AppDbContext db, IMapper mapper) : base(db)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<ListItemBook> GetAll()
        {
            var query = _db.Books
                        .ProjectTo<ListItemBook>(AutoMapperProfile.bookAMC)
                        .OrderByDescending(n => n.Name);
            var data = query.ToList();
            return data;
        }
        [HttpPost]
        public IActionResult Create([FromBody] AoU_BookVM bookVM)
        {
            // xác thực dữ liệu
            if (ModelState.IsValid == false)
            {
                return Ok(new
                {
                    success = false,
                    mesg = "Dữ liệu không hợp lệ, không thể thêm"
                });
            }
            // Lưu vào db
            var book = new Book();
            book.CreatedAt = DateTime.Now;
            book.UpdatedAt = DateTime.Now;
            _mapper.Map(bookVM, book);
            _db.Books.Add(book);
            _db.SaveChanges();
            return Ok(new
            {
                success = true
            });
        }

        [HttpPost]
        public IActionResult Update(int id, [FromBody] AoU_BookVM bookVM)
        {
            var book = _db.Books
                    .FirstOrDefault(c => c.Id == id);
            book.UpdatedAt = DateTime.Now;
            _mapper.Map(bookVM, book);
            _db.SaveChanges();
            return Ok(new
            {
                success = true
            });
        }

        public IActionResult Detail(int id)
        {
            var book = _db.Books.Find(id);
            var bookVM = _mapper.Map<AoU_BookVM>(book);
            return Ok(bookVM);
        }

        public IActionResult Delete(int id)
        {
            var book = _db.Books.Find(id);
            _db.Remove(book);
            _db.SaveChanges();
            return Ok(new
            {
                success = true
            });
        }
    }
}

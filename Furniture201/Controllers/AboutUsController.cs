using Furniture201.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Furniture201.Controllers
{
    public class AboutUsController : Controller
    {
        readonly AppDbContext _context;

        public AboutUsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}

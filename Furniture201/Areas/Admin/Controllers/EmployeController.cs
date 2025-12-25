using Furniture201.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Furniture201.Areas.Admin.Controllers;
[Area("Admin")]
public class EmployeController(AppDbContext _context) : Controller
{
    public IActionResult Index()
    {

        var employees = _context.Employees.Include(x =>x.Blogs).ToList();
        return View();
    }

}

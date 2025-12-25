using Furniture201.Contexts;
using Furniture201.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Furniture201.Areas.Admin.Controllers;
[Area("Admin")]
public class BlogController(AppDbContext _context) : Controller
{
    public IActionResult Index()
    {

        var blogs = _context.Blogs.Include(e => e.Employee ).ToList();
        return View(blogs);
    }
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Employees = _context.Employees.ToList();
        return View();
    }
    [HttpPost]
    public IActionResult Create(Blog blog)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Employees = _context.Employees.ToList();
            return View(blog);
        }
        _context.Blogs.Add(blog);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    public IActionResult Delete(int id)
    {
        var blog = _context.Blogs.Find(id);
        if (blog == null) 
         {
            return NotFound();
        }
        _context.Blogs.Remove(blog);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        var blog = _context.Blogs.Find(id);
        if (blog == null)
        {
            return NotFound();
        }
        ViewBag.Employees = _context.Employees.ToList();
        return View(blog);
    }
    [HttpPost]
    public IActionResult Update(Blog blog)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Employees = _context.Employees.ToList();
            return View(blog);
        }
        var existingBlog = _context.Blogs.Find(blog.Id);
        if (existingBlog == null)
        {
            return NotFound();
        }
        existingBlog.Title = blog.Title;
        existingBlog.Text = blog.Text;
        existingBlog.EmployeeId = blog.EmployeeId;
        existingBlog.PostedDate = blog.PostedDate;
        existingBlog.ImageName = blog.ImageName;
        existingBlog.ImageUrl = blog.ImageUrl;
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }


}

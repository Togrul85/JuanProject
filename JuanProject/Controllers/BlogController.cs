using JuanProject.DAL;
using JuanProject.Models;
using JuanProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JuanProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            BlogDetail blogDetailVM = new()
            {
                Blog = _context.Blogs.FirstOrDefault(b => b.Id == id),
                Blogs = _context.Blogs.OrderByDescending(b => b.Id).Take(2).ToList()


            };
       
            return View();
        }
    }
}

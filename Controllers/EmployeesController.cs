using Microsoft.AspNetCore.Mvc;
using SkyLine.Date;
using SkyLine.Models;

namespace SkyLine.Controllers
{
    public class EmployeesController : Controller
    {
        ApplicationDbContext _context;
        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult GetIndexView()
        {
            return View("Index1", _context.Employees.ToList());
        }
        public IActionResult GetDetailsView(int id)
        {
            Employee emp = _context.Employees.FirstOrDefault(d => d.Id == id);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                return View("Detail", emp);
            }
        }
        public IActionResult GetCreateView()
        {
            return View("Create");
        }

        public string GreetVisitor()
        {
            return "welcome to SkyLine for Software Solution! ";
        }
        public string GreetUser(string FirstName, string LastName)
        {
            return $"Hi {FirstName} {LastName}!";
        }
    }
}

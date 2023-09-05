using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using SkyLine.Date;
using SkyLine.Models;

namespace SkyLine.Controllers
{
    public class DepartmentsController : Controller
    {

        ApplicationDbContext _context;
        public DepartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }




        //    List<Department> departments = new List<Department>
        //{
        //    new Department
        //    {
        //        Id = 101,
        //        Name = "Web Dev",
        //        Description = "Web Development",
        //        AnnualBudget = 250000m,
        //        StartDate = new DateTime(2015, 5, 15),
        //        IsActive = true
        //    },
        //    new Department
        //{
        //    Id = 102,
        //    Name = "Mob Dev",
        //    Description = "Mobile App Development",
        //    AnnualBudget = 150000m,
        //    StartDate = new DateTime(2016, 6, 16),
        //    IsActive = true
        //},
        //    new Department
        //{
        //    Id = 103,
        //    Name = "Desk Dev",
        //    Description = "Desktop App Development",
        //    AnnualBudget = 275000m,
        //    StartDate = new DateTime(2014, 4, 14),
        //    IsActive = true
        //},
        //    new Department
        //{
        //    Id = 104,
        //    Name = "QC",
        //    Description = "Quality Conrtol",
        //    AnnualBudget = 135000m,
        //    StartDate = new DateTime(2017, 7, 17),
        //    IsActive = true
        //},
        //    new Department
        //{
        //    Id = 105,
        //    Name = "PM",
        //    Description = "Project Managment",
        //    AnnualBudget = 0m,
        //    StartDate = new DateTime(2018, 8, 18),
        //    IsActive = false
        //},

        //};


        [HttpGet] //default
        public IActionResult GetIndexView()
        {
            return View("Index", _context.Departments.ToList());
        }
        //httpGet -> هيحضر حاجه
        //httppost->يبعت حاجه
        [HttpPost]
        public IActionResult AddNew(Department dept)
        {
            _context.Departments.Add(dept);
            _context.SaveChanges();
            return RedirectToAction("GetIndexView");
        }

        public IActionResult GetDetailsView(int id)
        {
            Department dept = _context.Departments.FirstOrDefault(d => d.Id == id);
            if (dept == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", dept);
            }
        }

        public IActionResult GetCreateView()
        {
            return View("Create");
        }

        public string GreetVisitor(string deptName)
        {
            return "welcome to "+ deptName + " Department! ";
        }
        public string GreetUser(string FirstName ,string LastName)
        {
            return $"Hi {FirstName} {LastName}!";
        }
        public string GetAge(int birthday)
        {
            return (DateTime.Now.Year - birthday).ToString();
        }
        public string IsLegalHiringAge(int birthday) 
        {
            return (DateTime.Now.Year-birthday>=18).ToString();
        }
        

    }
}

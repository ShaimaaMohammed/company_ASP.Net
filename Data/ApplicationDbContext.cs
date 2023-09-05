using Microsoft.EntityFrameworkCore;
using SkyLine.Models;

namespace SkyLine.Date
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public ApplicationDbContext(DbContextOptions option) : base(option) 
        {

        }
    }
}

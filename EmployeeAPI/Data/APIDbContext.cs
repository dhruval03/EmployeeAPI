using Microsoft.EntityFrameworkCore;
using EmployeeAPI.Models;

namespace EmployeeAPI.Data
{
    public class APIDbContext : DbContext
    {

        public APIDbContext(DbContextOptions option) : base(option)
        { }

        public DbSet<Employee>? Employees { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
using MVCCoreDemo.Models;

namespace MVCCoreDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<DepartmentData> DepartmentData { get; set; }
        public virtual DbSet<EmployeeData> EmployeeData { get; set; }

        public virtual DbSet<User> Users { get; set; }
    }
}
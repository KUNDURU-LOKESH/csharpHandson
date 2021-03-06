using EntityFramework.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public class DemoDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DemoDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=KELLGGNLPTP1078\SQLEXPRESS;Database=Study;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LVVPEMG;Database=Framework;Trusted_Connection=True;");

        }
    }
}

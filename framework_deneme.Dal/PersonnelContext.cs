using framework_deneme.Core;
using framework_deneme.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace framework_deneme.Dal
{
    public class PersonnelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=AHMETCANPC;Database=Personnel;Integrated Security=True;");
        }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

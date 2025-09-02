using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo03.Inheritance_Models;
using Microsoft.EntityFrameworkCore;

namespace Demo03.Contexts
{
    internal class InhertanceDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database = InhertanceG01; Trusted_Connection = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<FullTimeEmployee>()
            //            .HasBaseType<Employee>();

            //modelBuilder.Entity<PartTimeEmployee>()
            //            .HasBaseType<Employee>();  

            //modelBuilder.Entity<Employee>()
            //            .HasDiscriminator<string>("EmployeeType")
            //            .HasValue<FullTimeEmployee>("FTE")
            //            .HasValue<PartTimeEmployee>("PTE");

            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
            
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }
}

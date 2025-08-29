using Demo03.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Demo03.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        //public CompanyDbContext() : base()
        //{ 
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database = CompanyG01; Trusted_Connection = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            //modelBuilder.ApplyConfiguration(new DepartmentConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Department>()
            //            .ToTable("Departments", "dbo");

            //modelBuilder.Entity<Department>()
            //            //.HasKey(D => new {D.DeptId, D.Code});
            //            .HasKey(D => D.DeptId);

            //modelBuilder.Entity<Department>()
            //            .Property<string>(D => D.DepartmentName)
            //            .HasColumnType("varchar")
            //            .HasMaxLength(50)
            //            .HasColumnName("Name")
            //            .IsRequired();

            //modelBuilder.Entity<Department>()
            //            .Property(D => D.DateOfCreation)
            //            //.HasDefaultValue(DateTime.Now);
            //            .HasComputedColumnSql("GetDate()");

            //modelBuilder.Entity<Department>(builder =>
            //{
            //    builder.ToTable("Departments", "dbo");

            //    builder.HasKey(D => D.DeptId);

            //    builder.Property<string>(D => D.DepartmentName)
            //            .HasColumnType("varchar")
            //            .HasMaxLength(50)
            //            .HasColumnName("Name")
            //            .IsRequired();

            //    builder.Property(D => D.DateOfCreation)
            //            //.HasDefaultValue(DateTime.Now);
            //            .HasComputedColumnSql("GetDate()");
            //});


            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Salary)
            //            .HasDefaultValue(4000);

            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.EmpId)
            //            .UseIdentityColumn(1, 2);

            //modelBuilder.Entity<Employee>(builder =>
            //{
            //    builder.Property(E => E.Salary)
            //            .HasDefaultValue(4000);

            //    builder.Property(E => E.EmpId)
            //            .UseIdentityColumn(1, 2);
            //});

            //modelBuilder.Entity<Student>()
            //            .HasMany(S => S.Courses)
            //            .WithMany(C => C.Students)
            //            .UsingEntity(SC => SC.ToTable("StudentCourse"));
            modelBuilder.Entity<Student>()
                        .HasMany(S => S.Courses)
                        .WithOne(SC => SC.Student)
                        .HasForeignKey(SC => SC.StdId)
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
            modelBuilder.Entity<Course>()
                        .HasMany(C => C.Students)
                        .WithOne(SC => SC.Course)
                        .HasForeignKey(SC => SC.CrsId)
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
        }

        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students  { get; set; }


    }
}

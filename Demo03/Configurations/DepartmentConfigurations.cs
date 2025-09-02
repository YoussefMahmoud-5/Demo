using Demo03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Configuration_Classes
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments", "dbo");

            builder.HasKey(D => D.DeptId);

            builder.Property<string>(D => D.DepartmentName)
                    .HasColumnType("varchar")
                    .HasMaxLength(50)
                    .HasColumnName("Name")
                    .IsRequired();

            builder.Property(D => D.DateOfCreation);
            //.HasDefaultValue(DateTime.Now);
            //.HasComputedColumnSql("GetDate()");

            builder.HasOne(D => D.Manager)
                   .WithOne(E => E.ManagedDepartment)
                   .HasForeignKey<Department>(D => D.MngID)
                   .OnDelete(DeleteBehavior.Cascade);
                   //.IsRequired();

            builder.HasMany<Employee>(D => D.Employees)
                   .WithOne(E => E.EmployeeDepartment)
                   .HasForeignKey(E => E.DepartmentId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired();
        }
    }
}

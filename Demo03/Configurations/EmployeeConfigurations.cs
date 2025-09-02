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
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E => E.Salary)
                        .HasDefaultValue(4000);

            //builder.Property(E => E.EmpId)
            //        .UseIdentityColumn(1, 2);

            builder.HasOne(E => E.ManagedDepartment)
                   .WithOne(D => D.Manager)
                   .HasForeignKey<Department>(D => D.MngID)
                   .OnDelete(DeleteBehavior.NoAction);
                   //.IsRequired(true);

            builder.OwnsOne(E => E.EmpAddress, Address => Address.WithOwner());
            builder.OwnsOne(e => e.EmpAddress, address =>
            {
                address.WithOwner();

                address.Property(a => a.Country)
                       .HasColumnName("Country");

                address.Property(a => a.City)
                       .HasColumnName("City");

                address.Property(a => a.Street)
                       .HasColumnName("Street");
            });


            builder.HasOne(E=>E.EmployeeDepartment)
                .WithMany(D=>D.Employees)
                .HasForeignKey(E=>E.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(true);


        }
    }
}

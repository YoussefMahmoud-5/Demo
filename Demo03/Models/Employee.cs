using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo03.Models
{
    // Model : POCO Class [Plain Old CLR Object] - Domain Entity

    [Table("Employees", Schema = "dbo")]
    internal class Employee
    {
        #region 1. By Convention
        // Public Numeric Property Named As [Id, EntityId]
        // Automatically Assumed To Be Primary Key of Table With Identity(1,1)
        public int Id { get; set; } // PK with Identity(1,1)

        // Nullable => Allow Null
        // string => nvarchar(max)
        // nvarchar(max), allows Null
        public string? Name { get; set; }

        // Not Allow Null
        // decimal => decimal(18,2)
        // decimal(18,2), Not Allow Null
        public decimal Salary { get; set; }

        // Not Allow Null
        // int => int
        // int, Not Allow Null
        public int Age { get; set; }
        #endregion

        #region 2. Data Annotations
        //// Primary Key
        //[Key]
        //// Identity Constraints (1,1) 
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //// Database inserts value when record updated or inserted
        ////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        ////[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int EmpId { get; set; }

        //// convert the string into varchar instead of nvarchar
        //[Column("EmpName", TypeName = "varchar")]
        //// Set maximum length
        //[MaxLength(50, ErrorMessage = "Name Length Cannot be more than 50 Char")]
        //// Application Validation (Backend Validation)
        //[MinLength(3, ErrorMessage = "Name Length cannot be less than 3 chars")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Name Must be more than 3 chars and less than 50 chars")]
        //[Length(3, 50, ErrorMessage = "Name Must be more than 3 chars and less than 50 chars")]
        //[Required]
        //public string? EmpName { get; set; }

        //[DataType(DataType.Currency)]
        //[Column(TypeName = "money")]
        //public double Salary { get; set; }

        ////[Range(22, 60)]
        ////[AllowedValues(22,23,24,25,26)]
        //[DeniedValues(13, 14, 15, 16, 17)]
        //public int? Age { get; set; }

        //[DataType(DataType.PhoneNumber)]
        //public string PhoneNumber { get; set; }

        //[EmailAddress]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        //[DataType(DataType.Password)]
        //public string? Password { get; set; }

        //[NotMapped]
        //public int Test { get; set; } 
        #endregion


        //Navigational Property [One]
        //EF Core : Employee May Managed One Department [Partial]
        //Nullable => Partial
        [InverseProperty(nameof(Department.Manager))]        
        public Department? ManagedDepartment { get; set; }

        //Navigational Property [One]
        
        public Address EmpAddress { get; set; } = null!;
        [ForeignKey(nameof(EmployeeDepartment))]
        public int DepartmentDeptId { get; set; }

        //Navigational Property [One]
        //[ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Department.Employees))]
        public Department EmployeeDepartment { get; set; } = null!;


    }
}

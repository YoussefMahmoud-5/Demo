using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Models
{
    // Model
    internal class Department
    {
        public int DeptId { get; set; }
        public int? Code { get; set; }
        public string DepartmentName { get; set; } = null!;
        public DateOnly DateOfCreation { get; set; }

        //[ForeignKey(nameof(Manager))]
        public int? MngID { get; set; }
        //public int ManagerId { get; set; }

        //Navigational Property [One]
        //EF Core : Department Must Has One Employee To Manager it [Total]
        //IF Not Nullable this Know us the Relation is total 
        //IF  Nullable this Know us the Relation is partial 
        [InverseProperty(nameof(Employee.ManagedDepartment))]
        public virtual Employee? Manager { get; set; }=null!;

        //Navigational Property [Many]
        [InverseProperty(nameof(Employee.EmployeeDepartment))]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}

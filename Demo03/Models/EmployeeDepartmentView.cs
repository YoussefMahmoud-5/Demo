using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo03.Models
{
    [Keyless]
    internal class EmployeeDepartmentView
    {
        public int EmployeeId { get; set; }
        public string  EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

    }
}

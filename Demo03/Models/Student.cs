using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Models
{
    internal class Student
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<StudentCourse> Courses { get; set; }=new HashSet<StudentCourse>();
    }
}

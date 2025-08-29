using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<StudentCourse> Students { get; set; } = new HashSet<StudentCourse>();
    }
}

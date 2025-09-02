using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Inheritance_Models
{
    internal class PartTimeEmployee:Employee
    {
        public int CountofHours { get; set; }
        public double HourRate { get; set; }
    }
}

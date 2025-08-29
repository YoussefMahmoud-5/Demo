using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo03.Models
{
    //[Owned]
    internal class Address
    {
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
    }
}

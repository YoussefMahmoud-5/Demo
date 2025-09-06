using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Contexts.Models
{
    public partial class CustOrderHistResult
    {
        public override string ToString()
        {
            return $"Product: {ProductName}, Total: {Total}";
        }

    }
}

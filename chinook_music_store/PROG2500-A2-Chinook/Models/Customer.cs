using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A3_Chinook_Linq.Models
{
    public partial class Customer
    {
        public string? FullName { get { return this.LastName + ", " + this.FirstName; } }
    }
}

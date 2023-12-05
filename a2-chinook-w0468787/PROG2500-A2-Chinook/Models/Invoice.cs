using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A3_Chinook_Linq.Models
{
    public partial class Invoice
    {
        public string? OrderDate { get { return $"Order date: " + this.InvoiceDate; } }
        public string? TotalPrice { get { return $" Total: $" + this.Total; } }
        public string? InvoiceCount { get { return $" Quantity :" + InvoiceLines.Count(); } }
    }
}

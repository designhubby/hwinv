using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hwinv.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
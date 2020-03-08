using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hwinv.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceName { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }

    }
}
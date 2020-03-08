using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hwinv.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
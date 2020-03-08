using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hwinv.Models
{
    public class Model
    {
        public int ModelId { set; get; }
        
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
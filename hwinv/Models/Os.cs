using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hwinv.Models
{
    public class Os
    {
        public int OsId { get; set; }
        public string OsName { get; set; }
        public virtual ICollection<Device> Devices { get; set; }

    }
}
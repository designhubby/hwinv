using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hwinv.Models
{
    public class Device
    {

        public int DeviceId { get; set; }

        public string Service_tag { set; get; }
        public string Asset_tag { get; set; }
        public string Note { get; set; }
        public bool? Returned { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int OsId { get; set; }
        public Os Os { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public virtual ICollection<JuncUserDevice> JuncUserDevices { get; set; }



    }
}
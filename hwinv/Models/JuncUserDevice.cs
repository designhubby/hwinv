using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hwinv.Models
{
    public class JuncUserDevice
    {
        [Key, Column(Order = 0)]
        public int EmployeeId { get; set; }
        [Key, Column(Order = 1)]
        public int DeviceId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Device Device { get; set; }
        public DateTime? DateAssigned { get; set; }
        public DateTime? DateReturned { set; get; }
    }
}
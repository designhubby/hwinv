using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hwinv.Models
{
    public class JuncUserDevice
    {
        public User UserId { get; set; }
        public Device DeviceId { get; set; }
        public virtual User User { get; set; }
        public virtual Device Device { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime DateReturned { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hwinv.Models
{
    public class EmpRole
    {
        public int EmpRoleId { get; set; }
        public string EmpRoleName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
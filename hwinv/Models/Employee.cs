using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hwinv.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string UserAD { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int EmpRoleId { get; set; }
        public EmpRole EmpRole { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public virtual ICollection<JuncUserDevice> JuncUserDevice { get; set; }
        

    }
}
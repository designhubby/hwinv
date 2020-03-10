namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Model_JuncUserDevices : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Employees (UserAD, Fname, Lname, EmpRoleId, DepartmentId) VALUES ('EMusk','Elon','Musk',5,15)");
            Sql("Insert INTO JuncUserDevices (EmployeeId, DeviceId,DateAssigned,DateReturned) VALUES (1,2,'2020-03-01','2020-04-02'),(2,3,'2020-02-05','2020-03-05'),(3,4,'2020-02-05',''),(1,5,'2019-03-01','2020-04-02'),(2,6,'2019-02-05','2019-03-05'),(4,4,'2019-02-05','2019-03-04')");
        }
        
        public override void Down()
        {
        }
    }
}

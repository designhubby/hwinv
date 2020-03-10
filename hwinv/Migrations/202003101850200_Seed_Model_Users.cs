namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Model_Users : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Departments (DepartmentName) VALUES ('Client Services'),('Communications & Marketing'),('Compliance Division'),('Corporate Governance'),('Evaluations & Assessments'),('Finance'),('Human Resources'),('Information Technology'),('Legal Services'),('Member Records & Data'),('Policy & Research'),('Registrar\''s Office'),('Registration Services'),('Standards'),('Test')");
            Sql("Insert INTO Employees (UserAD, Fname, Lname, EmpRoleId, DepartmentId) VALUES ('BGates','Bill','Gates',1,15),('JGoldblum','Jeff','Goldblum',2,15),('BWayne','Bruce','Wayne',3,15)");
        }
        
        public override void Down()
        {
        }
    }
}

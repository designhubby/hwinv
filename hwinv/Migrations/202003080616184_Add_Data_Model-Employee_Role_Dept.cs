namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Data_ModelEmployee_Role_Dept : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        UserAD = c.String(),
                        Fname = c.String(),
                        Lname = c.String(),
                        EmpRoleId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.EmpRoles", t => t.EmpRoleId, cascadeDelete: true)
                .Index(t => t.EmpRoleId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.EmpRoles",
                c => new
                    {
                        EmpRoleId = c.Int(nullable: false, identity: true),
                        EmpRoleName = c.String(),
                    })
                .PrimaryKey(t => t.EmpRoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "EmpRoleId", "dbo.EmpRoles");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Employees", new[] { "EmpRoleId" });
            DropTable("dbo.EmpRoles");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}

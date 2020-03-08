namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Data_ModelsInvoice_JuncUserDevice_Manu_Os_Type_VendorUpdate_Device_Employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JuncUserDevices",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        DeviceId = c.Int(nullable: false),
                        DateAssigned = c.DateTime(),
                        DateReturned = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.EmployeeId, t.DeviceId })
                .ForeignKey("dbo.Devices", t => t.DeviceId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.DeviceId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        InvoiceName = c.String(),
                        InvoiceDate = c.DateTime(),
                        VendorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId)
                .ForeignKey("dbo.Vendors", t => t.VendorId, cascadeDelete: true)
                .Index(t => t.VendorId);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorId = c.Int(nullable: false, identity: true),
                        VendorName = c.String(),
                    })
                .PrimaryKey(t => t.VendorId);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModelId)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.ManufacturerId)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ManufacturerId = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(),
                    })
                .PrimaryKey(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.TypeId);
            
            CreateTable(
                "dbo.Os",
                c => new
                    {
                        OsId = c.Int(nullable: false, identity: true),
                        OsName = c.String(),
                    })
                .PrimaryKey(t => t.OsId);
            
            AddColumn("dbo.Devices", "ModelId", c => c.Int(nullable: false));
            AddColumn("dbo.Devices", "OsId", c => c.Int(nullable: false));
            AddColumn("dbo.Devices", "InvoiceId", c => c.Int(nullable: false));
            CreateIndex("dbo.Devices", "ModelId");
            CreateIndex("dbo.Devices", "OsId");
            CreateIndex("dbo.Devices", "InvoiceId");
            AddForeignKey("dbo.Devices", "InvoiceId", "dbo.Invoices", "InvoiceId", cascadeDelete: true);
            AddForeignKey("dbo.Devices", "ModelId", "dbo.Models", "ModelId", cascadeDelete: true);
            AddForeignKey("dbo.Devices", "OsId", "dbo.Os", "OsId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JuncUserDevices", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Devices", "OsId", "dbo.Os");
            DropForeignKey("dbo.Models", "TypeId", "dbo.Types");
            DropForeignKey("dbo.Models", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Devices", "ModelId", "dbo.Models");
            DropForeignKey("dbo.JuncUserDevices", "DeviceId", "dbo.Devices");
            DropForeignKey("dbo.Invoices", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Devices", "InvoiceId", "dbo.Invoices");
            DropIndex("dbo.Models", new[] { "TypeId" });
            DropIndex("dbo.Models", new[] { "ManufacturerId" });
            DropIndex("dbo.Invoices", new[] { "VendorId" });
            DropIndex("dbo.Devices", new[] { "InvoiceId" });
            DropIndex("dbo.Devices", new[] { "OsId" });
            DropIndex("dbo.Devices", new[] { "ModelId" });
            DropIndex("dbo.JuncUserDevices", new[] { "DeviceId" });
            DropIndex("dbo.JuncUserDevices", new[] { "EmployeeId" });
            DropColumn("dbo.Devices", "InvoiceId");
            DropColumn("dbo.Devices", "OsId");
            DropColumn("dbo.Devices", "ModelId");
            DropTable("dbo.Os");
            DropTable("dbo.Types");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Models");
            DropTable("dbo.Vendors");
            DropTable("dbo.Invoices");
            DropTable("dbo.JuncUserDevices");
        }
    }
}

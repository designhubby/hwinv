namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_DataTypes_Vendors_Os_Role : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Types (TypeName) Values ('PC'),('GPS'),('Printer'),('Laptop'),('Mouse'),('Keyboard'),('Scanner'),('Monitor'),('Projector'),('Tablet'),('Headset'),('HWToken')");
            Sql("Insert INTO Vendors (VendorName) Values ('Microsoft'),('CDW'),('BeyondTrust'),('Dell'),('Amazon'),('Lenovo'),('Plantronics'),('Apple'),('Jump')");
            Sql("Insert INTO Os (OsName) Values ('Windows 7'),('Windows 8'),('Windows 8.1'),('Windows 10'),('Embedded'),('None'),('Linux'),('iOS'),('Android'),('Windows Server 2008'),('Windows Server 2012'),('Windows Server 2016'),('Windows Server 2019'),('Azure')");
            Sql("Insert INTO EmpRoles (EmpRoleName) Values ('Clerk'),('Executive Assistant'),('Manager'),('Supervisor'),('Analyst')");
        }
        
        public override void Down()
        {
        }
    }
}

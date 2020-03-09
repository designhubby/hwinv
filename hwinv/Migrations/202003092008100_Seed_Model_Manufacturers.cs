namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Model_Manufacturers : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Manufacturers (ManufacturerName) VALUES ('Microsoft'),('CDW'),('BeyondTrust'),('Dell'),('Amazon'),('Lenovo'),('Plantronics'),('Apple'),('Jump')");
        }
        
        public override void Down()
        {
        }
    }
}

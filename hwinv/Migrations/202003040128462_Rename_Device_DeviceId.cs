namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rename_Device_DeviceId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Devices");
            DropColumn("dbo.Devices", "Id");
            AddColumn("dbo.Devices", "DeviceId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Devices", "DeviceId");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Devices", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Devices");
            DropColumn("dbo.Devices", "DeviceId");
            AddPrimaryKey("dbo.Devices", "Id");
        }
    }
}

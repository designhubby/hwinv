namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Device_Model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Service_tag = c.String(),
                        Asset_tag = c.String(),
                        Note = c.String(),
                        Returned = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Devices");
        }
    }
}

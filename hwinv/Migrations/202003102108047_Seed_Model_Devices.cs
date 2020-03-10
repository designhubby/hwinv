namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Model_Devices : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Devices(Service_tag, Asset_tag, Returned, ModelId, OsId, InvoiceId) VALUES('TEST94nVMD', 'J6d84d', 0, 6, 1, 1),('TESTRaPg96', 'gLed9g', 1, 2, 2, 1),('TESTp2ZhsK', '7RuCeL', 0, 8, 3, 1),('TESTM48wgU', 'v2T3zG', 0, 6, 1, 1),('TEST32zJvn','JS6y43',1,2,2,1),('TEST3rX9mu', '4UAtnj', 0, 8, 3, 1)");
        }
        
        public override void Down()
        {
        }
    }
}

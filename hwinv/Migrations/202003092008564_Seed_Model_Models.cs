namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Model_Models : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Models (Name, ManufacturerId, TypeId) VALUES ('Optiplex 9010', 4, 1),('Optiplex 7040',4,1),('Optiplex 7050',4,1),('Latitude 5289',4,4),('Latitude E7470',4,4),('XPS 13',4,4),('Latitude 7389',4,4),('Latitude 7340',4,4),('Latitude 7480',4,4),('Optiplex 9020M',4,4),('Surface Pro 4',1,4),('Surface Pro 3',1,4)");
        }
        
        public override void Down()
        {

        }
    }
}

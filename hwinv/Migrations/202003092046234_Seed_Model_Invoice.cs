namespace hwinv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Model_Invoice : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Invoices (InvoiceName,InvoiceDate,VendorId) VALUES ('PO123456',2010-01-01,4) ");
        }
        
        public override void Down()
        {
        }
    }
}

namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Foods");
            AlterColumn("dbo.Foods", "Barcode", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Markets", "Barcode", c => c.String(maxLength: 15));
            AlterColumn("dbo.Stocks", "Barcode", c => c.String(maxLength: 15));
            AddPrimaryKey("dbo.Foods", "Barcode");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Foods");
            AlterColumn("dbo.Stocks", "Barcode", c => c.String());
            AlterColumn("dbo.Markets", "Barcode", c => c.String());
            AlterColumn("dbo.Foods", "Barcode", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Foods", "Barcode");
        }
    }
}

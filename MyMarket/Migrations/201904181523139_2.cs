namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        Barcode = c.String(),
                        QuantitySold = c.Int(nullable: false),
                        DateTimeSold = c.DateTime(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionID);
            
            AddColumn("dbo.FoodTypes", "FoodName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FoodTypes", "FoodName");
            DropTable("dbo.Markets");
        }
    }
}

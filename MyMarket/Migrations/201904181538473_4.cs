namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Markets", "FoodName", c => c.String());
            AddColumn("dbo.Stocks", "FoodName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stocks", "FoodName");
            DropColumn("dbo.Markets", "FoodName");
        }
    }
}

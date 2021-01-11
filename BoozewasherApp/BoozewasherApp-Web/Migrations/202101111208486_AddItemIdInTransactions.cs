namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemIdInTransactions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "ItemId");
            AddForeignKey("dbo.Transactions", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            DropColumn("dbo.Transactions", "ItemsList");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "ItemsList", c => c.String());
            DropForeignKey("dbo.Transactions", "ItemId", "dbo.Items");
            DropIndex("dbo.Transactions", new[] { "ItemId" });
            DropColumn("dbo.Transactions", "ItemId");
        }
    }
}

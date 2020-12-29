namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedItemsListInTransactionToStringType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Transaction_Id", "dbo.Transactions");
            DropIndex("dbo.Items", new[] { "Transaction_Id" });
            AddColumn("dbo.Transactions", "ItemsList", c => c.String());
            DropColumn("dbo.Items", "Transaction_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Transaction_Id", c => c.Int());
            DropColumn("dbo.Transactions", "ItemsList");
            CreateIndex("dbo.Items", "Transaction_Id");
            AddForeignKey("dbo.Items", "Transaction_Id", "dbo.Transactions", "Id");
        }
    }
}

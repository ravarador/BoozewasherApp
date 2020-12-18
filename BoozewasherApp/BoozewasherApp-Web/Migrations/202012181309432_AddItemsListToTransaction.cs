namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemsListToTransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Transaction_Id", c => c.Int());
            CreateIndex("dbo.Items", "Transaction_Id");
            AddForeignKey("dbo.Items", "Transaction_Id", "dbo.Transactions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Transaction_Id", "dbo.Transactions");
            DropIndex("dbo.Items", new[] { "Transaction_Id" });
            DropColumn("dbo.Items", "Transaction_Id");
        }
    }
}

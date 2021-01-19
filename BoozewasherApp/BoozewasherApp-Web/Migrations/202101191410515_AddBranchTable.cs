namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBranchTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Items", "BranchId", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "BranchId", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "BranchId");
            CreateIndex("dbo.Transactions", "BranchId");
            AddForeignKey("dbo.Items", "BranchId", "dbo.Branches", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Transactions", "BranchId", "dbo.Branches", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Items", "BranchId", "dbo.Branches");
            DropIndex("dbo.Transactions", new[] { "BranchId" });
            DropIndex("dbo.Items", new[] { "BranchId" });
            DropColumn("dbo.Transactions", "BranchId");
            DropColumn("dbo.Items", "BranchId");
            DropTable("dbo.Branches");
        }
    }
}

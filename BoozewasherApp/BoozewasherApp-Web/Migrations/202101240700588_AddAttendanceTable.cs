namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendanceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeInDate = c.DateTime(nullable: false),
                        TimeOutDate = c.DateTime(),
                        BranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "BranchId", "dbo.Branches");
            DropIndex("dbo.Attendances", new[] { "BranchId" });
            DropTable("dbo.Attendances");
        }
    }
}

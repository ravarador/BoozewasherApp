namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Birthdate = c.String(),
                        TIN = c.String(),
                        Email = c.String(),
                        ContactNo = c.String(),
                        BranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "BranchId", "dbo.Branches");
            DropIndex("dbo.Employees", new[] { "BranchId" });
            DropTable("dbo.Employees");
        }
    }
}

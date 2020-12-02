namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatabaseUsingAPI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                        Expense = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Summaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        CostTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CarwashCountTotal = c.Int(nullable: false),
                        DetailingCountTotal = c.Int(nullable: false),
                        PaintJobCountTotal = c.Int(nullable: false),
                        BackToZeroCountTotal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        PlateNumber = c.String(),
                        ServiceId = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.VehicleId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Transactions", "ServiceId", "dbo.Services");
            DropIndex("dbo.Transactions", new[] { "VehicleId" });
            DropIndex("dbo.Transactions", new[] { "ServiceId" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.Transactions");
            DropTable("dbo.Summaries");
            DropTable("dbo.Services");
        }
    }
}

namespace BoozewasherApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables_ServiceSummaryTransactionVehicle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Service",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                        Expense = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Summary",
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
                "dbo.Transaction",
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
                .ForeignKey("dbo.Service", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicle", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.VehicleId);
            
            CreateTable(
                "dbo.Vehicle",
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
            DropForeignKey("dbo.Transaction", "VehicleId", "dbo.Vehicle");
            DropForeignKey("dbo.Transaction", "ServiceId", "dbo.Service");
            DropIndex("dbo.Transaction", new[] { "VehicleId" });
            DropIndex("dbo.Transaction", new[] { "ServiceId" });
            DropTable("dbo.Vehicle");
            DropTable("dbo.Transaction");
            DropTable("dbo.Summary");
            DropTable("dbo.Service");
        }
    }
}

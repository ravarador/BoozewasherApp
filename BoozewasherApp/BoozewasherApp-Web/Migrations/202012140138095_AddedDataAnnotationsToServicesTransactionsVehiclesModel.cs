namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotationsToServicesTransactionsVehiclesModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Transactions", "PlateNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Type", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Vehicles", "Brand", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Model", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Model", c => c.String());
            AlterColumn("dbo.Vehicles", "Brand", c => c.String());
            AlterColumn("dbo.Vehicles", "Type", c => c.String());
            AlterColumn("dbo.Transactions", "PlateNumber", c => c.String());
            AlterColumn("dbo.Services", "Type", c => c.String());
        }
    }
}

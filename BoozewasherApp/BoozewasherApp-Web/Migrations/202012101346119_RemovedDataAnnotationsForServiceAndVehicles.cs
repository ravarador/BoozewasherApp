namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDataAnnotationsForServiceAndVehicles : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Description", c => c.String());
            AlterColumn("dbo.Vehicles", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "Description", c => c.String(nullable: false));
        }
    }
}

namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotationsForServiceAndVehicles : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Description", c => c.String());
            AlterColumn("dbo.Services", "Description", c => c.String());
        }
    }
}

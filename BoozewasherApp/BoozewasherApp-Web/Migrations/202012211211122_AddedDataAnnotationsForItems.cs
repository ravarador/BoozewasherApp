namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotationsForItems : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "Barcode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Barcode", c => c.String());
            AlterColumn("dbo.Items", "Name", c => c.String());
        }
    }
}

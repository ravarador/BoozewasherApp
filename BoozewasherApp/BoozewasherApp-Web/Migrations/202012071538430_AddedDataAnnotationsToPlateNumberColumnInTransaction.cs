namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotationsToPlateNumberColumnInTransaction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "PlateNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "PlateNumber", c => c.String());
        }
    }
}

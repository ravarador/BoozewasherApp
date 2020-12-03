namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDataAnnotationDescriptionServices : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "Description", c => c.String(nullable: false));
        }
    }
}

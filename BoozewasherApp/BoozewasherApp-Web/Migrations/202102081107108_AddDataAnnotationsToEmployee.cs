namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsToEmployee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "MiddleName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Birthdate", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "ContactNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "ContactNo", c => c.String());
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "Birthdate", c => c.String());
            AlterColumn("dbo.Employees", "Address", c => c.String());
            AlterColumn("dbo.Employees", "LastName", c => c.String());
            AlterColumn("dbo.Employees", "MiddleName", c => c.String());
            AlterColumn("dbo.Employees", "FirstName", c => c.String());
        }
    }
}

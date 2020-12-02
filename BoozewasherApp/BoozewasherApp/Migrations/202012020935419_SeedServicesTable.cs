namespace BoozewasherApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedServicesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Service(Type, Description, Expense) VALUES('CARWASH', '', 0.00)");
            Sql("INSERT INTO Service(Type, Description, Expense) VALUES('BACK TO ZERO', '', 0.00)");
            Sql("INSERT INTO Service(Type, Description, Expense) VALUES('DETAILING', '', 0.00)");
            Sql("INSERT INTO Service(Type, Description, Expense) VALUES('PAINT JOB', '', 0.00)");
        }
        
        public override void Down()
        {
        }
    }
}

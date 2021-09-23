namespace VioPliroforikh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MandatoryPatientEmail : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "Email", c => c.String(nullable: false, maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Email", c => c.String(maxLength: 4000));
        }
    }
}

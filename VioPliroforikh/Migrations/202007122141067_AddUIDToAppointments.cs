namespace VioPliroforikh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUIDToAppointments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "UID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "UID");
        }
    }
}

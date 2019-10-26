namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PassWord", c => c.String());
            DropColumn("dbo.Users", "PassWrod");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "PassWrod", c => c.String());
            DropColumn("dbo.Users", "PassWord");
        }
    }
}

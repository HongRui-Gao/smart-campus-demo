namespace BDQN.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSystemMenus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Roles", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "RealName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Tel", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Address", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Address", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "Tel", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "RealName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Roles", "Title", c => c.String(maxLength: 50));
        }
    }
}

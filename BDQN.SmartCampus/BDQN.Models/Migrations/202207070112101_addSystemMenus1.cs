namespace BDQN.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSystemMenus1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemMenus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Link = c.String(nullable: false, maxLength: 50),
                        Icon = c.String(maxLength: 50),
                        ParentId = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemMenus");
        }
    }
}

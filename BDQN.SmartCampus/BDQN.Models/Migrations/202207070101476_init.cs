namespace BDQN.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RealName = c.String(maxLength: 50),
                        BornTime = c.DateTime(nullable: false, storeType: "date"),
                        Gender = c.Int(nullable: false),
                        Email = c.String(maxLength: 50),
                        Tel = c.String(maxLength: 50),
                        Photo = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        RolesId = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}

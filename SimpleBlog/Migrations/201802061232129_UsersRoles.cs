namespace SimpleBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsersRoles",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Role_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Role_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UsersRoles", "User_Id", "dbo.Users");
            DropIndex("dbo.UsersRoles", new[] { "Role_Id" });
            DropIndex("dbo.UsersRoles", new[] { "User_Id" });
            DropTable("dbo.UsersRoles");
        }
    }
}

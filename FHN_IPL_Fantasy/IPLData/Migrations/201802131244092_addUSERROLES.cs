namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUSERROLES : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsrRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AppRoles_ID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AppRoles", t => t.AppRoles_ID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.AppRoles_ID)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsrRoles", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.UsrRoles", "AppRoles_ID", "dbo.AppRoles");
            DropIndex("dbo.UsrRoles", new[] { "User_UserID" });
            DropIndex("dbo.UsrRoles", new[] { "AppRoles_ID" });
            DropTable("dbo.UsrRoles");
        }
    }
}

namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addplayertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        PlayerRole_RoleID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PlayerRoles", t => t.PlayerRole_RoleID)
                .Index(t => t.PlayerRole_RoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "PlayerRole_RoleID", "dbo.PlayerRoles");
            DropIndex("dbo.Players", new[] { "PlayerRole_RoleID" });
            DropTable("dbo.Players");
        }
    }
}

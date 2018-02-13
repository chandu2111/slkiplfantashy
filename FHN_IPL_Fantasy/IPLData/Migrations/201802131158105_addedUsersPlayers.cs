namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedUsersPlayers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTeamPlayers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IPLSeason_ID = c.Int(),
                        Player_ID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IPLSeasons", t => t.IPLSeason_ID)
                .ForeignKey("dbo.Players", t => t.Player_ID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.IPLSeason_ID)
                .Index(t => t.Player_ID)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTeamPlayers", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.UserTeamPlayers", "Player_ID", "dbo.Players");
            DropForeignKey("dbo.UserTeamPlayers", "IPLSeason_ID", "dbo.IPLSeasons");
            DropIndex("dbo.UserTeamPlayers", new[] { "User_UserID" });
            DropIndex("dbo.UserTeamPlayers", new[] { "Player_ID" });
            DropIndex("dbo.UserTeamPlayers", new[] { "IPLSeason_ID" });
            DropTable("dbo.UserTeamPlayers");
        }
    }
}

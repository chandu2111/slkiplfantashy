namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedTeamPlayerMapping : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TeamPlayerMappings");
            AddColumn("dbo.TeamPlayerMappings", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.TeamPlayerMappings", "IPLSeason_ID", c => c.Int());
            AddColumn("dbo.TeamPlayerMappings", "IPLTeam_ID", c => c.Int());
            AddColumn("dbo.TeamPlayerMappings", "Player_ID", c => c.Int());
            AddPrimaryKey("dbo.TeamPlayerMappings", "ID");
            CreateIndex("dbo.TeamPlayerMappings", "IPLSeason_ID");
            CreateIndex("dbo.TeamPlayerMappings", "IPLTeam_ID");
            CreateIndex("dbo.TeamPlayerMappings", "Player_ID");
            AddForeignKey("dbo.TeamPlayerMappings", "IPLSeason_ID", "dbo.IPLSeasons", "ID");
            AddForeignKey("dbo.TeamPlayerMappings", "IPLTeam_ID", "dbo.IPLTeams", "ID");
            AddForeignKey("dbo.TeamPlayerMappings", "Player_ID", "dbo.Players", "ID");
            DropColumn("dbo.TeamPlayerMappings", "PlayerID");
            DropColumn("dbo.TeamPlayerMappings", "IPLTeamID");
            DropColumn("dbo.TeamPlayerMappings", "IPLSeasonID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeamPlayerMappings", "IPLSeasonID", c => c.Int(nullable: false));
            AddColumn("dbo.TeamPlayerMappings", "IPLTeamID", c => c.Int(nullable: false));
            AddColumn("dbo.TeamPlayerMappings", "PlayerID", c => c.Int(nullable: false));
            DropForeignKey("dbo.TeamPlayerMappings", "Player_ID", "dbo.Players");
            DropForeignKey("dbo.TeamPlayerMappings", "IPLTeam_ID", "dbo.IPLTeams");
            DropForeignKey("dbo.TeamPlayerMappings", "IPLSeason_ID", "dbo.IPLSeasons");
            DropIndex("dbo.TeamPlayerMappings", new[] { "Player_ID" });
            DropIndex("dbo.TeamPlayerMappings", new[] { "IPLTeam_ID" });
            DropIndex("dbo.TeamPlayerMappings", new[] { "IPLSeason_ID" });
            DropPrimaryKey("dbo.TeamPlayerMappings");
            DropColumn("dbo.TeamPlayerMappings", "Player_ID");
            DropColumn("dbo.TeamPlayerMappings", "IPLTeam_ID");
            DropColumn("dbo.TeamPlayerMappings", "IPLSeason_ID");
            DropColumn("dbo.TeamPlayerMappings", "ID");
            AddPrimaryKey("dbo.TeamPlayerMappings", new[] { "PlayerID", "IPLTeamID", "IPLSeasonID" });
        }
    }
}

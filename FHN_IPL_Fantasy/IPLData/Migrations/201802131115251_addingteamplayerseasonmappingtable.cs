namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingteamplayerseasonmappingtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamPlayerMappings",
                c => new
                    {
                        PlayerID = c.Int(nullable: false),
                        IPLTeamID = c.Int(nullable: false),
                        IPLSeasonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlayerID, t.IPLTeamID, t.IPLSeasonID });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TeamPlayerMappings");
        }
    }
}

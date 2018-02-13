namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingscoresTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IndividualScores",
                c => new
                    {
                        ScoreID = c.Int(nullable: false, identity: true),
                        Runs = c.Int(nullable: false),
                        Catches = c.Int(nullable: false),
                        Wickets = c.Int(nullable: false),
                        MatchID_ID = c.Int(),
                        PlayerID_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ScoreID)
                .ForeignKey("dbo.IPLMatches", t => t.MatchID_ID)
                .ForeignKey("dbo.Players", t => t.PlayerID_ID)
                .Index(t => t.MatchID_ID)
                .Index(t => t.PlayerID_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IndividualScores", "PlayerID_ID", "dbo.Players");
            DropForeignKey("dbo.IndividualScores", "MatchID_ID", "dbo.IPLMatches");
            DropIndex("dbo.IndividualScores", new[] { "PlayerID_ID" });
            DropIndex("dbo.IndividualScores", new[] { "MatchID_ID" });
            DropTable("dbo.IndividualScores");
        }
    }
}

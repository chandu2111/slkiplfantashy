namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addediplmatchtabl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IPLMatches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Team1 = c.Int(nullable: false),
                        Team2 = c.Int(nullable: false),
                        MatchDate = c.DateTime(nullable: false),
                        Result = c.String(),
                        IPLSeason_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IPLSeasons", t => t.IPLSeason_ID)
                .Index(t => t.IPLSeason_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IPLMatches", "IPLSeason_ID", "dbo.IPLSeasons");
            DropIndex("dbo.IPLMatches", new[] { "IPLSeason_ID" });
            DropTable("dbo.IPLMatches");
        }
    }
}

namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addediplteams1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IPLTeams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        IPLSeason_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IPLSeasons", t => t.IPLSeason_ID)
                .Index(t => t.IPLSeason_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IPLTeams", "IPLSeason_ID", "dbo.IPLSeasons");
            DropIndex("dbo.IPLTeams", new[] { "IPLSeason_ID" });
            DropTable("dbo.IPLTeams");
        }
    }
}

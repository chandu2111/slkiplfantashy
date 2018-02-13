namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IPLSeasons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SeasonYear = c.Int(nullable: false),
                        PurpleCap = c.Int(nullable: false),
                        OrangeCap = c.Int(nullable: false),
                        WinnerID = c.Int(nullable: false),
                        RunnerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IPLSeasons");
        }
    }
}

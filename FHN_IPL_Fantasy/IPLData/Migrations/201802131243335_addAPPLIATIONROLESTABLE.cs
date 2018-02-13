namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAPPLIATIONROLESTABLE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AppRoles");
        }
    }
}

namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addplayerroles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerRoles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        RoleSubType = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlayerRoles");
        }
    }
}

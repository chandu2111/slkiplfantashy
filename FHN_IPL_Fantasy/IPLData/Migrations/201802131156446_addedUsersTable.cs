namespace IPLData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedUsersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        UserScore = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        ModifyDate = c.DateTime(nullable: false),
                        UserTeamName = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}

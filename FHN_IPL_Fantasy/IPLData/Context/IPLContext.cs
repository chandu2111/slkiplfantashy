namespace IPLData.Context
{
    using Entities.IndividualScores;
    using Entities.PlayerRole;
    
    using Entities.Players;
    using Entities.TeamPlayers;
    using Entities.UserRole;
    using Entities.Users;
    using Entities.UsersTeam;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IPLContext : DbContext
    {
        // Your context has been configured to use a 'IPLContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'IPLData.Context.IPLContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'IPLContext' 
        // connection string in the application configuration file.
        public IPLContext()
            : base("name=IPLContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        // public DbSet<Player> Players { get; set; }
        // public DbSet<IndividualScore> IndividualScores { get; set; }



        public DbSet<Entities.IPLMatches.IPLMatch> IPLMatches { get; set; }

        public DbSet<Entities.FantasySeason.IPLSeason> IPLSeason { get; set; }

        public DbSet<Entities.IPLTeam.IPLTeam> IPLTeams { get; set; }

        public DbSet<PlayerRole> PlayerRole { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<TeamPlayerMapping> TeamPlayerMappings { get; set; }

        public DbSet<IndividualScore> Scores { get; set; }


        public DbSet<User> Users { get; set; }


        public DbSet<UserTeamPlayers> UserPlayers { get; set; }

        public DbSet<AppRoles> AppRoles { get; set; }

        public DbSet<UsrRole> UserRole { get; set; }



    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
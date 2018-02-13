using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.UsersTeam
{
    public class UserTeamPlayers
    {
        public int ID { get; set; }

        public Players.Player Player { get; set; }

        public Users.User User { get; set; }

        public FantasySeason.IPLSeason IPLSeason { get; set; }


    }
}

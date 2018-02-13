using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TeamPlayers
{
   public class TeamPlayerMapping
    {
        public int ID { get; set; }
        [Key,Column(Order=0)]
        public Players.Player Player { get; set; }
        [Key,Column(Order=1)]
        public IPLTeam.IPLTeam IPLTeam{ get; set; }
        [Key,Column(Order=2)]
        public FantasySeason.IPLSeason IPLSeason { get; set; }
    }
}

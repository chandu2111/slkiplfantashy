using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IndividualScores
{
    public class IndividualScore
    {
        [Key]
        public int ScoreID { get; set; }

        public Players.Player PlayerID { get; set; }

        public int Runs { get; set; }

        public int Catches { get; set; }

        public int Wickets { get; set; }

        public IPLMatches.IPLMatch MatchID { get; set; }


    }
}

using Entities.FantasySeason;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.IPLMatches
{
    public class IPLMatch
    {
        public int ID { get; set; }
        public int Team1 { get; set; }

        public int Team2 { get; set; }

        public DateTime MatchDate { get; set; }

        public string Result { get; set; }
        
        public IPLSeason IPLSeason { get; set; }

    }
}

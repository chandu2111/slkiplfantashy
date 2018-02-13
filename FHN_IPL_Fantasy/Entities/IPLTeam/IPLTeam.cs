using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.FantasySeason;

namespace Entities.IPLTeam
{
    public class IPLTeam
    {
        public int ID { get; set; }
        public string TeamName { get; set; }

        public IPLSeason IPLSeason { get; set; }
    }
}

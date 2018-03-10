using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.UserWeeklyChanges
{
    public class WeekGameRule
    {
        public int ID { get; set; }
        public int NoOfPlayers { get; set; }

        public IPLGameStages.IPLGameStage IPLGameStage { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime Enddate { get; set; }



    }
}

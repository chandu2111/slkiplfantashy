using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.FantasySeason
{
    public class IPLSeason
    {
        public int ID { get; set; }
        public int  SeasonYear { get; set; }

        public int PurpleCap { get; set; }

        public int OrangeCap { get; set; }

        public  int WinnerID { get; set; }

        public int RunnerID { get; set; }


    }
}

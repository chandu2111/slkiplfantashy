using Entities.IPLGameStages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IPLPredictions
{
    public class Prediction
    {
        public int ID { get; set; }
        public string Question { get; set;}

        public DateTime Qdate { get; set; }

        public int Points { get; set; }

        public DateTime ExpireDate { get; set; }

        public char QStatus { get; set; }

        public IPLMatches.IPLMatch IPLMatch { get; set; }

        public IPLGameStage IPLGameStage { get; set; }
    }
}

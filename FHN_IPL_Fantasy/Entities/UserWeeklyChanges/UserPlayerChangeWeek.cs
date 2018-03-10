using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.UserWeeklyChanges
{
    public class UserPlayerChangeWeek
    {
        public int ID { get; set; }

        public int WeekID { get; set; }

        public int  UserID { get; set; }

        public int OldPlayer { get; set; }

        public int NewPlayer { get; set; }

        public string WeekName { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung
{
    class SportsFestival
    {
        private int sportsFestivalId;
        private DateTime date;
        public bool deletedFlag;
        public bool newFlag;
        
        public SportsFestival (int isportsFestivalId, DateTime idate)
        {
            sportsFestivalId = isportsFestivalId;
            date = idate;
            deletedFlag = false;
            newFlag = false;
        }

        public int GetSportsFestivalId()
        {
            return sportsFestivalId;
        }

        public DateTime GetSportsFestivalDate()
        {
            return date;
        }
    }
}

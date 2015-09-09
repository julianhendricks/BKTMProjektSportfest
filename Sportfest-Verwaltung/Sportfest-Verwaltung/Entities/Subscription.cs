using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung.Entities
{
    class Subscription
    {
        private int sportsFestivalSubscriptionId;
        private int competitionId;
        private int disciplineId;
        private float result;

        public int SportsFestivalSubscriptionId
        {
            get
            {
                return sportsFestivalSubscriptionId;
            }
            set
            {
                sportsFestivalSubscriptionId = value;
            }
        }

        public int CompetitionId
        {
            get
            {
                return competitionId;
            }
            set
            {
                competitionId = value;
            }
        }

        public int DisciplineId
        {
            get
            {
                return disciplineId;
            }
            set
            {
                disciplineId = value;
            }
        }

        public float Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }
    }
}

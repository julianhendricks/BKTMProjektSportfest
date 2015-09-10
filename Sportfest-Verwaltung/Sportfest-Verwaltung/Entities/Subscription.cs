using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement.Entities
{
    class Subscription
    {
        private int sportsFestivalSubscriptionId;
        private int competitionId;
        private int disciplineId;
        private double result;

        public Subscription(
            int sportsFestivalSubscriptionId,
            int competitionId,
            int disciplineId,
            double result
        ) {
            this.sportsFestivalSubscriptionId = sportsFestivalSubscriptionId;
            this.competitionId = competitionId;
            this.disciplineId = disciplineId;
            this.result = result;
        }

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

        public double Result
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

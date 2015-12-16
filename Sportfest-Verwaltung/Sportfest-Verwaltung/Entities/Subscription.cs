using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class Subscription
    {
        private int sportsFestivalSubscriptionId;
        private Competition competition;
        private Discipline discipline;
        private double result;

        public Subscription(
            int sportsFestivalSubscriptionId,
            Competition competition,
            Discipline discipline,
            double result
        ) {
            this.sportsFestivalSubscriptionId = sportsFestivalSubscriptionId;
            this.competition = competition;
            this.discipline = discipline;
            this.result = result;
        }

        public int SportsFestivalSubscriptionId
        {
            get
            {
                return this.sportsFestivalSubscriptionId;
            }
            set
            {
                this.sportsFestivalSubscriptionId = value;
            }
        }

        public Competition Competition
        {
            get
            {
                return this.competition;
            }
            set
            {
                this.competition = value;
            }
        }

        public Discipline Discipline
        {
            get
            {
                return this.discipline;
            }
            set
            {
                this.discipline = value;
            }
        }

        public double Result
        {
            get
            {
                return this.result;
            }
            set
            {
                this.result = value;
            }
        }
    }
}

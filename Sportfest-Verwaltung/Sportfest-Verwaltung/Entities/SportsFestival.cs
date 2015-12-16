using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class SportsFestival
    {
        private int sportsFestivalId;
        private DateTime date;
        private List<Competition> competitions = new List<Competition>();

        public SportsFestival(
            int sportsFestivalId,
            DateTime date
        ) {
            this.sportsFestivalId = sportsFestivalId;
            this.date = date;
        }

        public SportsFestival(
            int sportsFestivalId,
            DateTime date,
            List<Competition> competitions
        ) {
            this.sportsFestivalId = sportsFestivalId;
            this.date = date;
            this.competitions = competitions;
        }

        public int SportsFestivalId
        {
            get
            {
                return this.sportsFestivalId;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public List<Competition> getCompetitions()
        {
            return this.competitions;
        }

        public void addCompetition(Competition competition)
        {
            this.competitions.Add(competition);
        }

        public void removeCompetition(Competition competition)
        {
            this.competitions.Remove(competition);
        }
    }
}

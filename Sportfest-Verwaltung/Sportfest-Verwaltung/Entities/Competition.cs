using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement.Entities
{
    class Competition
    {
        private int competitionId;
        private string competitionName;

        public Competition(
            int competitionId,
            string competitionName
        ) {
            this.competitionId = competitionId;
            this.competitionName = competitionName;
        }

        public int CompetitionId
        {
            get
            {
                return competitionId;
            }
        }

        public string CompetitionName
        {
            get
            {
                return competitionName;
            }
            set
            {
                competitionName = value;
            }
        }
    }
}

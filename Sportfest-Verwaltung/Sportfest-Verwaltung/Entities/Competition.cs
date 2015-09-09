using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung.Entities
{
    class Competition
    {
        private int competitionId;
        private string competitionName;

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

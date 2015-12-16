using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class Competition
    {
        private int competitionId;
        private string competitionName;
        private List<DisciplineSet> disciplineSets = new List<DisciplineSet>();

        public Competition(
            int competitionId,
            string competitionName
        ) {
            this.competitionId = competitionId;
            this.competitionName = competitionName;
        }

        public Competition(
            int competitionId,
            string competitionName,
            List<DisciplineSet> disciplineSets
        ) {
            this.competitionId = competitionId;
            this.competitionName = competitionName;
            this.disciplineSets = disciplineSets;
        }

        public int CompetitionId
        {
            get
            {
                return this.competitionId;
            }
        }

        public string CompetitionName
        {
            get
            {
                return this.competitionName;
            }
            set
            {
                this.competitionName = value;
            }
        }

        public List<DisciplineSet> getDisciplineSets()
        {
            return this.disciplineSets;
        }

        public void addDisciplineSet(DisciplineSet disciplineSet)
        {
            this.disciplineSets.Add(disciplineSet);
        }

        public void removeDisciplineSet(DisciplineSet disciplineSet)
        {
            this.disciplineSets.Remove(disciplineSet);
        }
    }
}

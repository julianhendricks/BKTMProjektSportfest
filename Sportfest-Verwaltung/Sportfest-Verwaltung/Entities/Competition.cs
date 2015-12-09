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
        private List<DisciplineSet> disciplineSets;

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

        public List<DisciplineSet> getDisciplineSets()
        {
            return disciplineSets;
        }

        public void addDiscipline(DisciplineSet disciplineSet)
        {
            disciplineSets.Add(disciplineSet);
        }

        public void removeDiscipline(DisciplineSet disciplineSet)
        {
            disciplineSets.Remove(disciplineSet);
        }
    }
}

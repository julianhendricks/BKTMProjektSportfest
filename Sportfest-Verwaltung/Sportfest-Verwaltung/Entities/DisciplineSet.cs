using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class DisciplineSet
    {
        private int disciplineSetId;
        private List<Discipline> disciplines;
        private List<Competition> competitions;
        private List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings;

        public DisciplineSet(
            int disciplineSetId,
            List<Discipline> disciplines,
            List<Competition> competitions,
            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings
        ) {
            this.disciplineSetId = disciplineSetId;
            this.disciplines = disciplines;
            this.competitions = competitions;
            this.disciplineSetDisciplineMappings = disciplineSetDisciplineMappings;
        }

        public int DisciplineSetId
        {
            get
            {
                return disciplineSetId;
            }
        }

        public List<Discipline> getDisciplines()
        {
            return disciplines;
        }

        public void addDiscipline(Discipline discipline)
        {
            disciplines.Add(discipline);
        }

        public void removeDiscipline(Discipline discipline)
        {
            disciplines.Remove(discipline);
        }

        public List<Competition> getCompetitions()
        {
            return competitions;
        }

        public void addCompetition(Competition competition)
        {
            competitions.Add(competition);
        }

        public void removeCompetition(Competition competition)
        {
            competitions.Remove(competition);
        }

        public List<DisciplineSetDisciplineMapping> getDisciplineSetDisciplineMappings()
        {
            return disciplineSetDisciplineMappings;
        }

        public void addDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            disciplineSetDisciplineMappings.Add(disciplineSetDisciplineMapping);
        }

        public void removeDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            disciplineSetDisciplineMappings.Remove(disciplineSetDisciplineMapping);
        }
    }
}

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
            int disciplineSetId
        ) {
            this.disciplineSetId = disciplineSetId;
        }

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
                return this.disciplineSetId;
            }
        }

        public List<Discipline> getDisciplines()
        {
            return this.disciplines;
        }

        public void addDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void removeDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
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

        public List<DisciplineSetDisciplineMapping> getDisciplineSetDisciplineMappings()
        {
            return this.disciplineSetDisciplineMappings;
        }

        public void addDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            this.disciplineSetDisciplineMappings.Add(disciplineSetDisciplineMapping);
        }

        public void removeDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            this.disciplineSetDisciplineMappings.Remove(disciplineSetDisciplineMapping);
        }
    }
}

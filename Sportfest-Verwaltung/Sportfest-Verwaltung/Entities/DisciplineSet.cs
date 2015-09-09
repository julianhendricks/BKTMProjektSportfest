using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung.Entities
{
    class DisciplineSet
    {
        private int disciplineSetId;
        private List<Discipline> disciplines;

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
    }
}

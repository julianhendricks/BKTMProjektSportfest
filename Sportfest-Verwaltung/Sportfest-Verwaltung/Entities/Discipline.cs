using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement.Entities
{
    class Discipline
    {
        private int disciplineId;
        private string name;
        private Measure measure;
        private Category category;
        private List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings;


        public Discipline(
            int disciplineId,
            string name,
            Measure measure,
            Category category,
            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings
        ) {
            this.disciplineId = disciplineId;
            this.name = name;
            this.measure = measure;
            this.category = category;
            this.disciplineSetDisciplineMappings = disciplineSetDisciplineMappings;
        }

        public int DisciplineId
        {
            get
            {
                return disciplineId;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Measure Measure
        {
            get
            {
                return measure;
            }

            set
            {
                measure = value;
            }
        }

        public Category Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
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

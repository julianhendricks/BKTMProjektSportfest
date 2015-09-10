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
        private string measure;
        private int categoryId;

        public Discipline(
            int disciplineId,
            string measure,
            int categoryId
        ) {
            this.disciplineId = disciplineId;
            this.measure = measure;
            this.categoryId = categoryId;
        }

        public int DisciplineId
        {
            get
            {
                return disciplineId;
            }
        }

        public string Measure
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

        public int CategoryId
        {
            get
            {
                return categoryId;
            }
            set
            {
                categoryId = value;
            }
        }
    }
}

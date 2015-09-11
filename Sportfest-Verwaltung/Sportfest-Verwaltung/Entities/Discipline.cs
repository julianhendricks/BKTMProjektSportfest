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
        private int measureId;
        private int categoryId;


        public Discipline(
            int disciplineId,
            string name,
            int measureId,
            int categoryId
        ) {
            this.disciplineId = disciplineId;
            this.name = name;
            this.measureId = measureId;
            this.categoryId = categoryId;
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

        public int MeasureId
        {
            get
            {
                return measureId;
            }

            set
            {
                measureId = value;
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

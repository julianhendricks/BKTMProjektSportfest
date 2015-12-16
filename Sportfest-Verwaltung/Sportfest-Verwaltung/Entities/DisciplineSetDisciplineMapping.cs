using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class DisciplineSetDisciplineMapping
    {
        private int disciplineSetId;
        private int ageFrom;
        private int ageUntil;
        private int disciplineId;

        public DisciplineSetDisciplineMapping(
            int disciplineSetId,
            int ageFrom,
            int ageUntil,
            int disciplineId
        ) {
            this.disciplineSetId = disciplineSetId;
            this.ageFrom = ageFrom;
            this.ageUntil = ageUntil;
            this.disciplineId = disciplineId;
        }

        public int DisciplineSetId
        {
            get
            {
                return this.disciplineSetId;
            }
            set
            {
                this.disciplineSetId = value;
            }
        }

        public int AgeFrom
        {
            get
            {
                return this.ageFrom;
            }
            set
            {
                this.ageFrom = value;
            }
        }

        public int AgeUntil
        {
            get
            {
                return this.ageUntil;
            }
            set
            {
                this.ageUntil = value;
            }
        }

        public int DisciplineId
        {
            get
            {
                return this.disciplineId;
            }
            set
            {
                this.disciplineId = value;
            }
        }
    }
}

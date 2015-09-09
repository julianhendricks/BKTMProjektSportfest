using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement.Entities
{
    class DisciplineSetDisciplineMapping
    {
        private int disciplineSetId;
        private int ageFrom;
        private int ageUntil;
        private int disciplineId;

        public int DisciplineSetId
        {
            get
            {
                return disciplineSetId;
            }
            set
            {
                disciplineSetId = value;
            }
        }

        public int AgeFrom
        {
            get
            {
                return ageFrom;
            }
            set
            {
                ageFrom = value;
            }
        }

        public int AgeUntil
        {
            get
            {
                return ageUntil;
            }
            set
            {
                ageUntil = value;
            }
        }

        public int DisciplineId
        {
            get
            {
                return disciplineId;
            }
            set
            {
                disciplineId = value;
            }
        }
    }
}

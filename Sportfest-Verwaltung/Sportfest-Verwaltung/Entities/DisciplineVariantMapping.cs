using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement.Entities
{
    class DisciplineVariantMapping
    {
        private int disciplineId;
        private int ageFrom;
        private int ageUntil;
        private int variantId;

        public DisciplineVariantMapping(
            int disciplineId,
            int ageFrom,
            int ageUntil,
            int variantId
        ) {
            this.disciplineId = disciplineId;
            this.ageFrom = ageFrom;
            this.ageUntil = ageUntil;
            this.variantId = variantId;
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

        public int VariantId
        {
            get
            {
                return variantId;
            }

            set
            {
                variantId = value;
            }
        }
    }
}

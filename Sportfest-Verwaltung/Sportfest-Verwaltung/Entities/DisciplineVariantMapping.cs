using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung.Entities
{
    class DisciplineVariantMapping
    {
        private int disciplineId;
        private int ageFrom;
        private int ageUntil;
        private int variantId;

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

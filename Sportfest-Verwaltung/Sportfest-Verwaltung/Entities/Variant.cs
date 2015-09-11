using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement.Entities
{
    class Variant
    {
        private int variantId;
        private string variantName;
        private int ageFrom;
        private int ageUntil;
        private int disciplineId;

        public Variant(
            int variantId,
            string variantName,
            int ageFrom,
            int ageUntil,
            int disciplineId
        ) {
            this.variantId = variantId;
            this.variantName = variantName;
            this.ageFrom = ageFrom;
            this.ageUntil = ageUntil;
            this.disciplineId = disciplineId;
        }

        public int VariantId
        {
            get
            {
                return variantId;
            }
        }

        public string VariantName
        {
            get
            {
                return variantName;
            }

            set
            {
                variantName = value;
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

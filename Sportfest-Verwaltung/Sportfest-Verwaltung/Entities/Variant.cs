using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class Variant
    {
        private int variantId;
        private string variantName;
        private int ageFrom;
        private int ageUntil;
        private Discipline discipline = null;

        public Variant(
            int variantId,
            string variantName,
            int ageFrom,
            int ageUntil
        ) {
            this.variantId = variantId;
            this.variantName = variantName;
            this.ageFrom = ageFrom;
            this.ageUntil = ageUntil;
        }

        public Variant(
            int variantId,
            string variantName,
            int ageFrom,
            int ageUntil,
            Discipline discipline
        ) {
            this.variantId = variantId;
            this.variantName = variantName;
            this.ageFrom = ageFrom;
            this.ageUntil = ageUntil;
            this.discipline = discipline;
        }

        public int VariantId
        {
            get
            {
                return this.variantId;
            }
        }

        public string VariantName
        {
            get
            {
                return this.variantName;
            }

            set
            {
                this.variantName = value;
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

        public Discipline Discipline
        {
            get
            {
                return this.discipline;
            }

            set
            {
                this.discipline = value;
            }
        }
    }
}

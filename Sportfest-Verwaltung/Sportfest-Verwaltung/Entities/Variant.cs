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

        public Variant(
            int variantId,
            string variantName
        ) {
            this.variantId = variantId;
            this.variantName = variantName;
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
    }
}

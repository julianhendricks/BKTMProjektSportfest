using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung.Entities
{
    class Variant
    {
        private int variantId;
        private string variantName;

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

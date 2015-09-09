using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung.Entities
{
    class Category
    {
        private int categoryId;
        private string categoryName;

        public int CategoryId
        {
            get
            {
                return categoryId;
            }
        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }
    }
}

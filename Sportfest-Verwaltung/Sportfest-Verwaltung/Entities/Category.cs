using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class Category
    {
        private int categoryId;
        private string categoryName;

        public Category(
            int categoryId,
            string categoryName
        ) {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
        }

        public int CategoryId
        {
            get
            {
                return this.categoryId;
            }
        }

        public string CategoryName
        {
            get
            {
                return this.categoryName;
            }

            set
            {
                this.categoryName = value;
            }
        }
    }
}

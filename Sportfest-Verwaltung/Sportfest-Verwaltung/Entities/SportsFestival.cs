using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement.Entities
{
    class SportsFestival
    {
        private int sportsFestivalId;
        private DateTime date;

        public SportsFestival(
            int sportsFestivalId,
            DateTime date
        ) {
            this.sportsFestivalId = sportsFestivalId;
            this.date = date;
        }

        public int SportsFestivalId
        {
            get
            {
                return sportsFestivalId;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class SportsFestivalSubscription
    {
        private int sportsFestivalSubscriptionId;
        private int sportsFestivalId;
        private int studentId;
        private string classShortcut;

        public SportsFestivalSubscription(
            int sportsFestivalSubscriptionId,
            int sportsFestivalId,
            int studentId,
            string classShortcut
        ) {
            this.sportsFestivalSubscriptionId = sportsFestivalSubscriptionId;
            this.sportsFestivalId = sportsFestivalId;
            this.studentId = studentId;
            this.classShortcut = classShortcut;
        }

        public int SportsFestivalSubscriptionId
        {
            get
            {
                return this.sportsFestivalSubscriptionId;
            }
        }

        public int SportsFestivalId
        {
            get
            {
                return this.sportsFestivalId;
            }
            set
            {
                this.sportsFestivalId = value;
            }
        }

        public int StudentId
        {
            get
            {
                return this.studentId;
            }
            set
            {
                this.studentId = value;
            }
        }

        public string ClassShortcut
        {
            get
            {
                return this.classShortcut;
            }
            set
            {
                this.classShortcut = value;
            }
        }
    }
}

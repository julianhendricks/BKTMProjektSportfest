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
        private SportsFestival sportsFestival;
        private Student student;
        private string classShortcut;

        public SportsFestivalSubscription(
            int sportsFestivalSubscriptionId,
            SportsFestival sportsFestival,
            Student student,
            string classShortcut
        ) {
            this.sportsFestivalSubscriptionId = sportsFestivalSubscriptionId;
            this.sportsFestival = sportsFestival;
            this.student = student;
            this.classShortcut = classShortcut;
        }

        public int SportsFestivalSubscriptionId
        {
            get
            {
                return this.sportsFestivalSubscriptionId;
            }
        }

        public SportsFestival SportsFestival
        {
            get
            {
                return this.sportsFestival;
            }
            set
            {
                this.sportsFestival = value;
            }
        }

        public Student Student
        {
            get
            {
                return this.student;
            }
            set
            {
                this.student = value;
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

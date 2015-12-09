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
                return sportsFestivalSubscriptionId;
            }
        }

        public int SportsFestivalId
        {
            get
            {
                return sportsFestivalId;
            }
            set
            {
                sportsFestivalId = value;
            }
        }

        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }

        public string ClassShortcut
        {
            get
            {
                return classShortcut;
            }
            set
            {
                classShortcut = value;
            }
        }
    }
}

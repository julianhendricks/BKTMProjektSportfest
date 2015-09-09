using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung.Entities
{
    class SportsFestivalSubscription
    {
        private int sportsFestivalSubscriptionId;
        private int sportsFestivalId;
        private int studentId;
        private string classShortcut;

        public int SportsFestivalSubscriptionId
        {
            get
            {
                return sportsFestivalSubscriptionId;
            }
            set
            {
                sportsFestivalSubscriptionId = value;
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

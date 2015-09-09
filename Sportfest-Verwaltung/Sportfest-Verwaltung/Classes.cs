using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung
{
    class SportsFestival
    {
        private int sportsFestivalId;
        private DateTime date;
        public bool deletedFlag;
        public bool newFlag;
        
        public SportsFestival (int isportsFestivalId, DateTime idate)
        {
            sportsFestivalId = isportsFestivalId;
            date = idate;
            deletedFlag = false;
            newFlag = false;
        }

        public int GetSportsFestivalId()
        {
            return sportsFestivalId;
        }

        public DateTime GetSportsFestivalDate()
        {
            return date;
        }
    }

    class Classes
    {
        private int classId;
        private string shortcut;
        public bool deletedFlag;
        public bool newFlag;
        public bool changedFlag;

        public Classes(int iclassId, string ishortcut)
        {
            classId = iclassId;
            shortcut = ishortcut;
            deletedFlag = false;
            newFlag = false;
            changedFlag = false;
        }

        public int ClassId
        {
            get { return classId; }
        }


        public string getShortcut()
        {
            return shortcut;
        }

        public void setShortcut(string ishortcut)
        {
            shortcut = ishortcut;
        }
    }
}

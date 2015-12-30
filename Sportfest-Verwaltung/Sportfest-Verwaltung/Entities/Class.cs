using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class Class
    {
        private int classId;
        private string prefix;
        private int year;
        private string suffix;

        public Class(
            int classId,
            string prefix,
            int year,
            string suffix
        ) {
            this.classId = classId;
            this.prefix = prefix;
            this.year = year;
            this.suffix = suffix;
        }

        public int ClassId
        {
            get
            {
                return this.classId;
            }
        }

        public string Prefix
        {
            get
            {
                return this.prefix;
            }
            set
            {
                this.prefix = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        public string Suffix
        {
            get
            {
                return this.suffix;
            }
            set
            {
                this.suffix = value;
            }
        }

        public string Shortcut {
            get {
                return this.Prefix + this.Year.ToString() + this.Suffix;
            }
        }
    }
}

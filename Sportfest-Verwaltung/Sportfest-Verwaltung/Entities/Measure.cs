using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement.Entities
{
    class Measure
    {
        private int measureId;
        private string name;
        private string shortcut;

        public Measure(
            int measureId,
            string name,
            string shortcut
        ) {
            this.measureId = measureId;
            this.name = name;
            this.shortcut = shortcut;
        }

        public int MeasureId
        {
            get
            {
                return measureId;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Shortcut
        {
            get
            {
                return shortcut;
            }

            set
            {
                shortcut = value;
            }
        }
    }
}

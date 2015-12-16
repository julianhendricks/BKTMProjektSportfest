﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class Class
    {
        private int classId;
        private string shortcut;

        public Class(
            int classId,
            string shortcut
        ) {
            this.classId = classId;
            this.shortcut = shortcut;
        }

        public int ClassId
        {
            get
            {
                return this.classId;
            }
        }

        public string Shortcut
        {
            get
            {
                return this.shortcut;
            }
            set
            {
                this.shortcut = value;
            }
        }
    }
}

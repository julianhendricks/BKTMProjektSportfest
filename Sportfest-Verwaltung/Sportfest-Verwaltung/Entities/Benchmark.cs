using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportfest_Verwaltung.Entities
{
    class Benchmark
    {
        private int disciplineId;
        private int age;
        private char gender;
        private float benchmark;

        public int DisciplineId
        {
            get
            {
                return disciplineId;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public float BenchmarkValue
        {
            get
            {
                return benchmark;
            }
            set
            {
                benchmark = value;
            }
        }
    }
}

namespace SportsfestivalManagement.Entities
{
    class Benchmark
    {
        private int disciplineId;
        private int ageFrom;
        private int ageUntil;
        private char gender;
        private string rank;
        private double benchmark;

        public Benchmark(
            int disciplineId,
            int ageFrom,
            int ageUntil,
            char gender,
            string rank,
            double benchmark
        ) {
            this.disciplineId = disciplineId;
            this.ageFrom = ageFrom;
            this.ageUntil = ageUntil;
            this.gender = gender;
            this.rank = rank;
            this.benchmark = benchmark;
        }

        public int DisciplineId
        {
            get
            {
                return disciplineId;
            }
        }

        public int AgeFrom
        {
            get
            {
                return ageFrom;
            }
        }

        public int AgeUntil
        {
            get
            {
                return ageUntil;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }
        }

        public string Rank
        {
            get
            {
                return rank;
            }
        }

        public double BenchmarkValue
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

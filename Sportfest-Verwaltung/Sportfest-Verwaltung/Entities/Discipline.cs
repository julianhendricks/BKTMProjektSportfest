﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class Discipline
    {
        private int disciplineId;
        private string name;
        private Measure measure;
        private Category category;
        private List<Variant> variants = new List<Variant>();
        private List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings = new List<DisciplineSetDisciplineMapping>();


        public Discipline(
            int disciplineId,
            string name,
            Measure measure,
            Category category
        ) {
            this.disciplineId = disciplineId;
            this.name = name;
            this.measure = measure;
            this.category = category;
        }

        public Discipline(
            int disciplineId,
            string name,
            Measure measure,
            Category category,
            List<DisciplineSetDisciplineMapping> disciplineSetDisciplineMappings,
            List<Variant> variants
        ) {
            this.disciplineId = disciplineId;
            this.name = name;
            this.measure = measure;
            this.category = category;
            this.disciplineSetDisciplineMappings = disciplineSetDisciplineMappings;
            this.variants = variants;
        }

        public int DisciplineId
        {
            get
            {
                return this.disciplineId;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public Measure Measure
        {
            get
            {
                return this.measure;
            }

            set
            {
                this.measure = value;
            }
        }

        public Category Category
        {
            get
            {
                return this.category;
            }

            set
            {
                this.category = value;
            }
        }

        public List<DisciplineSetDisciplineMapping> getDisciplineSetDisciplineMappings()
        {
            return this.disciplineSetDisciplineMappings;
        }

        public void addDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            this.disciplineSetDisciplineMappings.Add(disciplineSetDisciplineMapping);
        }

        public void removeDisciplineSetDisciplineMapping(DisciplineSetDisciplineMapping disciplineSetDisciplineMapping)
        {
            this.disciplineSetDisciplineMappings.Remove(disciplineSetDisciplineMapping);
        }


        public List<Variant> getVariants()
        {
            return this.variants;
        }

        public void addVariant(Variant variant)
        {
            this.variants.Add(variant);
        }

        public void removeVariant(Variant variant)
        {
            this.variants.Remove(variant);
        }
    }
}

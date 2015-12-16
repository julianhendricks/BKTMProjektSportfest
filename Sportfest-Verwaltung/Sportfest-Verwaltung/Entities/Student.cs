using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFestivalManagement.Entities
{
    class Student
    {
        private int studentId;
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private char gender;
        private int zip;
        private string city;
        private Class classObject;
        private bool active;

        public Student(
            int studentId,
            string firstName,
            string lastName,
            DateTime birthday,
            char gender,
            int zip,
            string city,
            Class classObject,
            bool active
        ) {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.gender = gender;
            this.zip = zip;
            this.city = city;
            this.classObject = classObject;
            this.active = active;
        }

        public int StudentId
        {
            get
            {
                return this.studentId;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return this.birthday;
            }
            set
            {
                this.birthday = value;
            }
        }

        public char Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public int Zip
        {
            get
            {
                return this.zip;
            }
            set
            {
                this.zip = value;
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        public Class ClassObject
        {
            get
            {
                return this.classObject;
            }
            set
            {
                this.classObject = value;
            }
        }

        public bool Active
        {
            get
            {
                return this.active;
            }
            set
            {
                this.active = value;
            }
        }
    }
}

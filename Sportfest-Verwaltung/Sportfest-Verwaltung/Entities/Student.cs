using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsfestivalManagement.Entities
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
                return studentId;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
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

        public int Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public Class ClassObject
        {
            get
            {
                return classObject;
            }
            set
            {
                classObject = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
    }
}

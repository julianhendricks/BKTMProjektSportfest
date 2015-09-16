using SportsfestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace SportsfestivalManagement.Provider
{
    class StudentProvider : AbstractEntityProvider
    {
        public const string tableName = "student";
        public const string field_studentId = "studentId";
        public const string field_firstName = "firstName";
        public const string field_lastName = "lastName";
        public const string field_birthday = "birthday";
        public const string field_gender = "gender";
        public const string field_zip = "zip";
        public const string field_city = "city";
        public const string field_classId = "classId";
        public const string field_active = "active";

        public List<Student> getAllStudents()
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                students.Add(this.getStudentById(reader.GetInt32(field_studentId)));
            }

            return students;
        }

        public Student getStudentById(int studentId)
        {
            MySqlDataReader reader = this.executeSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_studentId + "` = " + studentId
            );

            ClassProvider classProvider = new ClassProvider();
            Class classObject = classProvider.getClassById(reader.GetInt32(field_classId));

            Student student = new Student(
                    reader.GetInt32(field_studentId),
                    reader.GetString(field_firstName),
                    reader.GetString(field_lastName),
                    reader.GetDateTime(field_birthday),
                    reader.GetChar(field_gender),
                    reader.GetInt32(field_zip),
                    reader.GetString(field_city),
                    classObject,
                    reader.GetBoolean(field_active)
            );

            return student;
        }

        public int createStudent(
            string firstName,
            string lastName,
            DateTime birthday,
            char gender,
            int zip,
            string city,
            Class classObject,
            bool active
        ) {
            MySqlDataReader reader = this.executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_firstName + "`, "
                    + "`" + field_lastName + "`, "
                    + "`" + field_birthday + "`, "
                    + "`" + field_gender + "`, "
                    + "`" + field_zip + "`, "
                    + "`" + field_city + "`, "
                    + "'" + field_classId + "', "
                    + "'" + field_active + "', "
                + ") VALUES ("
                    + "'" + firstName + "', "
                    + "'" + lastName + "', "
                    + "'" + birthday.ToString("yyyy-MM-dd") + "', "
                    + "'" + gender + "', "
                    + zip + ", "
                    + "'" + city + "', "
                    + classObject.ClassId + ", "
                    + active
                + ")"
            );

            reader = this.executeSql("SELECT LAST_INSERT_ID() AS insertionId");

            return reader.GetInt32("insertionId");
        }

        public void updateStudent(Student student)
        {
            MySqlDataReader reader = this.executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_firstName + "` = '" + student.FirstName + "', "
                    + "`" + field_lastName + "` = '" + student.LastName + "', "
                    + "`" + field_birthday + "` = '" + student.Birthday.ToString("yyyy-MM-dd") + "', "
                    + "`" + field_gender + "` = " + student.Gender + ", "
                    + "`" + field_zip + "` = " + student.Zip + ", "
                    + "`" + field_city + "` = '" + student.City + "', "
                    + "`" + field_classId + "` = " + student.ClassObject.ClassId + ", "
                    + "`" + field_active + "` = " + student.Active + " "
                + "WHERE "
                    + "`" + field_studentId + " = " + student.StudentId
            );
        }

        public void deleteStudent(Student student)
        {
            MySqlDataReader reader = this.executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_studentId + " = " + student.StudentId + " "
                + "LIMIT 1"
            );
        }
    }
}

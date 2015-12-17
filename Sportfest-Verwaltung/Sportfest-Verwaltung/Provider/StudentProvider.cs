using SportsFestivalManagement.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace SportsFestivalManagement.Provider
{
    class StudentProvider : AbstractEntityProvider
    {
        public const string tableName = "student";
        public const string field_studentId = "studentId";
        public const string field_firstName = "firstName";
        public const string field_lastName = "lastName";
        public const string field_birthday = "birthday";
        public const string field_gender = "gender";
        public const string field_street = "street";
        public const string field_zip = "zip";
        public const string field_city = "city";
        public const string field_classId = "classId";
        public const string field_active = "active";

        public static List<Student> getAllStudents()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "`"
            );

            List<Student> students = new List<Student>();

            foreach (var row in results)
            {
                students.Add(getStudentById(Convert.ToInt32(row[field_studentId])));
            }

            return students;
        }

        public static List<Student> getAllStudentsOrderedByAscendingLastName()
        {
            List<Dictionary<string, object>> results = querySql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "ORDER BY "
                    + "`" + field_lastName + "` ASC"
            );

            List<Student> students = new List<Student>();

            foreach (var row in results)
            {
                students.Add(getStudentById(Convert.ToInt32(row[field_studentId])));
            }

            return students;
        }
        
        public static Student getStudentById(int studentId)
        {
            Dictionary<string, object> result = querySingleSql(""
                + "SELECT "
                    + "* "
                + "FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_studentId + "` = " + studentId
            );

            if (result == null)
            {
                return null;
            }

            Class classObject = ClassProvider.getClassById(Convert.ToInt32(result[field_classId]));

            Student student = new Student(
                    Convert.ToInt32(result[field_studentId]),
                    Convert.ToString(result[field_firstName]),
                    Convert.ToString(result[field_lastName]),
                    Convert.ToDateTime(result[field_birthday]),
                    Convert.ToChar(result[field_gender]),
                    Convert.ToString(result[field_street]),
                    Convert.ToInt32(result[field_zip]),
                    Convert.ToString(result[field_city]),
                    classObject,
                    Convert.ToBoolean(result[field_active])
            );

            return student;
        }

        public static int createStudent(
            string firstName,
            string lastName,
            DateTime birthday,
            char gender,
            string street,
            int zip,
            string city,
            Class classObject,
            bool active
        ) {
            executeSql(""
                + "INSERT INTO "
                    + "`" + tableName + "` "
                + "("
                    + "`" + field_firstName + "`, "
                    + "`" + field_lastName + "`, "
                    + "`" + field_birthday + "`, "
                    + "`" + field_gender + "`, "
                    + "`" + field_street + "`, "
                    + "`" + field_zip + "`, "
                    + "`" + field_city + "`, "
                    + "`" + field_classId + "`, "
                    + "`" + field_active + "`"
                + ") VALUES ("
                    + "'" + firstName + "', "
                    + "'" + lastName + "', "
                    + "'" + birthday.ToString("yyyy-MM-dd") + "', "
                    + "'" + gender + "', "
                    + "'" + street + "', "
                    + zip + ", "
                    + "'" + city + "', "
                    + classObject.ClassId + ", "
                    + active
                + ")"
            );

            Dictionary<string, object> result = querySingleSql("SELECT MAX(`" + field_studentId + "`) AS `insertionId` FROM `" + tableName + "`");

            int insertionId = Convert.ToInt32(result["insertionId"]);

            return insertionId;
        }

        public static void updateStudent(Student student)
        {
            executeSql(""
                + "UPDATE "
                    + "`" + tableName + "` "
                + "SET "
                    + "`" + field_firstName + "` = '" + student.FirstName + "', "
                    + "`" + field_lastName + "` = '" + student.LastName + "', "
                    + "`" + field_birthday + "` = '" + student.Birthday.ToString("yyyy-MM-dd") + "', "
                    + "`" + field_gender + "` = " + student.Gender + ", "
                    + "`" + field_street + "` = " + student.Street + ", "
                    + "`" + field_zip + "` = " + student.Zip + ", "
                    + "`" + field_city + "` = '" + student.City + "', "
                    + "`" + field_classId + "` = " + student.ClassObject.ClassId + ", "
                    + "`" + field_active + "` = " + student.Active + " "
                + "WHERE "
                    + "`" + field_studentId + " = " + student.StudentId
            );
        }

        public static void deleteStudent(Student student)
        {
            executeSql(""
                + "DELETE FROM "
                    + "`" + tableName + "` "
                + "WHERE "
                    + "`" + field_studentId + " = " + student.StudentId + " "
                + "LIMIT 1"
            );
        }
    }
}

using School.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories
{
    public class GradesRepository : Repository, IGradesRepository
    {
        public bool AddGrade(int studentID, int lessonID, int grade, int weight, string type)
        {
            string query = $@"INSERT INTO Grades ([Grade], [Weight], [Type], [LessonID], [StudentID]) 
                            Values ('{grade}', '{weight}', '{type}', '{lessonID}', '{studentID}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool AddGrade(int studentID, int lessonID, int grade, int weight, string type, string description)
        {
            string query = $@"INSERT INTO Grades ([Grade], [Weight], [Type], [Description], [LessonID], [StudentID]) 
                            Values ('{grade}', '{weight}', '{type}', '{description}', '{lessonID}', '{studentID}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool EditGrade(int gradeID, int grade, int weight, string type)
        {
            string query = $@"UPDATE Grades SET Grade='{grade}', Weight='{weight}', Type='{type}'
                            WHERE ID='{gradeID}'; ";


            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(query, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool EditGrade(int gradeID, int grade, int weight, string type, string description)
        {
            string query = $@"UPDATE Grades SET Grade='{grade}', Weight='{weight}', Type='{type}', Description='{description}'
                            WHERE ID='{gradeID}'; ";


            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(query, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public DataTable GetClassGrades(int classID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Grades.Grade, Grades.Weight, Grades.Type, Lessons.Name AS Lesson, Lessons.Date, Grades.Description, Grades.ID as GradeID, Lessons.ID as LessonID, Students.ID as StudentID FROM Grades
                            INNER JOIN Students ON Grades.StudentID = Students.ID
                            INNER JOIN Lessons ON Lessons.ID = Grades.LessonID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            WHERE Students.ClassID = {classID}; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetClassTeacherGrades(int classID, int teacherID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Grades.Grade, Grades.Weight, Grades.Type, Lessons.Name AS Lesson, Lessons.Date, Grades.Description, Grades.ID as GradeID, Lessons.ID as LessonID, Students.ID as StudentID FROM Grades
                            INNER JOIN Students ON Grades.StudentID = Students.ID
                            INNER JOIN Lessons ON Lessons.ID = Grades.LessonID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            WHERE Students.ClassID = {classID}
                            AND Lessons.TeacherID = {teacherID}; ";


            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetGrades()
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Grades.Grade, Grades.Weight, Grades.Type, Lessons.Name AS Lesson, Lessons.Date, Grades.Description, Grades.ID as GradeID, Lessons.ID as LessonID, Students.ID as StudentID FROM Grades
                            INNER JOIN Students ON Grades.StudentID = Students.ID
                            INNER JOIN Lessons ON Lessons.ID = Grades.LessonID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetStudentGrades(int studentID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Grades.Grade, Grades.Weight, Grades.Type, Lessons.Name AS Lesson, Lessons.Date, Grades.Description, Grades.ID as GradeID, Lessons.ID as LessonID, Students.ID as StudentID FROM Grades
                            INNER JOIN Students ON Grades.StudentID = Students.ID
                            INNER JOIN Lessons ON Lessons.ID = Grades.LessonID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            WHERE Students.ID = {studentID}; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetStudentTeacherGrades(int studentID, int teacherID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Grades.Grade, Grades.Weight, Grades.Type, Lessons.Name AS Lesson, Lessons.Date, Grades.Description, Grades.ID as GradeID, Lessons.ID as LessonID, Students.ID as StudentID FROM Grades
                            INNER JOIN Students ON Grades.StudentID = Students.ID
                            INNER JOIN Lessons ON Lessons.ID = Grades.LessonID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            WHERE Students.ID = {studentID}
                            AND Lessons.TeacherID = {teacherID}; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetTeacherGrades(int teacherID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Grades.Grade, Grades.Weight, Grades.Type, Lessons.Name AS Lesson, Lessons.Date, Grades.Description, Grades.ID as GradeID, Lessons.ID as LessonID, Students.ID as StudentID FROM Grades
                            INNER JOIN Students ON Grades.StudentID = Students.ID
                            INNER JOIN Lessons ON Lessons.ID = Grades.LessonID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            WHERE Lessons.TeacherID = {teacherID}; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public bool RemoveGrade(int gradeID)
        {
            string query = $@"DELETE FROM Grades WHERE ID ='{gradeID}'; ";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(query, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}

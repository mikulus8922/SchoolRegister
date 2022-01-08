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
    public class LessonsRepository : Repository, ILessonsRepository
    {
        public bool AddLesson(DateTime date, string name, int classID, int teacherID)
        {
            string query = $@"INSERT INTO Lessons ([Date], [Name], [ClassID], [TeacherID]) 
                            Values ('{date}', '{name}', '{classID}', '{teacherID}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool AddLesson(DateTime date, string name, string description, int classID, int teacherID)
        {
            string query = $@"INSERT INTO Lessons ([Date], [Name], [Description], [ClassID], [TeacherID]) 
                            Values ('{date}', '{name}', '{description}', '{classID}', '{teacherID}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool EditLesson(int lessonID, DateTime date, string name, string description, int classID, int teacherID)
        {
            string query = $@"UPDATE Lessons SET Date='{date}', Name='{name}', Description='{description}' , ClassID='{classID}', TeacherID='{teacherID}'
                            WHERE ID='{lessonID}'; ";


            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(query, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public DataTable GetClassLessons(int classID)
        {
            string query = $@"SELECT Lessons.Name, Lessons.Date, Lessons.Description, Classes.Name, SystemUsers.FirstName, SystemUsers.LastName, Lessons.ClassID as ClassID, Lessons.TeacherID as TeacherID, Lessons.ID as LessonID  FROM Lessons
                            INNER JOIN Teachers ON Teachers.ID = Lessons.TeacherID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Teachers.SystemUserID
                            INNER JOIN Classes ON Lessons.ClassID = Classes.ID
                            WHERE Lessons.ClassID = '{classID}'; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetLessons()
        {
            string query = $@"SELECT Lessons.Name, Lessons.Date, Lessons.Description, Classes.Name, SystemUsers.FirstName, SystemUsers.LastName, Lessons.ClassID as ClassID, Lessons.TeacherID as TeacherID, Lessons.ID as LessonID  FROM Lessons
                            INNER JOIN Teachers ON Teachers.ID = Lessons.TeacherID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Teachers.SystemUserID
                            INNER JOIN Classes ON Lessons.ClassID = Classes.ID; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetTeacherLessons(int teacherID)
        {
            string query = $@"SELECT Lessons.Name, Lessons.Date, Lessons.Description, Classes.Name, SystemUsers.FirstName, SystemUsers.LastName, Lessons.ClassID as ClassID, Lessons.TeacherID as TeacherID, Lessons.ID as LessonID FROM Lessons
                            INNER JOIN Teachers ON Teachers.ID = Lessons.TeacherID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Teachers.SystemUserID
                            INNER JOIN Classes ON Lessons.ClassID = Classes.ID
                            WHERE Lessons.TeacherID = '{teacherID}'; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public bool RemoveLesson(int lessonID)
        {
            string query = $@"DELETE FROM Lessons WHERE ID ='{lessonID}'; ";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(query, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}

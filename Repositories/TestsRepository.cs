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
    public class TestsRepository : Repository, ITestsRepository
    {
        public bool AddTest(int lessonID, string description)
        {
            string query = $@"INSERT INTO Tests ([Description], [LessonID]) 
                            Values ('{description}', '{lessonID}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool EditTest(int testID, string description)
        {
            string query = $@"UPDATE Tests SET Description='{description}'
                            WHERE ID='{testID}'; ";


            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(query, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public DataTable GetClassTests(int classID)
        {
            string query = $@"SELECT Classes.Name AS Class, Lessons.Name AS Lesson, Lessons.Date, Tests.Description, Lessons.ClassID as ClassID, Lessons.ID as LessonID, Tests.ID as TestID FROM Tests
							INNER JOIN Lessons ON Lessons.ID = Tests.LessonID
                            INNER JOIN Classes ON Classes.ID = Lessons.ClassID
                            WHERE Lessons.ClassID = '{classID}';";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetLessonTests(int lessonID)
        {
            string query = $@"SELECT Classes.Name AS Class, Lessons.Name AS Lesson, Lessons.Date, Tests.Description, Lessons.ClassID as ClassID, Lessons.ID as LessonID, Tests.ID as TestID FROM Tests
							INNER JOIN Lessons ON Lessons.ID = Tests.LessonID
                            INNER JOIN Classes ON Classes.ID = Lessons.ClassID
                            WHERE Lessons.ID = '{lessonID}';";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetTeacherTests(int teacherID)
        {
            string query = $@"SELECT Classes.Name AS Class, Lessons.Name AS Lesson, Lessons.Date, Tests.Description, Lessons.ClassID as ClassID, Lessons.ID as LessonID, Tests.ID as TestID FROM Tests
							INNER JOIN Lessons ON Lessons.ID = Tests.LessonID
                            INNER JOIN Classes ON Classes.ID = Lessons.ClassID
                            WHERE Lessons.TeacherID = '{teacherID}';";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public bool RemoveTest(int testID)
        {
            string query = $@"DELETE FROM Tests WHERE ID ='{testID}'; ";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(query, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}

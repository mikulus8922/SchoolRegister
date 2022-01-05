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
    public class StudentsRepository : Repository, IStudentsRepository
    {
        public bool AddStudent(int systemUserID, int classID)
        {
            string query = $@"INSERT INTO Students ([ClassID], [SystemUserID]) 
                            Values ('{classID}', '{systemUserID}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool EditStudent(int studentID, int classID)
        {
            string query = $@"UPDATE Students SET ClassID='{classID}'
                            WHERE ID='{studentID}'; ";


            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(query, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public DataTable GetStudent(int studentID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, SystemUsers.Gender, Classes.Name, Students.ClassID AS ClassID, Students.ID AS StudentID FROM Students
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            INNER JOIN Classes ON Classes.ID = Students.ClassID
							WHERE Students.ID = '{studentID}'; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetStudentID(int userID)
        {
            string query = $@"SELECT ID From Students
                            WHERE SystemUserID = '{userID}'; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetStudents()
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, SystemUsers.Gender, Classes.Name, Students.ClassID AS ClassID, Students.ID AS StudentID FROM Students
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            INNER JOIN Classes ON Classes.ID = Students.ClassID; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetStudents(int classID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, SystemUsers.Gender, Classes.Name, Students.ClassID AS ClassID, Students.ID AS StudentID FROM Students
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            INNER JOIN Classes ON Classes.ID = Students.ClassID
							WHERE Students.ClassID = '{classID}'; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public bool RemoveStudent(int studentID)
        {
            string query = $@"DELETE FROM Students WHERE ID ='{studentID}'; ";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(query, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}

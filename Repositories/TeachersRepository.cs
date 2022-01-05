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
    public class TeachersRepository : Repository, ITeachersRepository
    {
        public bool AddTeacher(int userID, string occupation)
        {
            string query = $@"INSERT INTO Teachers ([SystemUserID], [Occupation]) 
                            Values ('{userID}', '{occupation}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool EditTeacher(int teacherID, string occupation)
        {
            string query = $@"UPDATE Teachers SET Occupation='{occupation}'
                            WHERE ID='{teacherID}'; ";


            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(query, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public DataTable GetTeacherID(int userID)
        {
            string query = $@"SELECT ID From Teachers
                            WHERE SystemUserID = '{userID}'; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetTeachers()
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, SystemUsers.Gender, Teachers.Occupation FROM Teachers
                            INNER JOIN SystemUsers ON SystemUsers.ID = Teachers.SystemUserID; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }


        public bool RemoveTeacher(int teacherID)
        {
            string query = $@"DELETE FROM Teachers WHERE ID ='{teacherID}'; ";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(query, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}

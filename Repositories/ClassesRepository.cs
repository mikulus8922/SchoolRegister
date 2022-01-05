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
    public class ClassesRepository : Repository, IClassesRepository
    {
        public bool AddClass(string name, string description, int yearOfCreation, int teacherID)
        {
            string query = $@"INSERT INTO Classes ([Name], [Description], [YearOfCreation], [TeacherID]) 
                            Values ('{name}', '{description}', '{yearOfCreation}', '{teacherID}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool EditClass(int classID, string name, string description, int yearOfCreation, int teacherID)
        {
            string query = $@"UPDATE Classes SET Name='{name}', Description='{description}', YearOfCreation='{yearOfCreation}', TeacherID='{teacherID}'
                            WHERE ID='{classID}'; ";


            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(query, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public DataTable GetClasses()
        {
            string query = $@"SELECT Classes.Name, Classes.Description, Classes.YearOfCreation, SystemUsers.FirstName, SystemUsers.LastName, Classes.TeacherID AS TeacherID, Classes.ID AS ClassID FROM Classes
                            INNER JOIN Teachers ON Teachers.ID = Classes.TeacherID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Teachers.SystemUserID; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public bool RemoveClass(int classID)
        {
            string query = $@"DELETE FROM Classes WHERE ID ='{classID}'; ";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(query, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}

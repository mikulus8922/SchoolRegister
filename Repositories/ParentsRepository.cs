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
    public class ParentsRepository : Repository, IParentsRepository
    {
        public bool AddParent(int userID, int studentID)
        {
            string query = $@"INSERT INTO Parents ([StudentID], [SystemUserID]) 
                            Values ('{studentID}', '{userID}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public DataTable GetParentID(int userID)
        {
            string query = $@"SELECT ID From Parents
                            WHERE SystemUserID = '{userID}'; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetParents()
        {
            string query = $@"SELECT p.FirstName AS ParentFirstName, p.LastName AS ParentLastName, s.FirstName AS StudentFirstName, s.LastName AS StudentLastName, Parents.ID as ParentID, Parents.StudentID as StudentID FROM Parents
                            INNER JOIN SystemUsers p ON Parents.SystemUserID = p.ID
                            INNER JOIN Students ON Parents.StudentID = Students.ID
                            INNER JOIN SystemUsers s ON Students.SystemUserID = s.ID; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public bool RemoveParent(int parentID)
        {
            string query = $@"DELETE FROM Parents WHERE ID ='{parentID}'; ";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(query, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}

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
    public class SystemUsersRepository : Repository, ISystemUsersRepository
    {
        public bool AddUser(string firstName, string lastName, string gender, string birthDate, string PESEL, string login, string passwordHash, bool isAdmin)
        {
            string query = $@"INSERT INTO SystemUsers ([FirstName], [LastName], [Gender], [BirthDate], [PESEL], [Login], [PasswordHash], [IsAdmin]) 
                            Values ('{firstName}', '{lastName}', '{gender}', '{birthDate}', '{PESEL}', '{login}', '{passwordHash}', '{isAdmin}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool EditUser(int userID, string firstName, string lastName, string gender, string birthDate, string PESEL, string login, string passwordHash, bool isAdmin)
        {
            string query = $@"UPDATE SystemUsers SET FirstName='{firstName}', LastName='{lastName}', Gender='{gender}', BirthDate='{birthDate}', PESEL='{PESEL}', Login='{login}', PasswordHash='{passwordHash}', IsAdmin='{isAdmin}'
                            WHERE ID='{userID}'; ";


            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(query, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public DataTable GetUser(int userID)
        {
            string query = $@"SELECT * FROM SystemUsers
                            WHERE ID = '{userID}'; ";


            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetUser(string login, string passwordHash)
        {
            string query = $@"SELECT * FROM SystemUsers
                            WHERE Login = '{login}'
                            AND PasswordHash = '{passwordHash}'; ";


            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetUsers()
        {
            string query = $@"SELECT * FROM SystemUsers; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }




        public bool RemoveUser(int userID)
        {
            string query = $@"DELETE FROM SystemUsers WHERE ID ='{userID}'; ";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(query, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories
{
    public abstract class Repository
    {
        protected readonly SqlConnection Connection;

        public Repository()
        {
            //Inicjalizacja połączenia z bazą danych
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }

}

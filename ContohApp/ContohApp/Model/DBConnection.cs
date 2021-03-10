using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohApp.Model
{
    class DBConnection
    {
        // 1. Declare object connect to database
        private static SqlConnection connection;

        // 2. Setting connection
        public static SqlConnection GetConnection()
        {
            // instance
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source = LAPTOP-PO5I66CE; " +
                                          "Initial Catalog = DBPersonal; " +
                                          "Integrated Security = True";

            return connection;
        }

        //
    }
}

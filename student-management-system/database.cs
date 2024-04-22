using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace student_management_system
{
    class database
    {
        private MySqlConnection con = new MySqlConnection("datasource=127.0.0.1; port=3306; username=kozakura; password=admin; database=student_management");

        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        // open connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Open();
            }
        }

        // close connection
        public void closeConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Close();
            }
        }
    }
}

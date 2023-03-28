using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pebud_magazyn
{
    class DB_connect
    {
        

        static String conn_string = "Persist Security Info=False;database=pebud;server=localhost;port=3306;user id=root;Password=;";
        
         MySqlConnection conn;
        public void open_connection()
        {
            conn = new MySqlConnection(conn_string); 
            try
            {
                conn.Open();  // connection opened
            }
            catch (MySqlException err)
            {
                MessageBox.Show("Nie udało się nawiązać połączenia z bazą danych. " + $"kod błędu -> {err.Code}");
            }
        }
        public MySqlConnection my_connection()
        {
            return conn;
        }
    }
}

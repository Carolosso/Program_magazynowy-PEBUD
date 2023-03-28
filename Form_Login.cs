using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pebud_magazyn
{
    public partial class Form_Login : Form
    {
        DB_connect connection = new DB_connect();
        
        public static string username;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            label1.Text = "Wersja: "+ Application.ProductVersion;
        }

        private void button_Form_Login_LogIN_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;

            string sql = "SELECT * FROM pebud_users WHERE (usern ='" + Form_Login_login.Text.Trim() + "' AND pasw ='" + sha256(Form_Login_passw.Text.Trim()) + "')";
            string login,passw = "";
            int is_admin = 0;
            connection.open_connection();
            try
            {
                if (Form_Login_login.Text.Trim() != "" && Form_Login_passw.Text.Trim() != "")
                {
                    
                    var cmd = new MySqlCommand(sql, connection.my_connection());
                     using MySqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows) //find matching row
                    {
                        //MessageBox.Show("znaleziono wiersz");
                        if (rdr.Read())
                        {
                            //MessageBox.Show("odczytuje");
                            login = rdr.GetString(1);
                            passw = rdr.GetString(2);
                            //saving username to show in program
                            username = login;
                            // checking if user have admin permission
                            is_admin = rdr.GetInt32(3);
                           // MessageBox.Show(is_admin.ToString());

                            rdr.Close();

                            if (is_admin == 1)
                            {
                                sql = "INSERT INTO logs (user, date, action) VALUES(@user, now(), 'zalogowano')";
                                cmd = new MySqlCommand(sql, connection.my_connection());
                                cmd.Parameters.AddWithValue("@user", login);
                                //cmd2.Parameters.AddWithValue("@date", theDate);
                                cmd.Prepare();
                                cmd.ExecuteNonQuery();
                                connection.my_connection().Close();
                                this.Hide();
                                GC.Collect();
                                GC.WaitForPendingFinalizers();
                                GC.Collect();
                                new Form_Program_Admin().Show();
                                //break;
                            }
                            else
                            {
                                sql = "INSERT INTO logs (user, date, action) VALUES(@user, now(), 'zalogowano')";
                                cmd = new MySqlCommand(sql, connection.my_connection());
                                cmd.Parameters.AddWithValue("@user", login);
                                //cmd2.Parameters.AddWithValue("@date", theDate);
                                cmd.Prepare();
                                cmd.ExecuteNonQuery();
                                connection.my_connection().Close();
                                this.Hide();
                                GC.Collect();
                                GC.WaitForPendingFinalizers();
                                GC.Collect();
                                new Form_Program_Worker().Show();
                                //break;
                            }
                        }

                    }
                    else MessageBox.Show("Błędny login lub hasło.", "Wystąpił błąd",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else MessageBox.Show("Pola są puste.", "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można połączyć się z bazą danych!", "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        private static string sha256(string str)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Form_Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void Form_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void Form_Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

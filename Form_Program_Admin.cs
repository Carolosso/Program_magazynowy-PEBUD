using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
// used icons8 https://icons8.com

namespace Pebud_magazyn
{
    public partial class Form_Program_Admin : Form
    {
        //---------------global variables
        //
        //current row's data
        public static int current_rows_id;
        public static string current_rows_name;
        public static string current_rows_unit;
        public static int current_rows_quantity;
        public static string current_rows_other;
        public static string current_rows_visible;
        //new row's data
        public static int new_rows_id;
        public static string new_rows_name;
        public static string new_rows_unit;
        public static int new_rows_quantity;
        public static string new_rows_other;
        public static string new_rows_visible;
        //
        //current tab's values
        public static int selected_tab_index;
        public static string selected_tab_DB_table_name;
        public static string selected_tabcontrol_name;      
        //-------------------
        public Form_Program_Admin()
        {
            InitializeComponent();
        }

        readonly DB_connect connection1 = new DB_connect();
        BindingSource bindingSource1 = new BindingSource();
        System.Data.DataTable table = new DataTable();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label_version.Text = "Wersja: " + Application.ProductVersion;
            label2.Text = "© " + DateTime.Now.Year.ToString() + " Program przedsiębiorstwa PEBUD Sp. z o.o. Wszelkie prawa zastrzeżone.";
            comboBox1.SelectedIndex = 0;
            //set default active tab index to 0
            selected_tab_index = 0;
            selected_tab_DB_table_name = selected_tab_name();
            //setting up current logged in user's name
            label_loggedin_user.Text = Form_Login.username;
            try 
            {
                connection1.open_connection();
                //create table headers
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Nazwa", typeof(string));
                table.Columns.Add("Stan", typeof(int));
                table.Columns.Add("Jedn. miary", typeof(string));
                table.Columns.Add("Uwagi", typeof(string));
                table.Columns.Add("Widoczność", typeof(string));
                //load data to default dgv 1
                string sql = "SELECT * FROM " + selected_tab_DB_table_name;
                generate_data(dataGridView1,sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z bazą danych.");
            }
             
        }
        //------------ CUSTOM FUNCTIONS --------------------------------//
        private void generate_data(DataGridView dataGridView, string sql)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                connection1.open_connection();
                if (!check_connection_status()) throw new Exception();
                table.Clear();
                //----reset data source
                this.bindingSource1.DataSource = table;
                dataGridView.DataSource = bindingSource1;
                //----
                var cmd = new MySqlCommand(sql, connection1.my_connection());
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) table.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5));
                rdr.Close();

                styling_view(dataGridView);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z bazą danych.");
            }
        }
        private void styling_view(DataGridView dataGridView)
        {
            //------------styling
            dataGridView.Columns[0].DefaultCellStyle.BackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].DefaultCellStyle.Font = dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Lato", 12, FontStyle.Bold);
            dataGridView.Columns[0].DefaultCellStyle.ForeColor = dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;

            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                //red background for 0 quantity of product
                if (Convert.ToInt32(r.Cells[2].Value) == 0) r.Cells[2].Style.BackColor = Color.Red;
                //grey text for not visible setting
                if (r.Cells[5].Value.ToString() == "nie") r.Cells[5].Style.ForeColor = Color.Gray;
            }
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dataGridView.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dataGridView.Columns[i].Width;
                // Remove AutoSizing:
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                // Set Width to calculated AutoSize value:
                dataGridView.Columns[i].Width = colw;
            }
        }
        private string selected_tab_name()
        {
            //returning name of current selected tab as name of table in DB
            List<string> tab_names = new List<string>
            {
                "materialy_wodociagowe",
                "materialy_drogowe",
                "materialy_do_budowy_domow",
                "materialy_kanalizacyjne",
                "sprzet",
                "narzedzia"
            };

            return tab_names[selected_tab_index];
        }
        private bool check_connection_status()
        {
            if (connection1.my_connection().State.ToString() == "Open")
            {
                label_Current_Status.Text = "ONLINE";
                label_Current_Status.ForeColor = Color.Green;
                return true;
            }
            else
            {
                label_Current_Status.Text = "OFFLINE";
                //MessageBox.Show("Utracono połączenie z bazą danych! Twoje zmiany nie zostaną zapisane.");
                label_Current_Status.ForeColor = Color.Red;
                return false;
            }
        }
        public void add_edited_item_to_DB() {
            try
            {
                connection1.open_connection();
                if (!check_connection_status()) throw new Exception();

                var sql = "UPDATE "+ selected_tab_DB_table_name+" SET Nazwa=@name,Stan=@quantity, Jednostka=@unit,Uwagi=@other,Widocznosc =@visible WHERE ID =@id"; 
                using var cmd = new MySqlCommand(sql, connection1.my_connection());
                cmd.Parameters.AddWithValue("@id", current_rows_id);
                cmd.Parameters.AddWithValue("@name", current_rows_name);
                cmd.Parameters.AddWithValue("@quantity", current_rows_quantity);
                cmd.Parameters.AddWithValue("@unit", current_rows_unit);
                cmd.Parameters.AddWithValue("@other", current_rows_other);
                cmd.Parameters.AddWithValue("@visible", current_rows_visible);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                //connection1.my_connection().Close();
                string sql2 = "SELECT * FROM " + selected_tab_DB_table_name;
                generate_data(dataGridView1, sql2);
                //dataGridView1.CurrentRow.Cells[0].Value = current_rows_id;
            }
            catch (Exception)
            {
                MessageBox.Show("Utracono połączenie z bazą danych! Twoje zmiany nie zostaną zapisane.");
            }
        }
        public bool add_new_item_to_DB(string tab)
        {
            try
            {
                connection1.open_connection();
                if (!check_connection_status()) throw new Exception();

                var sql = "INSERT INTO "+tab +"(Nazwa,Stan,Jednostka,Uwagi,Widocznosc) VALUES(@name,@quantity,@unit,@other,@visible)";
                using var cmd = new MySqlCommand(sql, connection1.my_connection());               
                cmd.Parameters.AddWithValue("@name", new_rows_name);
                cmd.Parameters.AddWithValue("@quantity", new_rows_quantity);
                cmd.Parameters.AddWithValue("@unit", new_rows_unit);
                cmd.Parameters.AddWithValue("@other", new_rows_other);
                cmd.Parameters.AddWithValue("@visible", new_rows_visible);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return true;
                //connection1.my_connection().Close();
                //string sql2 = "SELECT * FROM " + selected_tab_DB_table_name;
                //generate_data(dgv[selected_tab_index],sql2);
            }
            catch (Exception)
            {  
                MessageBox.Show("Utracono połączenie z bazą danych! Twoje zmiany nie zostaną zapisane.");
                return false;
            }

        }

        private void delete_item_from_DB()
        {
            try
            {
                connection1.open_connection();
                if (!check_connection_status()) throw new Exception();
                var sql = "DELETE FROM "+selected_tab_DB_table_name+" WHERE ID='" + current_rows_id + "'";
                var cmd = new MySqlCommand(sql, connection1.my_connection());
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                string sql2 = "SELECT * FROM " + selected_tab_DB_table_name;
                generate_data(dataGridView1, sql2);
                //connection1.my_connection().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Utracono połączenie z bazą danych! Twoje zmiany nie zostaną zapisane.");
            }
        }
        
        private void filter_data(TextBox textbox)
        {
            DataView table_view = table.DefaultView;
            table_view.RowFilter = comboBox1.SelectedItem.ToString()+" LIKE '%"+ textbox.Text+ "%'";
        }
       
        //------------ EVENT FUNCTIONS--------------------------------//

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                new Form_Dialog_AddNew().ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd.");
            }
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                new Form_Dialog_Edit().ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd.");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Confirm_Delete;
            Confirm_Delete = MessageBox.Show("Czy na pewno chcesz usunąć "+current_rows_name+"?","Usuwanie elementu",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (Confirm_Delete == DialogResult.Yes) delete_item_from_DB();
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult Confirm_Exit;
            Confirm_Exit = MessageBox.Show("Czy na pewno chcesz wyjść z programu?", "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Confirm_Exit == DialogResult.Yes)
            {
                var sql = "INSERT INTO logs (user, date, action) VALUES(@user, now(), 'wylogowano')";
                var cmd = new MySqlCommand(sql, connection1.my_connection());
                cmd.Parameters.AddWithValue("@user", Form_Login.username);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                connection1.my_connection().Close();
                Environment.Exit(1);
            }         
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_tabcontrol_name = tabControl1.SelectedTab.Text;
            selected_tab_index = tabControl1.SelectedIndex;
            selected_tab_DB_table_name = selected_tab_name();
            string sql = "SELECT * FROM " + selected_tab_DB_table_name;
            generate_data(dataGridView1,sql);  
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
            
            bool contains_data = false;
            // have to check if header or other blank element is checked -> (causes errors)
            if (dataGridView1.CurrentRow is null) contains_data = false;
            else if (dataGridView1.CurrentRow.Cells[0].Value == DBNull.Value || dataGridView1.CurrentRow.Cells[0].Value == null)
            {
                contains_data = false;
            }
            else contains_data = true;

            if (contains_data)
            {
                current_rows_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                current_rows_name = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                current_rows_quantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                current_rows_unit = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
                current_rows_other = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
                current_rows_visible = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
            }
            else { }

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            //setting up default selected item
            if (comboBox1.SelectedItem == null)comboBox1.SelectedIndex = 0;
            filter_data(textBox_search);
        }
        // dragging form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Form1_Program_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void Form1_Program_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void Form1_Program_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Admin_LogOut_Click(object sender, EventArgs e)
        {
            var sql = "INSERT INTO logs (user, date, action) VALUES(@user, now(), 'wylogowano')";
            var cmd = new MySqlCommand(sql, connection1.my_connection());
            cmd.Parameters.AddWithValue("@user", Form_Login.username);
            //cmd2.Parameters.AddWithValue("@date", theDate);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            connection1.my_connection().Close();
            this.Hide();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            new Form_Login().Show();
        }

        private void button_Admin_refresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM " + selected_tab_DB_table_name;
            generate_data(dataGridView1, sql);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form_Info().Show();
        }
    }
}

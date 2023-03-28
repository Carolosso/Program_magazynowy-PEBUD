using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Pebud_magazyn
{
    public partial class Form_Program_Worker : Form
    {
        public Form_Program_Worker()
        {
            InitializeComponent();
        }
        //current tab's values
        private int selected_tab_index;
        private string selected_tab_DB_table_name;

        //-------------------
        DB_connect connection1 = new DB_connect();
        BindingSource bindingSource1 = new BindingSource();
        System.Data.DataTable table = new DataTable();

        private void Form_Program_Worker_Load(object sender, EventArgs e)
        {
            label_version.Text = "Wersja: " + Application.ProductVersion;
            comboBox1.SelectedIndex = 0;
            label2.Text = "© " + DateTime.Now.Year.ToString() + " Program przedsiębiorstwa PEBUD Sp. z o.o. Wszelkie prawa zastrzeżone.";
            //set default active tab index to 0
            selected_tab_index = 0;
            selected_tab_DB_table_name = selected_tab_name();
            //setting up current logged in user's name
            label_loggedin_user_worker.Text = Form_Login.username;
            try
            {
                connection1.open_connection();
                //create table headers
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Nazwa", typeof(string));
                table.Columns.Add("Stan", typeof(string));
                table.Columns.Add("Jedn. miary", typeof(string));
                table.Columns.Add("Uwagi", typeof(string));
                //load data to default dgv 1
                generate_data(dataGridView1);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z bazą danych.");
            }
        }
        public void generate_data(DataGridView dataGridView)
        {
            //table.AcceptChanges();
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sql = "SELECT * FROM " + selected_tab_DB_table_name+" WHERE Widocznosc = 'tak'";
                connection1.open_connection();
                if (!check_connection_status()) throw new Exception();
                table.Clear();
                //----reset data
                this.bindingSource1.DataSource = table;
                dataGridView.DataSource = bindingSource1;
                var cmd = new MySqlCommand(sql, connection1.my_connection());
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) table.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));
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
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Columns[0].DefaultCellStyle.BackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].DefaultCellStyle.Font = dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Lato", 12, FontStyle.Bold);
            dataGridView.Columns[0].DefaultCellStyle.ForeColor = dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            

            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                //red background for 0 quantity of product
                if (Convert.ToInt32(r.Cells[2].Value) == 0) r.Cells[2].Style.BackColor = Color.Red;
            }
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        private bool check_connection_status()
        {
            if (connection1.my_connection().State.ToString() == "Open")
            {
                label_Current_Status_worker.Text = "ONLINE";
                label_Current_Status_worker.ForeColor = System.Drawing.Color.Green;
                return true;
            }
            else
            {
                label_Current_Status_worker.Text = "OFFLINE";
                //MessageBox.Show("Utracono połączenie z bazą danych! Twoje zmiany nie zostaną zapisane.");
                label_Current_Status_worker.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }
        private void filter_data(TextBox textbox)
        {
            DataView table_view = table.DefaultView;
            table_view.RowFilter = comboBox1.SelectedItem.ToString() + " LIKE '%" + textbox.Text + "%'";
        }
        private void Form_Program_Worker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
            //close whole program/all dialogs
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tabControl1.SelectedIndex.ToString());
            selected_tab_index = tabControl2.SelectedIndex;

            selected_tab_DB_table_name = selected_tab_name();
            //MessageBox.Show(selected_tab_DB_table_name);
            generate_data(dataGridView1);
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

        private void textBox_search_worker_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.SelectedIndex = 0;
            }
            filter_data(textBox_search_worker);
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Form_Program_Worker_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void Form_Program_Worker_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void Form_Program_Worker_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                //cmd2.Parameters.AddWithValue("@date", theDate);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                connection1.my_connection().Close();
                Environment.Exit(1);
            }            
        }

        private void button_Worker_LogOut_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form_Info().Show();
        }
    }
}

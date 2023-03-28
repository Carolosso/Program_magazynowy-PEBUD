using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pebud_magazyn
{
    public partial class Form_Dialog_AddNew : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form_Program_Admin"];

        public Form_Dialog_AddNew()
        {
            InitializeComponent();
        }
        private void Form_Dialog_AddNew_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = Form_Program_Admin.selected_tab_index;
            //this.Text = "Dodawanie " + Form_Program_Admin.selected_tabcontrol_name;
            this.TopMost = true;
            this.Activate();
            numeric_Dialog_add_quantity.Value = 1;
            textBox_Dialog_add_name.Text = textBox_Dialog_add_Unit.Text = textBox_Dialog_add_Other.Text = "";
            checkBox_Dialog_add_Visible.Checked = false;
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

            return tab_names[comboBox1.SelectedIndex];
        }
        private void button_Form_Dialog_add_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.AppStarting;

                label_adding_status.Text = "...";
                label_adding_status.Text = "Dodawanie...";
                //Form_Program_Admin.new_rows_id;
                Form_Program_Admin.new_rows_name = textBox_Dialog_add_name.Text;
                Form_Program_Admin.new_rows_quantity = Convert.ToInt32(numeric_Dialog_add_quantity.Value);
                Form_Program_Admin.new_rows_unit = textBox_Dialog_add_Unit.Text;
                Form_Program_Admin.new_rows_other = textBox_Dialog_add_Other.Text;
                Form_Program_Admin.new_rows_visible = (checkBox_Dialog_add_Visible.Checked) ? "tak" : "nie";
                if (((Form_Program_Admin)f).add_new_item_to_DB(selected_tab_name()))
                {
                    label_adding_status.Text = "Dodano pomyślnie!";
                    timer1.Enabled = true;
                    timer1.Tick += (sender, e) => {
                        label_adding_status.Text = "...";
                        timer1.Dispose();
                    };
                }
                else label_adding_status.Text = "Wystąpił błąd.";

                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {

                label_adding_status.Text = "Podczas dodawania wystąpił błąd.";
                MessageBox.Show("Wystąpił błąd");
                //NAPRAWIĆ DODANO POMYSLNIE JEST CALY CZAS NAWET z błedem
            }

        }

        private void Form_Dialog_AddNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.TopMost = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeric_Dialog_add_quantity.Value = 1;
            textBox_Dialog_add_name.Text = textBox_Dialog_add_Unit.Text = textBox_Dialog_add_Other.Text = "";
            checkBox_Dialog_add_Visible.Checked = false;
        }
    }
}

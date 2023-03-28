using System;
using System.Windows.Forms;

namespace Pebud_magazyn
{
    public partial class Form_Dialog_Edit : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form_Program_Admin"];
        public Form_Dialog_Edit()
        {
            InitializeComponent();
        }

        private void Form_Dialog_Load(object sender, EventArgs e)
        {
            textBox_Dialog_ID.Text = Form_Program_Admin.current_rows_id.ToString();
            textBox_Dialog_name.Text = Form_Program_Admin.current_rows_name;
            numeric_Dialog_edit_quantity.Value = Form_Program_Admin.current_rows_quantity;
            textBox_Dialog_Unit.Text = Form_Program_Admin.current_rows_unit;
            textBox_Dialog_Other.Text = Form_Program_Admin.current_rows_other;
            checkBox_Dialog_Visible.Checked = (Form_Program_Admin.current_rows_visible=="tak") ? true : false;
        }

        private void button_Form_Dialog_Save_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;

            Form_Program_Admin.current_rows_id = Convert.ToInt32(textBox_Dialog_ID.Text);
            Form_Program_Admin.current_rows_name = textBox_Dialog_name.Text;
            Form_Program_Admin.current_rows_quantity = Convert.ToInt32(numeric_Dialog_edit_quantity.Value);
            Form_Program_Admin.current_rows_unit = textBox_Dialog_Unit.Text;
            Form_Program_Admin.current_rows_other = textBox_Dialog_Other.Text;
            Form_Program_Admin.current_rows_visible = (checkBox_Dialog_Visible.Checked) ? "tak": "nie";
            ((Form_Program_Admin)f).add_edited_item_to_DB();
            this.Hide();

            Cursor.Current = Cursors.Default;
        }
    }
}

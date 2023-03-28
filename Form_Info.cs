using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pebud_magazyn
{
    public partial class Form_Info : Form
    {
        public Form_Info()
        {
            InitializeComponent();
        }

        private void Form_Info_Load(object sender, EventArgs e)
        {
            label2.Text = Application.ProductVersion;
            label4.Text = "© " + DateTime.Now.Year.ToString() + "\nProgram przedsiębiorstwa\nPEBUD Sp. z o.o.\nWszelkie prawa zastrzeżone.";
        }
    }
}

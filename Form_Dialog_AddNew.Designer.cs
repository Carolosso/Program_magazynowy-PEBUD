
namespace Pebud_magazyn
{
    partial class Form_Dialog_AddNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dialog_AddNew));
            this.checkBox_Dialog_add_Visible = new System.Windows.Forms.CheckBox();
            this.button_Form_Dialog_add_Save = new System.Windows.Forms.Button();
            this.textBox_Dialog_add_Other = new System.Windows.Forms.TextBox();
            this.textBox_Dialog_add_name = new System.Windows.Forms.TextBox();
            this.label_Form2_Others = new System.Windows.Forms.Label();
            this.label_Form2_Unit = new System.Windows.Forms.Label();
            this.label_Form2_Quantity = new System.Windows.Forms.Label();
            this.label_Form2_Name = new System.Windows.Forms.Label();
            this.numeric_Dialog_add_quantity = new System.Windows.Forms.NumericUpDown();
            this.textBox_Dialog_add_Unit = new System.Windows.Forms.TextBox();
            this.label_adding_status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Dialog_add_quantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_Dialog_add_Visible
            // 
            this.checkBox_Dialog_add_Visible.AutoSize = true;
            this.checkBox_Dialog_add_Visible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Dialog_add_Visible.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Dialog_add_Visible.Location = new System.Drawing.Point(22, 175);
            this.checkBox_Dialog_add_Visible.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Dialog_add_Visible.Name = "checkBox_Dialog_add_Visible";
            this.checkBox_Dialog_add_Visible.Size = new System.Drawing.Size(109, 24);
            this.checkBox_Dialog_add_Visible.TabIndex = 23;
            this.checkBox_Dialog_add_Visible.Text = "Widoczne:";
            this.checkBox_Dialog_add_Visible.UseVisualStyleBackColor = true;
            // 
            // button_Form_Dialog_add_Save
            // 
            this.button_Form_Dialog_add_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Form_Dialog_add_Save.Location = new System.Drawing.Point(12, 404);
            this.button_Form_Dialog_add_Save.Margin = new System.Windows.Forms.Padding(4);
            this.button_Form_Dialog_add_Save.Name = "button_Form_Dialog_add_Save";
            this.button_Form_Dialog_add_Save.Size = new System.Drawing.Size(118, 40);
            this.button_Form_Dialog_add_Save.TabIndex = 20;
            this.button_Form_Dialog_add_Save.Text = "Dodaj";
            this.button_Form_Dialog_add_Save.UseVisualStyleBackColor = true;
            this.button_Form_Dialog_add_Save.Click += new System.EventHandler(this.button_Form_Dialog_add_Save_Click);
            // 
            // textBox_Dialog_add_Other
            // 
            this.textBox_Dialog_add_Other.Location = new System.Drawing.Point(115, 225);
            this.textBox_Dialog_add_Other.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Dialog_add_Other.Multiline = true;
            this.textBox_Dialog_add_Other.Name = "textBox_Dialog_add_Other";
            this.textBox_Dialog_add_Other.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Dialog_add_Other.Size = new System.Drawing.Size(169, 99);
            this.textBox_Dialog_add_Other.TabIndex = 19;
            // 
            // textBox_Dialog_add_name
            // 
            this.textBox_Dialog_add_name.Location = new System.Drawing.Point(117, 32);
            this.textBox_Dialog_add_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Dialog_add_name.Name = "textBox_Dialog_add_name";
            this.textBox_Dialog_add_name.Size = new System.Drawing.Size(155, 27);
            this.textBox_Dialog_add_name.TabIndex = 16;
            // 
            // label_Form2_Others
            // 
            this.label_Form2_Others.AutoSize = true;
            this.label_Form2_Others.Location = new System.Drawing.Point(42, 225);
            this.label_Form2_Others.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Form2_Others.Name = "label_Form2_Others";
            this.label_Form2_Others.Size = new System.Drawing.Size(58, 19);
            this.label_Form2_Others.TabIndex = 15;
            this.label_Form2_Others.Text = "Uwagi:";
            // 
            // label_Form2_Unit
            // 
            this.label_Form2_Unit.AutoSize = true;
            this.label_Form2_Unit.Location = new System.Drawing.Point(7, 130);
            this.label_Form2_Unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Form2_Unit.Name = "label_Form2_Unit";
            this.label_Form2_Unit.Size = new System.Drawing.Size(93, 19);
            this.label_Form2_Unit.TabIndex = 14;
            this.label_Form2_Unit.Text = "Jedn. miary:";
            // 
            // label_Form2_Quantity
            // 
            this.label_Form2_Quantity.AutoSize = true;
            this.label_Form2_Quantity.Location = new System.Drawing.Point(55, 85);
            this.label_Form2_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Form2_Quantity.Name = "label_Form2_Quantity";
            this.label_Form2_Quantity.Size = new System.Drawing.Size(45, 19);
            this.label_Form2_Quantity.TabIndex = 13;
            this.label_Form2_Quantity.Text = "Stan:";
            // 
            // label_Form2_Name
            // 
            this.label_Form2_Name.AutoSize = true;
            this.label_Form2_Name.Location = new System.Drawing.Point(39, 40);
            this.label_Form2_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Form2_Name.Name = "label_Form2_Name";
            this.label_Form2_Name.Size = new System.Drawing.Size(61, 19);
            this.label_Form2_Name.TabIndex = 12;
            this.label_Form2_Name.Text = "Nazwa:";
            // 
            // numeric_Dialog_add_quantity
            // 
            this.numeric_Dialog_add_quantity.Location = new System.Drawing.Point(117, 77);
            this.numeric_Dialog_add_quantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numeric_Dialog_add_quantity.Name = "numeric_Dialog_add_quantity";
            this.numeric_Dialog_add_quantity.Size = new System.Drawing.Size(155, 27);
            this.numeric_Dialog_add_quantity.TabIndex = 24;
            this.numeric_Dialog_add_quantity.ThousandsSeparator = true;
            this.numeric_Dialog_add_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_Dialog_add_Unit
            // 
            this.textBox_Dialog_add_Unit.Location = new System.Drawing.Point(117, 122);
            this.textBox_Dialog_add_Unit.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Dialog_add_Unit.Name = "textBox_Dialog_add_Unit";
            this.textBox_Dialog_add_Unit.Size = new System.Drawing.Size(155, 27);
            this.textBox_Dialog_add_Unit.TabIndex = 18;
            // 
            // label_adding_status
            // 
            this.label_adding_status.AutoSize = true;
            this.label_adding_status.Location = new System.Drawing.Point(156, 415);
            this.label_adding_status.Name = "label_adding_status";
            this.label_adding_status.Size = new System.Drawing.Size(21, 19);
            this.label_adding_status.TabIndex = 26;
            this.label_adding_status.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_Dialog_add_Other);
            this.groupBox1.Controls.Add(this.label_Form2_Name);
            this.groupBox1.Controls.Add(this.label_Form2_Quantity);
            this.groupBox1.Controls.Add(this.label_Form2_Unit);
            this.groupBox1.Controls.Add(this.numeric_Dialog_add_quantity);
            this.groupBox1.Controls.Add(this.label_Form2_Others);
            this.groupBox1.Controls.Add(this.checkBox_Dialog_add_Visible);
            this.groupBox1.Controls.Add(this.textBox_Dialog_add_name);
            this.groupBox1.Controls.Add(this.textBox_Dialog_add_Unit);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 329);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Właściwości";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Wyczyść";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 60);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategoria";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Materiały wodociągowe",
            "Materiały drogowe",
            "Materiały do budowy domów",
            "Materiały kanalizacyjne",
            "Sprzęt",
            "Narzędzia"});
            this.comboBox1.Location = new System.Drawing.Point(6, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 27);
            this.comboBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // Form_Dialog_AddNew
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(319, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_adding_status);
            this.Controls.Add(this.button_Form_Dialog_add_Save);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dialog_AddNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Dialog_AddNew_FormClosing);
            this.Load += new System.EventHandler(this.Form_Dialog_AddNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Dialog_add_quantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Dialog_add_Visible;
        private System.Windows.Forms.Button button_Form_Dialog_add_Save;
        private System.Windows.Forms.TextBox textBox_Dialog_add_Other;
        private System.Windows.Forms.TextBox textBox_Dialog_add_name;
        private System.Windows.Forms.Label label_Form2_Others;
        private System.Windows.Forms.Label label_Form2_Unit;
        private System.Windows.Forms.Label label_Form2_Quantity;
        private System.Windows.Forms.Label label_Form2_Name;
        private System.Windows.Forms.NumericUpDown numeric_Dialog_add_quantity;
        private System.Windows.Forms.TextBox textBox_Dialog_add_Unit;
        private System.Windows.Forms.Label label_adding_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}
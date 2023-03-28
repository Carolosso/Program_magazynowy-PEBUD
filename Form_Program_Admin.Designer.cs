
namespace Pebud_magazyn
{
    partial class Form_Program_Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Program_Admin));
            this.label_status = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_Current_Status = new System.Windows.Forms.Label();
            this.label_loggedin_as = new System.Windows.Forms.Label();
            this.label_loggedin_user = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Admin_LogOut = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Admin_refresh = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_status.Location = new System.Drawing.Point(794, 707);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(40, 13);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "Status:";
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Image = global::Pebud_magazyn.Properties.Resources.icons8_add_new_26;
            this.button_Add.Location = new System.Drawing.Point(32, 57);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 58);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Dodaj";
            this.button_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_Add, "Dodaj elementy");
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Edit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Edit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.Image = global::Pebud_magazyn.Properties.Resources.icons8_pencil_26;
            this.button_Edit.Location = new System.Drawing.Point(142, 58);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(100, 58);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "Edytuj";
            this.button_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_Edit, "Edytuj zaznaczony element");
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Image = global::Pebud_magazyn.Properties.Resources.icons8_trash_can_26;
            this.button_Delete.Location = new System.Drawing.Point(254, 58);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(100, 58);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "Usuń";
            this.button_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_Delete, "Usuń zaznaczony element");
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_Current_Status
            // 
            this.label_Current_Status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Current_Status.AutoSize = true;
            this.label_Current_Status.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Current_Status.Location = new System.Drawing.Point(835, 707);
            this.label_Current_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Current_Status.Name = "label_Current_Status";
            this.label_Current_Status.Size = new System.Drawing.Size(0, 13);
            this.label_Current_Status.TabIndex = 7;
            // 
            // label_loggedin_as
            // 
            this.label_loggedin_as.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_loggedin_as.AutoSize = true;
            this.label_loggedin_as.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_loggedin_as.Location = new System.Drawing.Point(920, 707);
            this.label_loggedin_as.Name = "label_loggedin_as";
            this.label_loggedin_as.Size = new System.Drawing.Size(95, 13);
            this.label_loggedin_as.TabIndex = 8;
            this.label_loggedin_as.Text = "Zalogowano jako: ";
            // 
            // label_loggedin_user
            // 
            this.label_loggedin_user.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_loggedin_user.AutoSize = true;
            this.label_loggedin_user.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_loggedin_user.Location = new System.Drawing.Point(1010, 707);
            this.label_loggedin_user.Name = "label_loggedin_user";
            this.label_loggedin_user.Size = new System.Drawing.Size(11, 13);
            this.label_loggedin_user.TabIndex = 9;
            this.label_loggedin_user.Text = "-";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(4, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1104, 30);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1096, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Materiały wodociągowe";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1096, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materiały drogowe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1096, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Materiały do budowy domów";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1096, 0);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Materiały kanalizacyjne";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1096, 0);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Sprzęt";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1096, 0);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "Narzędzia";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtruj po:";
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_search.Location = new System.Drawing.Point(915, 75);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.PlaceholderText = "fraza";
            this.textBox_search.Size = new System.Drawing.Size(158, 27);
            this.textBox_search.TabIndex = 14;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackgroundImage = global::Pebud_magazyn.Properties.Resources.icons8_database_26;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(771, 706);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 15);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.BackgroundImage = global::Pebud_magazyn.Properties.Resources.icons8_administrator_male_26;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(898, 706);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 15);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.BackgroundImage = global::Pebud_magazyn.Properties.Resources.icons8_search_26;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(692, 80);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 15);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 707);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackgroundImage = global::Pebud_magazyn.Properties.Resources.pebud_logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 26);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(4, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 4);
            this.panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "PROGRAM MAGAZYNOWY - zarządzanie";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Close
            // 
            this.button_Close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Close.Image = global::Pebud_magazyn.Properties.Resources.icons8_close_window_26;
            this.button_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Close.Location = new System.Drawing.Point(1004, 4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(99, 38);
            this.button_Close.TabIndex = 24;
            this.button_Close.Text = "   Zamknij";
            this.button_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_minimize.Image = global::Pebud_magazyn.Properties.Resources.icons8_minimize_window_26;
            this.button_minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_minimize.Location = new System.Drawing.Point(873, 4);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(124, 38);
            this.button_minimize.TabIndex = 25;
            this.button_minimize.Text = "Minimalizuj";
            this.button_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nazwa",
            "Widoczność"});
            this.comboBox1.Location = new System.Drawing.Point(788, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 26;
            // 
            // button_Admin_LogOut
            // 
            this.button_Admin_LogOut.Image = global::Pebud_magazyn.Properties.Resources.icons8_logout_26;
            this.button_Admin_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Admin_LogOut.Location = new System.Drawing.Point(762, 4);
            this.button_Admin_LogOut.Name = "button_Admin_LogOut";
            this.button_Admin_LogOut.Size = new System.Drawing.Size(105, 38);
            this.button_Admin_LogOut.TabIndex = 27;
            this.button_Admin_LogOut.Text = "Wyloguj";
            this.button_Admin_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Admin_LogOut.UseVisualStyleBackColor = true;
            this.button_Admin_LogOut.Click += new System.EventHandler(this.button_Admin_LogOut_Click);
            // 
            // button_Admin_refresh
            // 
            this.button_Admin_refresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Admin_refresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Admin_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Admin_refresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_Admin_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Admin_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Admin_refresh.Image = global::Pebud_magazyn.Properties.Resources.icons8_synchronize_26__1_;
            this.button_Admin_refresh.Location = new System.Drawing.Point(454, 58);
            this.button_Admin_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.button_Admin_refresh.Name = "button_Admin_refresh";
            this.button_Admin_refresh.Size = new System.Drawing.Size(110, 58);
            this.button_Admin_refresh.TabIndex = 28;
            this.button_Admin_refresh.Text = "Odśwież";
            this.button_Admin_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button_Admin_refresh, "Odśwież aktualną zakładkę");
            this.button_Admin_refresh.UseVisualStyleBackColor = false;
            this.button_Admin_refresh.Click += new System.EventHandler(this.button_Admin_refresh_Click);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_version.Location = new System.Drawing.Point(574, 707);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(43, 13);
            this.label_version.TabIndex = 29;
            this.label_version.Text = "Wersja:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(4, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 536);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Form_Program_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1114, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.button_Admin_refresh);
            this.Controls.Add(this.button_Admin_LogOut);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_loggedin_user);
            this.Controls.Add(this.label_loggedin_as);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_Current_Status);
            this.Controls.Add(this.label_status);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Program_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program magazynowy | Zarządzanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_Program_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_Program_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_Program_MouseUp);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label_Current_Status;
        private System.Windows.Forms.Label label_loggedin_as;
        private System.Windows.Forms.Label label_loggedin_user;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_Admin_LogOut;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_Admin_refresh;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}


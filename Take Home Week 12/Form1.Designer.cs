namespace Take_Home_Week_12
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_team = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.cmb_nat = new System.Windows.Forms.ComboBox();
            this.cmb_tea = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_mname = new System.Windows.Forms.Label();
            this.lbl_mnat = new System.Windows.Forms.Label();
            this.lbl_mbirth = new System.Windows.Forms.Label();
            this.lbl_mteam = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.cmb_managerteam = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cmb_teamdelete = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.editManagerToolStripMenuItem,
            this.deletePlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1611, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // editManagerToolStripMenuItem
            // 
            this.editManagerToolStripMenuItem.Name = "editManagerToolStripMenuItem";
            this.editManagerToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.editManagerToolStripMenuItem.Text = "Edit Manager";
            this.editManagerToolStripMenuItem.Click += new System.EventHandler(this.editManagerToolStripMenuItem_Click);
            // 
            // deletePlayerToolStripMenuItem
            // 
            this.deletePlayerToolStripMenuItem.Name = "deletePlayerToolStripMenuItem";
            this.deletePlayerToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.deletePlayerToolStripMenuItem.Text = "Delete Player";
            this.deletePlayerToolStripMenuItem.Click += new System.EventHandler(this.deletePlayerToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nationality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Birthdate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Team Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(122, 16);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 9;
            // 
            // txt_team
            // 
            this.txt_team.Location = new System.Drawing.Point(122, 48);
            this.txt_team.Name = "txt_team";
            this.txt_team.Size = new System.Drawing.Size(100, 22);
            this.txt_team.TabIndex = 10;
            this.txt_team.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_team_KeyPress);
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(122, 125);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(100, 22);
            this.txt_position.TabIndex = 11;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(122, 165);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(100, 22);
            this.txt_height.TabIndex = 12;
            this.txt_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_height_KeyPress);
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(122, 201);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(100, 22);
            this.txt_weight.TabIndex = 13;
            this.txt_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_weight_KeyPress);
            // 
            // cmb_nat
            // 
            this.cmb_nat.FormattingEnabled = true;
            this.cmb_nat.Location = new System.Drawing.Point(122, 86);
            this.cmb_nat.Name = "cmb_nat";
            this.cmb_nat.Size = new System.Drawing.Size(121, 24);
            this.cmb_nat.TabIndex = 14;
            // 
            // cmb_tea
            // 
            this.cmb_tea.FormattingEnabled = true;
            this.cmb_tea.Location = new System.Drawing.Point(122, 278);
            this.cmb_tea.Name = "cmb_tea";
            this.cmb_tea.Size = new System.Drawing.Size(121, 24);
            this.cmb_tea.TabIndex = 15;
            this.cmb_tea.SelectedIndexChanged += new System.EventHandler(this.cmb_tea_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 382);
            this.dataGridView1.TabIndex = 17;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(122, 324);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(105, 33);
            this.btn_submit.TabIndex = 18;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_position);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_tea);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_nat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_weight);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_height);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_team);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1599, 382);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.lbl_mname);
            this.panel2.Controls.Add(this.lbl_mnat);
            this.panel2.Controls.Add(this.lbl_mbirth);
            this.panel2.Controls.Add(this.lbl_mteam);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.cmb_managerteam);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1608, 382);
            this.panel2.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(288, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1291, 331);
            this.dataGridView2.TabIndex = 29;
            // 
            // lbl_mname
            // 
            this.lbl_mname.AutoSize = true;
            this.lbl_mname.Location = new System.Drawing.Point(125, 71);
            this.lbl_mname.Name = "lbl_mname";
            this.lbl_mname.Size = new System.Drawing.Size(51, 16);
            this.lbl_mname.TabIndex = 28;
            this.lbl_mname.Text = "label18";
            // 
            // lbl_mnat
            // 
            this.lbl_mnat.AutoSize = true;
            this.lbl_mnat.Location = new System.Drawing.Point(125, 154);
            this.lbl_mnat.Name = "lbl_mnat";
            this.lbl_mnat.Size = new System.Drawing.Size(51, 16);
            this.lbl_mnat.TabIndex = 27;
            this.lbl_mnat.Text = "label18";
            // 
            // lbl_mbirth
            // 
            this.lbl_mbirth.AutoSize = true;
            this.lbl_mbirth.Location = new System.Drawing.Point(125, 128);
            this.lbl_mbirth.Name = "lbl_mbirth";
            this.lbl_mbirth.Size = new System.Drawing.Size(51, 16);
            this.lbl_mbirth.TabIndex = 26;
            this.lbl_mbirth.Text = "label17";
            // 
            // lbl_mteam
            // 
            this.lbl_mteam.AutoSize = true;
            this.lbl_mteam.Location = new System.Drawing.Point(125, 98);
            this.lbl_mteam.Name = "lbl_mteam";
            this.lbl_mteam.Size = new System.Drawing.Size(51, 16);
            this.lbl_mteam.TabIndex = 25;
            this.lbl_mteam.Text = "label15";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Nationality :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Birthdate : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Team :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Manager Name :";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(73, 328);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 33);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cmb_managerteam
            // 
            this.cmb_managerteam.FormattingEnabled = true;
            this.cmb_managerteam.Location = new System.Drawing.Point(106, 26);
            this.cmb_managerteam.Name = "cmb_managerteam";
            this.cmb_managerteam.Size = new System.Drawing.Size(121, 24);
            this.cmb_managerteam.TabIndex = 15;
            this.cmb_managerteam.SelectedIndexChanged += new System.EventHandler(this.cmb_managerteam_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Team Name";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.cmb_teamdelete);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(16, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1566, 401);
            this.panel3.TabIndex = 21;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(65, 337);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(269, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1272, 357);
            this.dataGridView3.TabIndex = 2;
            // 
            // cmb_teamdelete
            // 
            this.cmb_teamdelete.FormattingEnabled = true;
            this.cmb_teamdelete.Location = new System.Drawing.Point(111, 25);
            this.cmb_teamdelete.Name = "cmb_teamdelete";
            this.cmb_teamdelete.Size = new System.Drawing.Size(121, 24);
            this.cmb_teamdelete.TabIndex = 1;
            this.cmb_teamdelete.SelectedIndexChanged += new System.EventHandler(this.cmb_teamdelete_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Team Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 654);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlayerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_team;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.ComboBox cmb_nat;
        private System.Windows.Forms.ComboBox cmb_tea;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cmb_managerteam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_mnat;
        private System.Windows.Forms.Label lbl_mbirth;
        private System.Windows.Forms.Label lbl_mteam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label lbl_mname;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox cmb_teamdelete;
        private System.Windows.Forms.Label label14;
    }
}


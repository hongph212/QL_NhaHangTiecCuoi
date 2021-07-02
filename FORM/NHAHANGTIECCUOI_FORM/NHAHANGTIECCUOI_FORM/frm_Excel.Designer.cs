namespace NHAHANGTIECCUOI_FORM
{
    partial class frm_Excel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NapExcel = new System.Windows.Forms.Button();
            this.txt_SheetExcel = new System.Windows.Forms.TextBox();
            this.txt_FileExcel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_Excel = new System.Windows.Forms.DataGridView();
            this.btn_ChooseFileExcel = new System.Windows.Forms.Button();
            this.btn_LoadFileExcel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_NapSQL = new System.Windows.Forms.Button();
            this.cbo_TableSQL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DatabaseSQL = new System.Windows.Forms.TextBox();
            this.txt_ServerSQL = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Connection = new System.Windows.Forms.Button();
            this.grid_SQL = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_NapAccess = new System.Windows.Forms.Button();
            this.grid_Access = new System.Windows.Forms.DataGridView();
            this.txt_SheetAccess = new System.Windows.Forms.TextBox();
            this.txt_FileAccess = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ChooseFileAccess = new System.Windows.Forms.Button();
            this.btn_LoadFileAcess = new System.Windows.Forms.Button();
            this.btn_NapKDL = new System.Windows.Forms.Button();
            this.btn_NapAll = new System.Windows.Forms.Button();
            this.btn_TruyVan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Excel)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SQL)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Access)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.btn_NapExcel);
            this.groupBox1.Controls.Add(this.txt_SheetExcel);
            this.groupBox1.Controls.Add(this.txt_FileExcel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grid_Excel);
            this.groupBox1.Controls.Add(this.btn_ChooseFileExcel);
            this.groupBox1.Controls.Add(this.btn_LoadFileExcel);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 638);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // btn_NapExcel
            // 
            this.btn_NapExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_NapExcel.Location = new System.Drawing.Point(371, 597);
            this.btn_NapExcel.Name = "btn_NapExcel";
            this.btn_NapExcel.Size = new System.Drawing.Size(75, 35);
            this.btn_NapExcel.TabIndex = 48;
            this.btn_NapExcel.Text = "Nạp";
            this.btn_NapExcel.UseVisualStyleBackColor = false;
            this.btn_NapExcel.Click += new System.EventHandler(this.btn_NapExcel_Click);
            // 
            // txt_SheetExcel
            // 
            this.txt_SheetExcel.Location = new System.Drawing.Point(118, 72);
            this.txt_SheetExcel.Margin = new System.Windows.Forms.Padding(5);
            this.txt_SheetExcel.Name = "txt_SheetExcel";
            this.txt_SheetExcel.Size = new System.Drawing.Size(179, 33);
            this.txt_SheetExcel.TabIndex = 47;
            // 
            // txt_FileExcel
            // 
            this.txt_FileExcel.Location = new System.Drawing.Point(118, 21);
            this.txt_FileExcel.Margin = new System.Windows.Forms.Padding(5);
            this.txt_FileExcel.Name = "txt_FileExcel";
            this.txt_FileExcel.Size = new System.Drawing.Size(179, 33);
            this.txt_FileExcel.TabIndex = 46;
            this.txt_FileExcel.TextChanged += new System.EventHandler(this.txt_FileExcel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Sheet: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "File Excel:";
            // 
            // grid_Excel
            // 
            this.grid_Excel.AllowUserToAddRows = false;
            this.grid_Excel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Excel.BackgroundColor = System.Drawing.Color.White;
            this.grid_Excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Excel.Location = new System.Drawing.Point(8, 132);
            this.grid_Excel.Margin = new System.Windows.Forms.Padding(5);
            this.grid_Excel.Name = "grid_Excel";
            this.grid_Excel.RowTemplate.Height = 24;
            this.grid_Excel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Excel.Size = new System.Drawing.Size(438, 457);
            this.grid_Excel.TabIndex = 43;
            // 
            // btn_ChooseFileExcel
            // 
            this.btn_ChooseFileExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_ChooseFileExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChooseFileExcel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseFileExcel.Location = new System.Drawing.Point(305, 21);
            this.btn_ChooseFileExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ChooseFileExcel.Name = "btn_ChooseFileExcel";
            this.btn_ChooseFileExcel.Size = new System.Drawing.Size(141, 33);
            this.btn_ChooseFileExcel.TabIndex = 42;
            this.btn_ChooseFileExcel.Text = "Choose File";
            this.btn_ChooseFileExcel.UseVisualStyleBackColor = false;
            this.btn_ChooseFileExcel.Click += new System.EventHandler(this.btn_ChooseFileExcel_Click);
            // 
            // btn_LoadFileExcel
            // 
            this.btn_LoadFileExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_LoadFileExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LoadFileExcel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadFileExcel.Location = new System.Drawing.Point(305, 72);
            this.btn_LoadFileExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_LoadFileExcel.Name = "btn_LoadFileExcel";
            this.btn_LoadFileExcel.Size = new System.Drawing.Size(141, 33);
            this.btn_LoadFileExcel.TabIndex = 41;
            this.btn_LoadFileExcel.Text = "Load Exel File";
            this.btn_LoadFileExcel.UseVisualStyleBackColor = false;
            this.btn_LoadFileExcel.Click += new System.EventHandler(this.btn_LoadFileExcel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.btn_NapSQL);
            this.groupBox2.Controls.Add(this.cbo_TableSQL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_DatabaseSQL);
            this.groupBox2.Controls.Add(this.txt_ServerSQL);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_Connection);
            this.groupBox2.Controls.Add(this.grid_SQL);
            this.groupBox2.Location = new System.Drawing.Point(470, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 638);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // btn_NapSQL
            // 
            this.btn_NapSQL.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_NapSQL.Location = new System.Drawing.Point(371, 595);
            this.btn_NapSQL.Name = "btn_NapSQL";
            this.btn_NapSQL.Size = new System.Drawing.Size(75, 35);
            this.btn_NapSQL.TabIndex = 49;
            this.btn_NapSQL.Text = "Nạp";
            this.btn_NapSQL.UseVisualStyleBackColor = false;
            this.btn_NapSQL.Click += new System.EventHandler(this.btn_NapSQL_Click);
            // 
            // cbo_TableSQL
            // 
            this.cbo_TableSQL.FormattingEnabled = true;
            this.cbo_TableSQL.Location = new System.Drawing.Point(112, 91);
            this.cbo_TableSQL.Name = "cbo_TableSQL";
            this.cbo_TableSQL.Size = new System.Drawing.Size(185, 33);
            this.cbo_TableSQL.TabIndex = 40;
            this.cbo_TableSQL.SelectedIndexChanged += new System.EventHandler(this.cbo_TableSQL_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Table: ";
            // 
            // txt_DatabaseSQL
            // 
            this.txt_DatabaseSQL.Location = new System.Drawing.Point(112, 56);
            this.txt_DatabaseSQL.Margin = new System.Windows.Forms.Padding(5);
            this.txt_DatabaseSQL.Name = "txt_DatabaseSQL";
            this.txt_DatabaseSQL.Size = new System.Drawing.Size(185, 33);
            this.txt_DatabaseSQL.TabIndex = 38;
            // 
            // txt_ServerSQL
            // 
            this.txt_ServerSQL.Location = new System.Drawing.Point(112, 21);
            this.txt_ServerSQL.Margin = new System.Windows.Forms.Padding(5);
            this.txt_ServerSQL.Name = "txt_ServerSQL";
            this.txt_ServerSQL.Size = new System.Drawing.Size(185, 33);
            this.txt_ServerSQL.TabIndex = 37;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 56);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(106, 25);
            this.label.TabIndex = 36;
            this.label.Text = "Database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Server:";
            // 
            // btn_Connection
            // 
            this.btn_Connection.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Connection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Connection.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connection.Location = new System.Drawing.Point(305, 21);
            this.btn_Connection.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Connection.Name = "btn_Connection";
            this.btn_Connection.Size = new System.Drawing.Size(141, 103);
            this.btn_Connection.TabIndex = 34;
            this.btn_Connection.Text = "Connect";
            this.btn_Connection.UseVisualStyleBackColor = false;
            this.btn_Connection.Click += new System.EventHandler(this.btn_Connection_Click);
            // 
            // grid_SQL
            // 
            this.grid_SQL.AllowUserToAddRows = false;
            this.grid_SQL.AllowUserToDeleteRows = false;
            this.grid_SQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_SQL.BackgroundColor = System.Drawing.Color.White;
            this.grid_SQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SQL.Location = new System.Drawing.Point(8, 132);
            this.grid_SQL.Margin = new System.Windows.Forms.Padding(5);
            this.grid_SQL.Name = "grid_SQL";
            this.grid_SQL.ReadOnly = true;
            this.grid_SQL.RowTemplate.Height = 24;
            this.grid_SQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SQL.Size = new System.Drawing.Size(438, 457);
            this.grid_SQL.TabIndex = 33;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox3.Controls.Add(this.btn_NapAccess);
            this.groupBox3.Controls.Add(this.grid_Access);
            this.groupBox3.Controls.Add(this.txt_SheetAccess);
            this.groupBox3.Controls.Add(this.txt_FileAccess);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_ChooseFileAccess);
            this.groupBox3.Controls.Add(this.btn_LoadFileAcess);
            this.groupBox3.Location = new System.Drawing.Point(931, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 638);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // btn_NapAccess
            // 
            this.btn_NapAccess.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_NapAccess.Location = new System.Drawing.Point(371, 597);
            this.btn_NapAccess.Name = "btn_NapAccess";
            this.btn_NapAccess.Size = new System.Drawing.Size(75, 35);
            this.btn_NapAccess.TabIndex = 49;
            this.btn_NapAccess.Text = "Nạp";
            this.btn_NapAccess.UseVisualStyleBackColor = false;
            this.btn_NapAccess.Click += new System.EventHandler(this.btn_NapAccess_Click);
            // 
            // grid_Access
            // 
            this.grid_Access.AllowUserToAddRows = false;
            this.grid_Access.AllowUserToDeleteRows = false;
            this.grid_Access.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Access.BackgroundColor = System.Drawing.Color.White;
            this.grid_Access.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Access.Location = new System.Drawing.Point(8, 132);
            this.grid_Access.Margin = new System.Windows.Forms.Padding(5);
            this.grid_Access.Name = "grid_Access";
            this.grid_Access.ReadOnly = true;
            this.grid_Access.RowTemplate.Height = 24;
            this.grid_Access.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Access.Size = new System.Drawing.Size(438, 457);
            this.grid_Access.TabIndex = 46;
            // 
            // txt_SheetAccess
            // 
            this.txt_SheetAccess.Location = new System.Drawing.Point(128, 72);
            this.txt_SheetAccess.Margin = new System.Windows.Forms.Padding(5);
            this.txt_SheetAccess.Name = "txt_SheetAccess";
            this.txt_SheetAccess.Size = new System.Drawing.Size(167, 33);
            this.txt_SheetAccess.TabIndex = 45;
            // 
            // txt_FileAccess
            // 
            this.txt_FileAccess.Location = new System.Drawing.Point(128, 21);
            this.txt_FileAccess.Margin = new System.Windows.Forms.Padding(5);
            this.txt_FileAccess.Name = "txt_FileAccess";
            this.txt_FileAccess.Size = new System.Drawing.Size(167, 33);
            this.txt_FileAccess.TabIndex = 44;
            this.txt_FileAccess.TextChanged += new System.EventHandler(this.txt_FileAccess_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Sheet: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "File Access: ";
            // 
            // btn_ChooseFileAccess
            // 
            this.btn_ChooseFileAccess.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_ChooseFileAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChooseFileAccess.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseFileAccess.Location = new System.Drawing.Point(305, 22);
            this.btn_ChooseFileAccess.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ChooseFileAccess.Name = "btn_ChooseFileAccess";
            this.btn_ChooseFileAccess.Size = new System.Drawing.Size(141, 33);
            this.btn_ChooseFileAccess.TabIndex = 41;
            this.btn_ChooseFileAccess.Text = "Choose File";
            this.btn_ChooseFileAccess.UseVisualStyleBackColor = false;
            this.btn_ChooseFileAccess.Click += new System.EventHandler(this.btn_ChooseFileAccess_Click);
            // 
            // btn_LoadFileAcess
            // 
            this.btn_LoadFileAcess.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_LoadFileAcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LoadFileAcess.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadFileAcess.Location = new System.Drawing.Point(305, 73);
            this.btn_LoadFileAcess.Margin = new System.Windows.Forms.Padding(5);
            this.btn_LoadFileAcess.Name = "btn_LoadFileAcess";
            this.btn_LoadFileAcess.Size = new System.Drawing.Size(141, 33);
            this.btn_LoadFileAcess.TabIndex = 40;
            this.btn_LoadFileAcess.Text = "Load Access File";
            this.btn_LoadFileAcess.UseVisualStyleBackColor = false;
            this.btn_LoadFileAcess.Click += new System.EventHandler(this.btn_LoadFileAcess_Click);
            // 
            // btn_NapKDL
            // 
            this.btn_NapKDL.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_NapKDL.Location = new System.Drawing.Point(10, 726);
            this.btn_NapKDL.Name = "btn_NapKDL";
            this.btn_NapKDL.Size = new System.Drawing.Size(669, 65);
            this.btn_NapKDL.TabIndex = 44;
            this.btn_NapKDL.Text = "THỐNG KÊ";
            this.btn_NapKDL.UseVisualStyleBackColor = false;
            this.btn_NapKDL.Click += new System.EventHandler(this.btn_NapKDL_Click);
            // 
            // btn_NapAll
            // 
            this.btn_NapAll.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_NapAll.Location = new System.Drawing.Point(10, 655);
            this.btn_NapAll.Name = "btn_NapAll";
            this.btn_NapAll.Size = new System.Drawing.Size(1375, 65);
            this.btn_NapAll.TabIndex = 45;
            this.btn_NapAll.Text = "NẠP TẤT CẢ";
            this.btn_NapAll.UseVisualStyleBackColor = false;
            this.btn_NapAll.Click += new System.EventHandler(this.btn_NapAll_Click);
            // 
            // btn_TruyVan
            // 
            this.btn_TruyVan.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_TruyVan.Location = new System.Drawing.Point(716, 726);
            this.btn_TruyVan.Name = "btn_TruyVan";
            this.btn_TruyVan.Size = new System.Drawing.Size(669, 65);
            this.btn_TruyVan.TabIndex = 46;
            this.btn_TruyVan.Text = "TRUY VẤN";
            this.btn_TruyVan.UseVisualStyleBackColor = false;
            this.btn_TruyVan.Click += new System.EventHandler(this.btn_TruyVan_Click);
            // 
            // frm_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 796);
            this.Controls.Add(this.btn_TruyVan);
            this.Controls.Add(this.btn_NapAll);
            this.Controls.Add(this.btn_NapKDL);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Excel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Excel";
            this.Load += new System.EventHandler(this.frm_Excel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Excel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SQL)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Access)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SheetExcel;
        private System.Windows.Forms.TextBox txt_FileExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_Excel;
        private System.Windows.Forms.Button btn_ChooseFileExcel;
        private System.Windows.Forms.Button btn_LoadFileExcel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_TableSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DatabaseSQL;
        private System.Windows.Forms.TextBox txt_ServerSQL;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Connection;
        private System.Windows.Forms.DataGridView grid_SQL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grid_Access;
        private System.Windows.Forms.TextBox txt_SheetAccess;
        private System.Windows.Forms.TextBox txt_FileAccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ChooseFileAccess;
        private System.Windows.Forms.Button btn_LoadFileAcess;
        private System.Windows.Forms.Button btn_NapKDL;
        private System.Windows.Forms.Button btn_NapExcel;
        private System.Windows.Forms.Button btn_NapSQL;
        private System.Windows.Forms.Button btn_NapAccess;
        private System.Windows.Forms.Button btn_NapAll;
        private System.Windows.Forms.Button btn_TruyVan;
    }
}
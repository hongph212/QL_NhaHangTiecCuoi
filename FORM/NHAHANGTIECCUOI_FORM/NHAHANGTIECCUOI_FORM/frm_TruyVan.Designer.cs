namespace NHAHANGTIECCUOI_FORM
{
    partial class frm_TruyVan
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
            this.cbo_MDX = new System.Windows.Forms.ComboBox();
            this.btn_TruyVan = new System.Windows.Forms.Button();
            this.grid_MDX = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MDX)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_MDX
            // 
            this.cbo_MDX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MDX.FormattingEnabled = true;
            this.cbo_MDX.Location = new System.Drawing.Point(12, 13);
            this.cbo_MDX.Name = "cbo_MDX";
            this.cbo_MDX.Size = new System.Drawing.Size(696, 33);
            this.cbo_MDX.TabIndex = 0;
            // 
            // btn_TruyVan
            // 
            this.btn_TruyVan.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_TruyVan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TruyVan.Location = new System.Drawing.Point(714, 13);
            this.btn_TruyVan.Name = "btn_TruyVan";
            this.btn_TruyVan.Size = new System.Drawing.Size(158, 33);
            this.btn_TruyVan.TabIndex = 1;
            this.btn_TruyVan.Text = "Truy Vấn";
            this.btn_TruyVan.UseVisualStyleBackColor = false;
            this.btn_TruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // grid_MDX
            // 
            this.grid_MDX.BackgroundColor = System.Drawing.Color.White;
            this.grid_MDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_MDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_MDX.Location = new System.Drawing.Point(0, 0);
            this.grid_MDX.Name = "grid_MDX";
            this.grid_MDX.RowTemplate.Height = 24;
            this.grid_MDX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_MDX.Size = new System.Drawing.Size(860, 524);
            this.grid_MDX.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grid_MDX);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 524);
            this.panel1.TabIndex = 3;
            // 
            // frm_TruyVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(884, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_TruyVan);
            this.Controls.Add(this.cbo_MDX);
            this.Name = "frm_TruyVan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TruyVan";
            this.Load += new System.EventHandler(this.frm_TruyVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_MDX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_MDX;
        private System.Windows.Forms.Button btn_TruyVan;
        private System.Windows.Forms.DataGridView grid_MDX;
        private System.Windows.Forms.Panel panel1;
    }
}
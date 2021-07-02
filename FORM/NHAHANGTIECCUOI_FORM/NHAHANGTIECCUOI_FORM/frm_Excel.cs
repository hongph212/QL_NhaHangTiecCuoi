using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using System.Data.SqlClient;
using System.Diagnostics;

namespace NHAHANGTIECCUOI_FORM
{
    public partial class frm_Excel : Form
    {
        Form frm;
        string table = "";
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter da_temp = new SqlDataAdapter();
        SqlConnection cnn = new SqlConnection("Data Source=BESNHI\\MSSQLSERVER1;Initial Catalog = KHODL_NHTC; Integrated Security=True");

        public frm_Excel()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            InitializeComponent();
        }

        private void frm_Excel_Load(object sender, EventArgs e)
        {
            if (txt_FileExcel.Text == "")
                btn_LoadFileExcel.Enabled = false;

            if (txt_FileAccess.Text == "")
                btn_LoadFileAcess.Enabled = false;
        }

        public void KetNoi()
        {
            conn = new SqlConnection("Data Source=" + txt_ServerSQL.Text + ";Initial Catalog=" + txt_DatabaseSQL.Text + "; Integrated Security=True");
        }

        //Groupbox Access
        private void btn_ChooseFileAccess_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Access Databases (*.mdb)|*.accdb";
            opn.FilterIndex = 3;

            if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_FileAccess.Text = opn.FileName;
            }
        }

        private void txt_FileAccess_TextChanged(object sender, EventArgs e)
        {
            if (txt_FileAccess.Text != "")
                btn_LoadFileAcess.Enabled = true;
            else
                btn_LoadFileAcess.Enabled = false;
        }

        private void btn_LoadFileAcess_Click(object sender, EventArgs e)
        {
            string path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txt_FileAccess.Text + "";
            OleDbConnection conn = new OleDbConnection(path);
            conn.Open();

            OleDbDataAdapter da_Access = new OleDbDataAdapter("select * from " + txt_SheetAccess.Text + "", conn);
            DataTable dt2 = new DataTable();
            da_Access.Fill(dt2);
            grid_Access.DataSource = dt2;

            table = "DIM_" + txt_SheetAccess.Text;
            try
            {
                ds.Tables.Remove("temp");
            }
            catch
            {
            }
            string sql = "select * from " + table;
            da_temp = new SqlDataAdapter(sql, cnn);
            da_temp.Fill(ds, "temp");

            conn.Close();
        }
        //Groupbox Excel
        private void btn_ChooseFileExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm";
            opn.FilterIndex = 3;

            if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_FileExcel.Text = opn.FileName;
            }
        }

        private void btn_LoadFileExcel_Click(object sender, EventArgs e)
        {
            string path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txt_FileExcel.Text + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1'";
            OleDbConnection conn = new OleDbConnection(path);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [" + txt_SheetExcel.Text + "$]", conn);
            table = "DIM_" + txt_SheetExcel.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            grid_Excel.DataSource = dt;
            try
            {
                ds.Tables.Remove("temp");
            }
            catch
            {
            }
            string sql = "select * from " + table;
            da_temp = new SqlDataAdapter(sql, cnn);
            da_temp.Fill(ds, "temp");
        }

        private void txt_FileExcel_TextChanged(object sender, EventArgs e)
        {
            if (txt_FileExcel.Text != "")
                btn_LoadFileExcel.Enabled = true;
            else
                btn_LoadFileExcel.Enabled = false;
        }


        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm";
            save.FilterIndex = 3;

            if (save.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("NHANVIEN");

                // From DataGridView to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(worksheet, this.grid_Excel, new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(save.FileName);
            }
        }

        //Groupbox SQL
        private void btn_Connection_Click(object sender, EventArgs e)
        {
            KetNoi();

            try
            {
                conn.Open();
                MessageBox.Show("Kết nối thành công !!");

                string alltable = "use " + txt_DatabaseSQL.Text + " select object_id,name from sys.tables";
                DataTable dt1 = new DataTable();
                SqlDataAdapter da_AllTable = new SqlDataAdapter(alltable, conn);
                da_AllTable.Fill(dt1);

                //Load table có trong database
                cbo_TableSQL.DisplayMember = "name";
                cbo_TableSQL.ValueMember = "name";
                cbo_TableSQL.DataSource = dt1;

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Kết nối không thành công, kiểm tra lại Server Name và Database Name");
            }
        }

        private void cbo_TableSQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            KetNoi();

            grid_SQL.DataSource = null;

            try
            {
                conn.Open();

                string cboText = cbo_TableSQL.SelectedValue.ToString();
                string sql = "use " + txt_DatabaseSQL.Text + " select * from " + cboText + "";
                table = cboText;
                SqlDataAdapter da_temp1 = new SqlDataAdapter(sql, conn);
                DataTable dt1 = new DataTable();

                dt1 = new DataTable();
                da_temp1.Fill(dt1);

                grid_SQL.DataSource = dt1;
                table = "DIM_" + cbo_TableSQL.SelectedValue.ToString();
                try
                {
                    ds.Tables.Remove("temp");
                }
                catch
                {
                }
                string sqlsv = "select * from " + table;
                da_temp = new SqlDataAdapter(sqlsv, cnn);
                da_temp.Fill(ds, "temp");
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Load gridview thất bại !");
            }

        }


        public bool KTTrung(string ma, DataSet ds)
        {
            try
            {
                if (ds != null)
                {
                    for (int i = 0; i < ds.Tables["temp"].Rows.Count; i++)
                    {
                        DataRow dr = ds.Tables["temp"].Rows[i];
                        if (dr != null)
                        {
                            if (dr[0].ToString().Equals(ma))
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void btn_NapKDL_Click(object sender, EventArgs e)
        {
            frm = new frm_ThongKe();
            frm.Show();
        }

        public bool ktra(string ma)
        {
            try
            {
                for (int i = 0; i < ds.Tables["temp"].Rows.Count; i++)
                {
                    DataRow dr = ds.Tables["temp"].Rows[i];
                    if (dr[0].ToString().Equals(ma))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void btn_NapExcel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_Excel.RowCount; i++)
            {
                DataRow drThem = ds.Tables["temp"].NewRow();
                DataGridViewRow row = grid_Excel.Rows[i];
                if (ktra(row.Cells[0].Value.ToString()) == false)
                {
                    for (int j = 0; j < grid_Excel.ColumnCount; j++)
                    {
                        drThem[j] = row.Cells[j].Value.ToString();
                    }
                    ds.Tables["temp"].Rows.Add(drThem);
                }

            }
            SqlCommandBuilder buil = new SqlCommandBuilder(da_temp);
            da_temp.Update(ds, "temp");
            MessageBox.Show("Nạp thành công");

        }

        private void btn_NapSQL_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_SQL.RowCount; i++)
            {
                DataRow drThem = ds.Tables["temp"].NewRow();
                DataGridViewRow row = grid_SQL.Rows[i];
                if (ktra(row.Cells[0].Value.ToString()) == false)
                {
                    for (int j = 0; j < grid_SQL.ColumnCount; j++)
                    {
                        drThem[j] = row.Cells[j].Value.ToString();
                    }
                    ds.Tables["temp"].Rows.Add(drThem);
                }

            }
            SqlCommandBuilder buil = new SqlCommandBuilder(da_temp);
            da_temp.Update(ds, "temp");
            MessageBox.Show("Nạp thành công");
        }

        private void btn_NapAccess_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_Access.RowCount; i++)
            {
                DataRow drThem = ds.Tables["temp"].NewRow();
                DataGridViewRow row = grid_Access.Rows[i];
                if (ktra(row.Cells[0].Value.ToString()) == false)
                {
                    for (int j = 0; j < grid_Access.ColumnCount; j++)
                    {
                        drThem[j] = row.Cells[j].Value.ToString();
                    }
                    ds.Tables["temp"].Rows.Add(drThem);
                }

            }
            SqlCommandBuilder buil = new SqlCommandBuilder(da_temp);
            da_temp.Update(ds, "temp");
            MessageBox.Show("Nạp thành công");
        }

        private void btn_NapAll_Click(object sender, EventArgs e)
        {
            //    Arguments = @"""C:\Program Files\Microsoft SQL Server\110\DTS\Binn\DTExec.exe""" + " /File " + @"""C:\Users\Admin\Documents\Zalo Received Files\Kho dữ liệu OLAP\NHOM13_NHAHANGTIECCUOI_NguyenHongPhuc_2001181265\SSIS\NHAHANGTIECCUOI_SSIS\Package.dtsx"""
            //};
            Process.Start("cmd.exe");
        }

        private void btn_TruyVan_Click(object sender, EventArgs e)
        {
            frm = new frm_TruyVan();
            frm.Show();
        }



    }
}

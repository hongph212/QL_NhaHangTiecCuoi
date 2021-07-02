using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AnalysisServices.AdomdClient;

namespace NHAHANGTIECCUOI_FORM
{
    public partial class frm_TruyVan : Form
    {
        AdomdConnection conn = new AdomdConnection("Provider=MSOLAP;Data Source=BESNHI\\MSSQLSERVER1;Initial Catalog=KHODL_NHTC;");
        
        public frm_TruyVan()
        {
            InitializeComponent();
        }
        class select
        {
            public string Text { get; set; }
            public string Value { get; set; }
        }
        private void frm_TruyVan_Load(object sender, EventArgs e)
        {
            List<select> sl = new List<select>();
            sl.Add(new select() { Text = "Thống kê doanh thu của các khu vực qua từng năm", Value = "select [Measures].[DOANHTHU] on columns,([DIM NGAYTOCHUC].[YEAR].[YEAR],[DIM KHUVUC].[TENKV].[TENKV]) on rows from KHODL_NHTC;" });
            sl.Add(new select() { Text = "Thống kê số lượng khách chọn số bàn tại các khu vực qua từng năm", Value = "select [Measures].[DOANHTHU] on columns, ([DIM NGAYTOCHUC].[YEAR].[2021],[DIM KHUVUC].[TENKV].[ĐÀ NẴNG]:[DIM KHUVUC].[TENKV].[TP. HCM], [DIM SANHTIEC].[SUCCHUA].[SUCCHUA]) on rows from KHODL_NHTC;" });
            sl.Add(new select() { Text = "Số lượng khách đặt tiệc trong tháng", Value = "SELECT [Measures].[FACT DOANHTHU Count] ON COLUMNS,[DIM NGAYTOCHUC].[MONTH].[MONTH] ON ROWS from KHODL_NHTC; "});
            sl.Add(new select() { Text = "Thống kê doanh thu nhân viên trong năm 2021 ở khu vực TP.HCM và ĐÀ NẴNG", Value = "select [Measures].[DOANHTHU] on columns, ([DIM KHUVUC].[TENKV].[ĐÀ NẴNG]:[DIM KHUVUC].[TENKV].[TP. HCM], [DIM NGAYTOCHUC].[MONTH].[MONTH]) on rows from KHODL_NHTC;" });
            sl.Add(new select() { Text = "Hiển thị tháng có doanh thu cao nhất trong năm", Value = "Select [Measures].[Maximum DOANHTHU] on columns, topcount([DIM NGAYTOCHUC].[MONTH].[MONTH],1,[Measures].[Maximum DOANHTHU]) on rows from khodl_nhtc;" });
            sl.Add(new select() { Text = "Hiển chị số lượng khách đặt tiệc trong năm qua", Value = "Select [Measures].[FACT DOANHTHU Count] on columns,	([DIM KHUVUC].[TENKV].[ĐÀ NẴNG]:[DIM KHUVUC].[TENKV].[TP. HCM], [DIM NGAYTOCHUC].[YEAR].[2021]) on rows  from khodl_nhtc;" });
            sl.Add(new select() { Text = "Thống kê doanh thu tháng trên 500000000", Value = "select filter([DIM NGAYTOCHUC].[MONTH].[MONTH], [Measures].[DOANHTHU]>500000000) on columns,[Measures].[DOANHTHU] on rows from KHODL_NHTC" });
            sl.Add(new select() { Text = "Số lượng món bán được", Value = "Select [Measures].[SL] on columns,	[DIM MONAN].[TENMON].[TENMON] on rows from khodl_nhtc;" });
            sl.Add(new select() { Text = "Số lượng đơn đặt tiệc của nhân viên", Value = "Select [Measures].[FACT DOANHTHU Count] on columns,[DIM NHANVIEN].[TENNV].[TENNV] on rows from khodl_nhtc;" });
            sl.Add(new select() { Text = "Số lượng món được đặt theo từng khu vực", Value = "Select ([DIM KHUVUC].[TENKV].[TENKV], [DIM MONAN].[TENMON].[TENMON]) on rows,[Measures].[SL] on columns from khodl_nhtc;" });
            cbo_MDX.DataSource = sl;
            cbo_MDX.DisplayMember = "Text";
            cbo_MDX.ValueMember = "Value";
        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string mdx = cbo_MDX.SelectedValue.ToString();
                AdomdDataAdapter a = new AdomdDataAdapter(mdx, conn);
                DataTable dtb = new DataTable();
                a.Fill(dtb);
                grid_MDX.DataSource = dtb;
                //MessageBox.Show("Thành công");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void TruyVan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = new frm_Excel();
            frm.Show();
        }
    }
}

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace librun
{
    public partial class AlertBorrowed : Form
    {
        
        public AlertBorrowed(DataTable dt)
        {
            InitializeComponent();
            dgv_ten_sach_muon.DataSource = dt;
            dgv_ten_sach_muon.Columns[1].HeaderText = "Tiêu đề";
            dgv_ten_sach_muon.Columns[2].HeaderText = "Ngày mượn";
            
        }

        private void dgv_ten_sach_muon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dgv_ten_sach_muon.Rows[e.RowIndex];
            DateTime ngaymuon = Convert.ToDateTime(row.Cells[2].Value);
            if (ngaymuon.AddDays(14) < DateTime.Now)
            {
                row.DefaultCellStyle.BackColor = Color.LightPink;
               
            }
        }
    }
}

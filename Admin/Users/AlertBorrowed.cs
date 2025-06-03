using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librun.Admin.Users
{
    public partial class AlertBorrowed : Form
    {
        //public DataTable dt;
        public AlertBorrowed(DataTable dt)
        {
            InitializeComponent();
            dgv_ten_sach_muon.DataSource = dt;
            dgv_ten_sach_muon.Columns[1].HeaderText = "Tiêu đề";
            dgv_ten_sach_muon.Columns[2].HeaderText = "Ngày mượn";
        }
    }
}

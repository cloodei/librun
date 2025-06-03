using System.Data;
using System.Windows.Forms;

namespace librun
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

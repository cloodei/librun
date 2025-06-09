using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librun.Admin.Replies
{
    public partial class CreateReply : Form
    {
        public string noiDung;
        public string hoiDap;
        public CreateReply(string nd)
        {
            InitializeComponent();
            noiDung = nd;
        }

        private void CreateReply_Load(object sender, EventArgs e)
        {
            lbl_noi_dung.Text = "Nội dung: "+ noiDung;
        }

        private void btn_gui_hoi_dap_Click(object sender, EventArgs e)
        {
            if(rtxtb_nhap_hoi_dap.Text =="")
            {
                MessageBox.Show("Bạn chưa nhập hồi đáp", "chú ý", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            else
            {
                hoiDap = rtxtb_nhap_hoi_dap.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

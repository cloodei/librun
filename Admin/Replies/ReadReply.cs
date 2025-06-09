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
    public partial class ReadReply : Form
    {
        string noiDung;
        string hoiDap;
        public ReadReply(string nd, string hd)
        {
            InitializeComponent();
            noiDung = nd;
            hoiDap = hd;
        }

        private void ReadReply_Load(object sender, EventArgs e)
        {
            lbl_noi_dung.Text = "Nội dung: "+ noiDung;
            lbl_hoi_dap.Text = "Hồi đáp từ thủ thư: " + hoiDap;
        }
    }
}

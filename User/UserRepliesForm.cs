﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class UserRepliesForm : Form, IFData
    {
        public UserRepliesForm()
        {
            InitializeComponent();
        }

        public void InitForm()
        {
            this.rEPLYTableAdapter.Fill(this.userRepliesDataSet.REPLY, global.user_id);
            global.SetActiveButton(userSidenav1.panel1.Controls, null);
        }

        private void UserBooks_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        public void ResetFields()
        {
            cbPl.ResetText();
            cbPl.ResetText();
        }

        string checkFilter()
        {
            bool alltt = (cbTt.Text == "") || (cbTt.Text == "Tất cả");
            bool allpl = (cbPl.Text == "") || (cbPl.Text == "Tất cả");

            if (alltt && allpl)
                return "";

            if (alltt)
                return $"muc_do = '{char.ToLower(cbPl.Text[0]) + cbPl.Text.Substring(1)}'";

            if (allpl)
                return $"trang_thai = '{char.ToLower(cbTt.Text[0]) + cbTt.Text.Substring(1)}'";

            return $"muc_do = '{char.ToLower(cbPl.Text[0]) + cbPl.Text.Substring(1)}' AND trang_thai = '{char.ToLower(cbTt.Text[0]) + cbTt.Text.Substring(1)}'";
        }

        void fillData()
        {
            rEPLYTableAdapter.Fill(userRepliesDataSet.REPLY, global.user_id);
            rEPLYBindingSource.Filter = checkFilter();
        }

        private void lbReply_Click(object sender, EventArgs e)
        {
            var f = new CreateReplyForm();
            var res = f.ShowDialog();

            if (res == DialogResult.OK)
            {
                rEPLYTableAdapter.Insert(global.user_id, f.userReply, f.userRepType);
                fillData();
            }
        }

        private void dgvReplies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var r = dgvReplies.Rows[e.RowIndex];
            var nd = r.Cells["nd"].Value.ToString();
            var hd = r.Cells["hd"].Value.ToString();

            if (r.Cells["tt"].Value.ToString() == "đã giải quyết")
            {
                var f = new ReadReplyForm(nd, hd);
                f.ShowDialog();
            }
            else
            {
                var f = new CreateReplyForm(nd, r.Cells["pl"].Value.ToString());
                var res = f.ShowDialog();

                if (res == DialogResult.OK)
                {
                    var id = Convert.ToInt64(r.Cells["id"].Value);
                    rEPLYTableAdapter.Update(global.user_id, f.userReply, f.userRepType, DateTime.Now.ToString(), id, id);
                    fillData();
                }
            }
        }

        private void dgvReplies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var r = dgvReplies.Rows[e.RowIndex];

            if (r.Cells["tt"].Value.ToString() == "đã giải quyết")
                r.DefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillData();
        }

        private void cbPl_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillData();
        }

        private void UserRepliesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

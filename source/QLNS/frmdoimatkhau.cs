using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmdoimatkhau : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmdoimatkhau()
        {
            InitializeComponent();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string update = "update tbuser set Pass='" + txtMKMoi.Text + "' where(Username=N'" + txtTenTruyCap.Text + "' and Pass='" + txtMKCu.Text + "')";
            string ten = txtTenTruyCap.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtMKCu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtMKMoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtGoLaiMK.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (txtMKMoi.Text == txtGoLaiMK.Text)
                            {
                                cls.thucthiketnoi(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

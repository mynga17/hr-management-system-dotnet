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
    public partial class frmtimkiem : Form
    {
        Clsdatabase cls = new Clsdatabase();
        int i = 0;

        public frmtimkiem()
        {
            InitializeComponent();
        }

        private void frmtimkiem_Load(object sender, EventArgs e)
        {
            rbtnMaNV.Checked = true;
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
        }
        private void rbtnMaNV_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void rbtnHoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }
        private void rbtnCMND_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtTimKiem.Text == "") || (txtTimKiem.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("Bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV=N'" + txtTimKiem.Text + "'");
                    }
                    if (i == 2)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where HoTen=N'" + txtTimKiem.Text + "'");
                    }
                    if (i == 3)
                    {
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where CMTND=N'" + txtTimKiem.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập vào từ khóa tìm kiếm")
            {
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if ((txtTimKiem.Text == "") || (txtTimKiem.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                }
                else
                {

                    if (i == 1)
                    {
                        cls.loadtxtTimKiem(txtTimKiem, "select * from TblTTNVCoBan where MaNV like N'" + txtTimKiem.Text + "%'", 3);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV like N'" + txtTimKiem.Text + "%'");
                    }
                    if (i == 2)
                    {
                        cls.loadtxtTimKiem(txtTimKiem, "select * from TblTTNVCoBan where MaNV like N'" + txtTimKiem.Text + "%'", 3);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where HoTen like N'" + txtTimKiem.Text + "%'");
                    }
                    if (i == 3)
                    {
                        cls.loadtxtTimKiem(txtTimKiem, "select * from TblTTNVCoBan where MaNV like N'" + txtTimKiem.Text + "%'", 8);
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where CMTND like N'" + txtTimKiem.Text + "%'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

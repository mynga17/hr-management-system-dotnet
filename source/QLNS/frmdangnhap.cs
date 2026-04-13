using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLNS
{
    public partial class frmdangnhap : Form
    {
        Clsdatabase cls = new Clsdatabase();
        private SqlConnection Con = null;
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!", "Thông báo");
                txtTenDN.Focus();
                return;
            }
            if (txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo");
                txtMatKhau.Focus();
                return;
            }

            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-CH7IJ1K\SqlExpress;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            Con.Open();
            string select = "Select * From tbuser where Username='" + txtTenDN.Text + "' and Pass='" + txtMatKhau.Text + "' and Quyen='Admin'";
            SqlCommand cmd = new SqlCommand(select, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Read();
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin) !", "Thông báo !");
                FrmMain.quyen = "Admin";
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền user) !", "Thông báo !");
                FrmMain.quyen = "user";
                this.Hide();
            }

            FrmMain frm = new FrmMain();
            frm.ShowDialog();
            reader.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }
    }
}
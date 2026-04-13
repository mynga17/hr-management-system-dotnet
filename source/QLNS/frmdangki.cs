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
    public partial class frmdangki : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmdangki()
        {
            InitializeComponent();
        }

        private void frmdangki_Load(object sender, EventArgs e)
        {
            dateTimePickerNgaySinh.CustomFormat = " dd / MM / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from tbuser");
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenDN.ResetText();
            txtMatKhau.ResetText();
            txtTenThat.ResetText();
            txtQuyen.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerNgaySinh.CustomFormat = "dd / MM / yyyy";
                string insert = "insert into tbuser values(N'" + txtTenDN.Text + "',N'" + txtMatKhau.Text + "',N'" + txtQuyen.Text + "',N'" + txtTenThat.Text + "','" + dateTimePickerNgaySinh.Text + "')";
                if (cls.kttrungkhoa(txtTenDN.Text, "select * from tbuser") == true)
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn có thể thử tên khác");
                else
                {
                    cls.thucthiketnoi(insert);
                    MessageBox.Show("Chúc mừng bạn đã đăng kí thành công");
                    cls.loaddatagridview(dataGridView1, "select * from tbuser");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update tbuser set Username=N'" + txtTenDN.Text + "',Pass=N'" + txtMatKhau.Text + "',Quyen=N'" + txtQuyen.Text + "',Ten=N'" + txtTenThat.Text + "',Ngaysinh='" + dateTimePickerNgaySinh.Text + "' where Username='" + txtTenDN.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from tbuser");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from tbuser where Username=N'" + txtTenDN.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from tbuser");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtTenDN.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                txtMatKhau.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtTenThat.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                txtQuyen.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();


                dateTimePickerNgaySinh.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

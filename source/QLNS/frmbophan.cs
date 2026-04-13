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
    public partial class frmbophan : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmbophan()
        {
            InitializeComponent();
        }

        private void frmbophan_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dataGridView1, "select * from TblBoPhan");
            dateTimePickerNgayTL.CustomFormat = " dd / MM / yyyy ";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaBP.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenBP.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dateTimePickerNgayTL.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.ResetText();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaBP.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập mã bộ phận");
                    txtMaBP.Focus();
                    return;
                }

                if (!cls.kttrungkhoa(txtMaBP.Text, "select MaBoPhan from TblBoPhan"))
                {
                    string insert = "insert into TblBoPhan values(N'" + txtMaBP.Text + "',N'" + txtTenBP.Text + "',N'" + dateTimePickerNgayTL.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from TblBoPhan");
                }
                else
                {
                    MessageBox.Show("Bộ phận này đã tồn tại ", "Trùng bộ phận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string update = "update TblBoPhan set TenBoPhan=N'" + txtTenBP.Text + "',NgayThanhLap=N'" + dateTimePickerNgayTL.Text + "' where MaBoPhan='" + txtMaBP.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblBoPhan");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string del = "delete from TblBoPhan where MaBoPhan='" + txtMaBP.Text + "'";
            string del1 = "delete from TblPhongBan where MaBoPhan='" + txtMaBP.Text + "'";
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(del1);
                cls.thucthiketnoi(del);
                cls.loaddatagridview(dataGridView1, "select * from TblBoPhan");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

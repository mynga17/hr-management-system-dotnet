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
    public partial class frmphongban : Form
    {
        public frmphongban()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        private void frmphongban_Load(object sender, EventArgs e)
        {
            dateTimePickerNgayTL.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from TblPhongBan" +
                "");
            cls.loadcombobox(cbMaBP, "select * from TblBoPhan", 0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbMaBP.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMaPhong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtTenPhong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePickerNgayTL.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(txtMaPhong.Text, "select MaPhong from TblPhongBan"))
                {
                    string insert = "insert into TblPhongBan values('" + cbMaBP.Text + "',N'" + txtMaPhong.Text + "',N'" + txtTenPhong.Text + "',N'" + dateTimePickerNgayTL.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from TblPhongBan");
                }
                else
                {
                    MessageBox.Show("Mã phòng này đã tồn tại bạn có thể thử mã phòng khác", "Trùng mã phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string update = "update TblPhongBan set MaBoPhan=N'" + cbMaBP.Text + "',TenPhong=N'" + txtTenPhong.Text + "',NgayThanhLap=N'" + dateTimePickerNgayTL.Text + "' where MaPhong=N'" + txtMaPhong.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblPhongBan");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "delete from TblPhongBan where MaPhong=N'" + txtMaPhong.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(del);
                    cls.loaddatagridview(dataGridView1, "select * from TblPhongBan");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}

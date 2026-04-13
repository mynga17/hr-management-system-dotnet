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
    public partial class frmhosothuviec : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmhosothuviec()
        {
            InitializeComponent();
        }

        private void frmhosothuviec_Load(object sender, EventArgs e)
        {
            dateTimePickerNgaySinh.CustomFormat = " dd / MM / yyyy ";
            dateTimePickerNgayTV.CustomFormat = " dd / MM / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
            cls.loadcombobox(cmbMaPhong, "select * from Tblphongban", 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cmbMaPhong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMaNV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePickerNgaySinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtTrinhDo.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtVTriThuViec.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            dateTimePickerNgayTV.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txtThangTV.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }

        private void btnMoi_Click(object sender, EventArgs e)
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
            if (!cls.kttrungkhoa(txtMaNV.Text, "select MaNVTV from TblHoSoThuViec"))
            {
                string insert = "insert into TblHoSoThuViec values('" + cmbMaPhong.Text + "',N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + dateTimePickerNgaySinh.Text + "',N'" + txtGioiTinh.Text + "',N'" + txtDiaChi.Text + "',N'" + txtTrinhDo.Text + "',N'" + txtVTriThuViec.Text + "',N'" + dateTimePickerNgayTV.Text + "',N'" + txtThangTV.Text + "')";
                cls.thucthiketnoi(insert);
                cls.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại bạn có thể thử mã nhân viên khác", "Trùng mã nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblHoSoThuViec set MaPhong=N'" + cmbMaPhong.Text + "' where MaNVTV='" + txtMaNV.Text + "',HoTen=N'" + txtHoTen.Text + "',NgaySinh=N'" + dateTimePickerNgaySinh.Text + "',GioiTinh=N'" + txtGioiTinh.Text + "',DiaChi=N'" + txtDiaChi.Text + "',TDHocVan=N'" + txtTrinhDo.Text + "',ViTriThuViec=N'" + txtVTriThuViec.Text + "',NgayTV=N'" + dateTimePickerNgayTV.Text + "',ThangTV=N'" + txtThangTV.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string del = "delete from TblHoSoThuViec where MaNVTV='" + txtMaNV.Text + "'";
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(del);
                cls.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

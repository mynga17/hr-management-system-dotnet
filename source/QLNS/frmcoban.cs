using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;


namespace QLNS
{
    public partial class frmcoban : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        public frmcoban()
        {
            InitializeComponent();
        }

        private void frmcoban_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-CH7IJ1K\SqlExpress;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            dateTimePickerNgaySinh.CustomFormat = " dd / MM / yyyy ";
            dateTimePickerNgayKy.CustomFormat = " dd / MM / yyyy ";
            dateTimePickerNgayHetHan.CustomFormat = " dd / MM / yyyy ";

            frmcoban.FillCombo("SELECT MaBoPhan FROM TblBoPhan", cbMaBoPhan, "MaBoPhan", "MaBoPhan");
            cbMaBoPhan.SelectedIndex = -1;
            
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                cbMaBoPhan.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                cbMaPhong.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtMaNV.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();                
                dateTimePickerNgaySinh.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                cbGioiTinh.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
                txtTTHonNhan.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
                txtCMND.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
                txtNoiCap.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
                txtChucVu.Text = dataGridView1.Rows[hang].Cells[9].Value.ToString();
                txtLoaiHD.Text = dataGridView1.Rows[hang].Cells[10].Value.ToString();
                txtThoiGian.Text = dataGridView1.Rows[hang].Cells[11].Value.ToString();
                dateTimePickerNgayKy.Text = dataGridView1.Rows[hang].Cells[12].Value.ToString();
                dateTimePickerNgayHetHan.Text = dataGridView1.Rows[hang].Cells[13].Value.ToString();
                txtGhiChu.Text = dataGridView1.Rows[hang].Cells[14].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void cbMaBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmcoban.FillCombo("select p.MaPhong from TblBoPhan b,TblPhongBan p where b.MaBoPhan=p.MaBoPhan and p.MaBoPhan=N'" + cbMaBoPhan.SelectedValue + "'", cbMaPhong, "MaPhong", "MaPhong");
            cbMaPhong.DisplayMember = "MaPhong";
            cbMaPhong.ValueMember = "MaPhong";
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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
            string insert = "insert into TblTTNVCoBan values(N'" + cbMaBoPhan.Text + "',N'" + cbMaPhong.Text + "',N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + dateTimePickerNgaySinh.Text + "',N'" + cbGioiTinh.Text + "',N'" + txtTTHonNhan.Text + "',N'" + txtCMND.Text + "',N'" + txtNoiCap.Text + "',N'" + txtChucVu.Text + "',N'" + txtLoaiHD.Text + "',N'" + txtThoiGian.Text + "',N'" + dateTimePickerNgayKy.Text + "',N'" + dateTimePickerNgayHetHan.Text + "',N'" + txtGhiChu.Text + "')";

            if ((!cls.kttrungkhoa(txtMaNV.Text, "select MaNV from TblTTNVCoBan")))
            {
                if (txtMaNV.Text != "" && txtCMND.Text != "")
                {
                    cls.thucthiketnoi(insert);
                    dataGridView1.Refresh();
                    cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                    MessageBox.Show("Thêm thành công");
                }
                else if (txtMaNV.Text == "") MessageBox.Show("Bạn chưa nhập mã nhân viên");
                else if (txtCMND.Text == "") MessageBox.Show("Bạn chưa nhập số CMND");
            }
            else if ((!cls.kttrungkhoa(txtMaNV.Text, "select MaNV from TblTTNVCoBan")))
            {
                if (MessageBox.Show("Nhân viên này đã từng làm ở công ty, bạn có chắc muốn thêm?", "Thêm thất bại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                    MessageBox.Show("Thêm thành công");
                }
            }
            else if ((cls.kttrungkhoa(txtMaNV.Text, "select MaNV from TblTTNVCoBan")))
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            string ine = "insert into TblTTCaNhan(MaNV,HoTen) select MaNV,HoTen from TblTTNVCoBan where MaNV='" + txtMaNV.Text + "'";
            if ((!cls.kttrungkhoa(txtMaNV.Text, "select MaNV from TblTTCaNhan")))
            {
                if (txtMaNV.Text != "")
                {
                    cls.thucthiketnoi(ine);
                    dataGridView1.Refresh();
                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView1.Refresh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string update = "update TblTTNVCoBan set MaBoPhan=N'" + cbMaBoPhan.Text + "',MaPhong=N'" + cbMaPhong.Text + "',HoTen=N'" + txtHoTen.Text + "',NgaySinh='" + dateTimePickerNgaySinh.Text + "',GioiTinh=N'" + cbGioiTinh.Text + "',TTHonNhan=N'" + txtTTHonNhan.Text + "',CMTND=N'" + txtCMND.Text + "',NoiCap=N'" + txtNoiCap.Text + "',ChucVu=N'" + txtChucVu.Text + "',LoaiHD=N'" + txtLoaiHD.Text + "',ThoiGian=N'" + txtThoiGian.Text + "',NgayKy='" + dateTimePickerNgayKy.Text + "',NgayHetHan='" + dateTimePickerNgayHetHan.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaNV=N'" + txtMaNV.Text + "'";
            cls.thucthiketnoi(update);
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            MessageBox.Show("Sửa thành công");
            //cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            dataGridView1.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblTTNVCoBan where MaNV=N'" + txtMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

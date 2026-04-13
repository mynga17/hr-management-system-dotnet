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
    public partial class frmchedo : Form
    {
        Clsdatabase cls = new Clsdatabase();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        public frmchedo()
        {
            InitializeComponent();
        }

        private void frmchedo_Load(object sender, EventArgs e)
        {
            dateTimePickerNgayCapSo.CustomFormat = " dd / MM / yyyy ";
            datetimePickerNgaySinh.CustomFormat = " dd / MM / yyyy ";
            datetimePickerNgayVeSom.CustomFormat = " dd / MM / yyyy ";
            dateTimePickerNgayVeSinh.CustomFormat = " dd / MM / yyyy ";
            dateTimePackerNgayLamLai.CustomFormat = " dd / MM / yyyy ";
            cls.loadcombobox(cbMaNV, "select * from TblTTNVCoBan", 2);
            cls.loadcombobox(cbMaNV2, "select * from TblTTNVCoBan", 2);
            cls.loaddatagridview1(dataGridViewBH, ds1, "select * from TblSoBH");
            cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaBP.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtMaPhong.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            cbMaNV2.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txtHoTen.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            datetimePickerNgaySinh.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            datetimePickerNgayVeSom.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            dateTimePickerNgayVeSinh.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            dateTimePackerNgayLamLai.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txtTroCap.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txtMaBH, "select * from TblSoBH where MaNV=N'" + cbMaNV.Text + "'", 2);
            cls.loaddatetime(dateTimePickerNgayCapSo, "select * from TblSoBH where MaNV=N'" + cbMaNV.Text + "'", 3);
            cls.loadtextboxchiso(txtNoiCapSo, "select * from TblSoBH where MaNV=N'" + cbMaNV.Text + "'", 4);
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

                string insert = "insert into TblSoBH values(N'" + cbMaNV.Text + "',N'" + txtMaBH.Text + "',N'" + dateTimePickerNgayCapSo.Text + "',N'" + txtNoiCapSo.Text + "')";
                if (!cls.kttrungkhoa(txtMaBH.Text, "select MaSoBH from TblSoBH"))
                {
                    if (txtMaBH.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridViewBH.Refresh();
                        cls.loaddatagridview1(dataGridViewBH, ds1, "select * from TblSoBH");
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa nhập mã số bảo hiểm");
                }
                else
                    MessageBox.Show("Mã số bảo hiểm này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string update = "update TblSoBH set NgayCapSo=N'" + dateTimePickerNgayCapSo.Text + "',NoiCapSo=N'" + txtNoiCapSo.Text + "' where MaNV=N'" + cbMaNV.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridViewBH, ds1, "select * from TblSoBH");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblSoBH where MaNV'" + cbMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview1(dataGridViewBH, ds1, "select * from TblSoBH");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbMaNV.Text = dataGridViewBH.Rows[i].Cells[0].Value.ToString();
            txtMaBH.Text = dataGridViewBH.Rows[i].Cells[1].Value.ToString();
            dateTimePickerNgayCapSo.Text = dataGridViewBH.Rows[i].Cells[2].Value.ToString();
            txtNoiCapSo.Text = dataGridViewBH.Rows[i].Cells[3].Value.ToString();
        }

        private void cbMaNV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txtMaBP, "select * from TblTTNVCoBan where MaNV=N'" + cbMaNV2.Text + "'", 9);
            cls.loadtextboxchiso(txtMaPhong, "select * from TblTTNVCoBan where MaNV=N'" + cbMaNV2.Text + "'", 1);
            cls.loadtextboxchiso(txtHoTen, "select * from TblTTNVCoBan where MaNV=N'" + cbMaNV2.Text + "'", 3);
            cls.loadtextboxchiso(txtTroCap, "select * from TblThaiSan where MaNV=N'" + cbMaNV2.Text + "'", 8);
            cls.loaddatetime(datetimePickerNgaySinh, "select * from TblThaiSan where MaNV=N'" + cbMaNV2.Text + "'", 4);
            cls.loaddatetime(datetimePickerNgayVeSom, "select * from TblThaiSan where MaNV=N'" + cbMaNV2.Text + "'", 5);
            cls.loaddatetime(dateTimePickerNgayVeSinh, "select * from TblThaiSan where MaNV=N'" + cbMaNV2.Text + "'", 6);
            cls.loaddatetime(dateTimePackerNgayLamLai, "select * from TblThaiSan where MaNV=N'" + cbMaNV2.Text + "'", 7);
        }

        private void btn2LamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.ResetText();
                }
            }
        }

        private void btn2Them_Click(object sender, EventArgs e)
        {
            string insert = "insert into TblThaiSan values(N'" + txtMaBP.Text + "',N'" + txtMaPhong.Text + "',N'" + cbMaNV2.Text + "',N'" + txtHoTen.Text + "',N'" + datetimePickerNgaySinh.Text + "',N'" + datetimePickerNgayVeSom.Text + "',N'" + dateTimePickerNgayVeSinh.Text + "',N'" + dateTimePackerNgayLamLai.Text + "',N'" + txtTroCap.Text + "')";
            if (!cls.kttrungkhoa(cbMaNV2.Text, "select MaNV from TblThaiSan"))
            {
                if (cbMaNV2.Text != "")
                {
                    cls.thucthiketnoi(insert);
                    dataGridViewBH.Refresh();
                    cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
                    MessageBox.Show("Thêm thành công");
                }
                else MessageBox.Show("Bạn chưa nhập mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn2Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblThaiSan set HoTen=N'" + txtHoTen.Text + "',NgaySinh=N'" + datetimePickerNgaySinh.Text + "',NgayVeSom=N'" + datetimePickerNgayVeSom.Text + "',NgayNghiSinh=N'" + dateTimePickerNgayVeSinh.Text + "',NgayLamTroLai='" + dateTimePackerNgayLamLai.Text + "',TroCapCTy=N'" + txtTroCap.Text + "' where MaNV=N'" + cbMaNV2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btn2Xoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblThaiSan where MaNV=N'" + cbMaNV2.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
        }

        private void btn2Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

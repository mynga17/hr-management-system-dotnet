using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace QLNS
{
    public partial class frmthongtincanhan : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmthongtincanhan()
        {
            InitializeComponent();
        }

        private void frmthongtincanhan_Load(object sender, EventArgs e)
        {
            
            cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
            cls.loadcombobox(cbMaNV, "select * from TblTTNVCoBan", 2);
        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int hang = e.RowIndex;
                cbMaNV.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtNoiSinh.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                txtNguyenQuan.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                txtThuongTru.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                txtTamTru.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
                txtDanToc.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
                txtTonGiao.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
                txtQuocTich.Text = dataGridView1.Rows[hang].Cells[9].Value.ToString();
                txtHocVan.Text = dataGridView1.Rows[hang].Cells[10].Value.ToString();
                txtGhiChu.Text = dataGridView1.Rows[hang].Cells[11].Value.ToString();
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txtHoTen, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 1);
            cls.loadtextboxchiso(txtNoiSinh, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 2);
            cls.loadtextboxchiso(txtNguyenQuan, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 3);
            cls.loadtextboxchiso(txtThuongTru, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 4);
            cls.loadtextboxchiso(txtTamTru, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 5);
            cls.loadtextboxchiso(txtSDT, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 6);
            cls.loadtextboxchiso(txtDanToc, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 7);
            cls.loadtextboxchiso(txtTonGiao, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 8);
            cls.loadtextboxchiso(txtQuocTich, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 9);
            cls.loadtextboxchiso(txtHocVan, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 10);
            cls.loadtextboxchiso(txtGhiChu, "select * from TblTTCaNhan where MaNV='" + cbMaNV.Text + "'", 11);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblTTCaNhan set Manv=N'" + cbMaNV.Text + "',Noisinh=N'" + txtNoiSinh.Text + "',NguyenQuan=N'" + txtNguyenQuan.Text + "',DCThuongTru=N'" + txtThuongTru.Text + "',DCTamTru=N'" + txtTamTru.Text + "',SDT=N'" + txtSDT.Text + "',DanToc=N'" + txtDanToc.Text + "',TonGiao=N'" + txtTonGiao.Text + "',QuocTich=N'" + txtQuocTich.Text + "',HocVan=N'" + txtHocVan.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaNV=N'" + cbMaNV.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
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
                string delete = "delete from TblTTCaNhan where MaNV=N'" + cbMaNV.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
                }
                MessageBox.Show("Đã xóa dữ liệu ");
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
    }
}

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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public int k = 1;
        public static string quyen;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            if (quyen == "Admin")
            {
                menuDanhMuc.Enabled = true;
                menuChucNang.Enabled = true;
                menuQuanLy.Enabled = true;
                menuQLTK.Enabled = true;
            }
            else if(quyen=="user")
            {
                menuDanhMuc.Enabled = true;
                menuChucNang.Enabled = true;
                menuQuanLy.Enabled = true;
                menuQLTK.Enabled = false;
            }
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            frmdangnhap dn = new frmdangnhap();
            this.Hide();
            dn.ShowDialog();
            dn.Show();
        }

        private void menuQLTK_Click(object sender, EventArgs e)
        {
            frmdangki b = new frmdangki();
            panel_show.Show();
            panel_show.Controls.Clear();
            b.TopLevel = false;
            b.Dock = DockStyle.Fill;
            panel_show.Controls.Add(b);
            b.Show();
        }

        private void menuDmk_Click(object sender, EventArgs e)
        {
            frmdoimatkhau fdm = new frmdoimatkhau();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuNhanSu_Click(object sender, EventArgs e)
        {
            frmcoban fc = new frmcoban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fc);
            fc.Show();
        }

        private void menuTTCaNhan_Click(object sender, EventArgs e)
        {
            frmthongtincanhan ft = new frmthongtincanhan();
            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }

        private void menuCheDo_Click(object sender, EventArgs e)
        {
            frmchedo fcd = new frmchedo();
            panel_show.Show();
            panel_show.Controls.Clear();
            fcd.TopLevel = false;
            fcd.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fcd);
            fcd.Show();
        }

        private void menuHSThuViec_Click(object sender, EventArgs e)
        {
            frmhosothuviec bag = new frmhosothuviec();
            panel_show.Show();
            panel_show.Controls.Clear();
            bag.TopLevel = false;
            bag.Dock = DockStyle.Fill;
            panel_show.Controls.Add(bag);
            bag.Show();
        }

        private void menuTimKiem_Click(object sender, EventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void menuPhongBan_Click(object sender, EventArgs e)
        {
            frmphongban fpb = new frmphongban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();
        }

        private void menuBoPhan_Click(object sender, EventArgs e)
        {
            frmbophan frb = new frmbophan();
            panel_show.Show();
            panel_show.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frb);
            frb.Show();
        }
    }
}

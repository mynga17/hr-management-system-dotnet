namespace QLNS
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.barBubble = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_show = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDmk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTTCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCheDo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHSThuViec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBoPhan = new System.Windows.Forms.ToolStripMenuItem();
            this.btntracuu = new DevComponents.DotNetBar.BubbleButton();
            this.btndmk = new DevComponents.DotNetBar.BubbleButton();
            this.btnchedo = new DevComponents.DotNetBar.BubbleButton();
            this.btnluong = new DevComponents.DotNetBar.BubbleButton();
            this.bubblenhansu = new DevComponents.DotNetBar.BubbleButton();
            this.bubblebophan = new DevComponents.DotNetBar.BubbleButton();
            this.bubblephongban = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleBcnhanvien = new DevComponents.DotNetBar.BubbleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barBubble)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // barBubble
            // 
            this.barBubble.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.barBubble.AntiAlias = true;
            this.barBubble.ImageSizeNormal = new System.Drawing.Size(24, 24);
            this.barBubble.Location = new System.Drawing.Point(0, 0);
            this.barBubble.Name = "barBubble";
            this.barBubble.Size = new System.Drawing.Size(0, 0);
            this.barBubble.TabIndex = 0;
            // 
            // bubbleBarTab
            // 
            this.bubbleBarTab.Name = "bubbleBarTab";
            this.bubbleBarTab.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_show);
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Location = new System.Drawing.Point(5, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 721);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(90, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // panel_show
            // 
            this.panel_show.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show.Location = new System.Drawing.Point(53, 186);
            this.panel_show.Margin = new System.Windows.Forms.Padding(4);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1088, 513);
            this.panel_show.TabIndex = 18;
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTaiKhoan,
            this.menuDanhMuc,
            this.menuChucNang,
            this.menuQuanLy});
            this.menuStrip.Location = new System.Drawing.Point(34, 99);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(452, 44);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangNhap,
            this.menuQLTK,
            this.menuDmk});
            this.menuTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(102, 40);
            this.menuTaiKhoan.Text = "&Tài khoản";
            // 
            // menuDangNhap
            // 
            this.menuDangNhap.BackColor = System.Drawing.Color.White;
            this.menuDangNhap.Name = "menuDangNhap";
            this.menuDangNhap.Size = new System.Drawing.Size(232, 26);
            this.menuDangNhap.Text = "Đăng nhập";
            this.menuDangNhap.Click += new System.EventHandler(this.menuDangNhap_Click);
            // 
            // menuQLTK
            // 
            this.menuQLTK.Enabled = false;
            this.menuQLTK.Name = "menuQLTK";
            this.menuQLTK.Size = new System.Drawing.Size(232, 26);
            this.menuQLTK.Text = "Quản lý tài khoản";
            this.menuQLTK.Click += new System.EventHandler(this.menuQLTK_Click);
            // 
            // menuDmk
            // 
            this.menuDmk.Name = "menuDmk";
            this.menuDmk.Size = new System.Drawing.Size(232, 26);
            this.menuDmk.Text = "Đổi mật khẩu";
            this.menuDmk.Click += new System.EventHandler(this.menuDmk_Click);
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanSu,
            this.menuTTCaNhan,
            this.menuCheDo,
            this.menuHSThuViec});
            this.menuDanhMuc.Enabled = false;
            this.menuDanhMuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDanhMuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(102, 40);
            this.menuDanhMuc.Text = "&Danh mục";
            // 
            // menuNhanSu
            // 
            this.menuNhanSu.Name = "menuNhanSu";
            this.menuNhanSu.Size = new System.Drawing.Size(232, 26);
            this.menuNhanSu.Text = "Nhân sự";
            this.menuNhanSu.Click += new System.EventHandler(this.menuNhanSu_Click);
            // 
            // menuTTCaNhan
            // 
            this.menuTTCaNhan.Name = "menuTTCaNhan";
            this.menuTTCaNhan.Size = new System.Drawing.Size(232, 26);
            this.menuTTCaNhan.Text = "Thông tin cá nhân";
            this.menuTTCaNhan.Click += new System.EventHandler(this.menuTTCaNhan_Click);
            // 
            // menuCheDo
            // 
            this.menuCheDo.Name = "menuCheDo";
            this.menuCheDo.Size = new System.Drawing.Size(232, 26);
            this.menuCheDo.Text = "Chế độ";
            this.menuCheDo.Click += new System.EventHandler(this.menuCheDo_Click);
            // 
            // menuHSThuViec
            // 
            this.menuHSThuViec.Name = "menuHSThuViec";
            this.menuHSThuViec.Size = new System.Drawing.Size(232, 26);
            this.menuHSThuViec.Text = "Hồ sơ thử việc";
            this.menuHSThuViec.Click += new System.EventHandler(this.menuHSThuViec_Click);
            // 
            // menuChucNang
            // 
            this.menuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTimKiem});
            this.menuChucNang.Enabled = false;
            this.menuChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuChucNang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuChucNang.Name = "menuChucNang";
            this.menuChucNang.Size = new System.Drawing.Size(107, 40);
            this.menuChucNang.Text = "&Chức năng";
            // 
            // menuTimKiem
            // 
            this.menuTimKiem.Name = "menuTimKiem";
            this.menuTimKiem.Size = new System.Drawing.Size(155, 26);
            this.menuTimKiem.Text = "Tra cứu";
            this.menuTimKiem.Click += new System.EventHandler(this.menuTimKiem_Click);
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPhongBan,
            this.menuBoPhan});
            this.menuQuanLy.Enabled = false;
            this.menuQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(86, 40);
            this.menuQuanLy.Text = "&Quản lý";
            // 
            // menuPhongBan
            // 
            this.menuPhongBan.Name = "menuPhongBan";
            this.menuPhongBan.Size = new System.Drawing.Size(175, 26);
            this.menuPhongBan.Text = "&Phòng ban";
            this.menuPhongBan.Click += new System.EventHandler(this.menuPhongBan_Click);
            // 
            // menuBoPhan
            // 
            this.menuBoPhan.Name = "menuBoPhan";
            this.menuBoPhan.Size = new System.Drawing.Size(175, 26);
            this.menuBoPhan.Text = "&Bộ phận";
            this.menuBoPhan.Click += new System.EventHandler(this.menuBoPhan_Click);
            // 
            // btntracuu
            // 
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.TooltipText = "Tra cứu";
            // 
            // btndmk
            // 
            this.btndmk.Name = "btndmk";
            this.btndmk.TooltipText = "Đổi Mật khẩu";
            // 
            // btnchedo
            // 
            this.btnchedo.Name = "btnchedo";
            this.btnchedo.TooltipText = "Chế Độ";
            // 
            // btnluong
            // 
            this.btnluong.Name = "btnluong";
            this.btnluong.TooltipText = "Tiền Lương";
            // 
            // bubblenhansu
            // 
            this.bubblenhansu.Name = "bubblenhansu";
            // 
            // bubblebophan
            // 
            this.bubblebophan.Name = "bubblebophan";
            // 
            // bubblephongban
            // 
            this.bubblephongban.Name = "bubblephongban";
            // 
            // bubbleBcnhanvien
            // 
            this.bubbleBcnhanvien.Name = "bubbleBcnhanvien";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 746);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barBubble)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.BubbleBar barBubble;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab;
        public DevComponents.DotNetBar.BubbleButton btntracuu;
        public DevComponents.DotNetBar.BubbleButton btndmk;
        private DevComponents.DotNetBar.BubbleButton btnchedo;
        private DevComponents.DotNetBar.BubbleButton btnluong;
        private DevComponents.DotNetBar.BubbleButton bubblenhansu;
        private DevComponents.DotNetBar.BubbleButton bubblebophan;
        private DevComponents.DotNetBar.BubbleButton bubblephongban;
        private DevComponents.DotNetBar.BubbleButton bubbleBcnhanvien;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menuQLTK;
        private System.Windows.Forms.ToolStripMenuItem menuDmk;
        public System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuNhanSu;
        private System.Windows.Forms.ToolStripMenuItem menuTTCaNhan;
        private System.Windows.Forms.ToolStripMenuItem menuCheDo;
        private System.Windows.Forms.ToolStripMenuItem menuHSThuViec;
        public System.Windows.Forms.ToolStripMenuItem menuChucNang;
        private System.Windows.Forms.ToolStripMenuItem menuTimKiem;
        public System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuPhongBan;
        private System.Windows.Forms.ToolStripMenuItem menuBoPhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.Label label1;
    }
}
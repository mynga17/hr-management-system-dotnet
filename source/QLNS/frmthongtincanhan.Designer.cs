namespace QLNS
{
    partial class frmthongtincanhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthongtincanhan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtHocVan = new System.Windows.Forms.TextBox();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.txtTonGiao = new System.Windows.Forms.TextBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTamTru = new System.Windows.Forms.TextBox();
            this.txtThuongTru = new System.Windows.Forms.TextBox();
            this.txtNguyenQuan = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.cbMaNV);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtHocVan);
            this.groupBox1.Controls.Add(this.txtQuocTich);
            this.groupBox1.Controls.Add(this.txtTonGiao);
            this.groupBox1.Controls.Add(this.txtDanToc);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTamTru);
            this.groupBox1.Controls.Add(this.txtThuongTru);
            this.groupBox1.Controls.Add(this.txtNguyenQuan);
            this.groupBox1.Controls.Add(this.txtNoiSinh);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(925, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(94, 78);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(143, 25);
            this.txtHoTen.TabIndex = 2;
            // 
            // cbMaNV
            // 
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(94, 34);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(143, 25);
            this.cbMaNV.TabIndex = 1;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(721, 150);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(134, 25);
            this.txtGhiChu.TabIndex = 12;
            // 
            // txtHocVan
            // 
            this.txtHocVan.Location = new System.Drawing.Point(722, 70);
            this.txtHocVan.Margin = new System.Windows.Forms.Padding(4);
            this.txtHocVan.Name = "txtHocVan";
            this.txtHocVan.Size = new System.Drawing.Size(133, 25);
            this.txtHocVan.TabIndex = 10;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Location = new System.Drawing.Point(721, 30);
            this.txtQuocTich.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(134, 25);
            this.txtQuocTich.TabIndex = 9;
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.Location = new System.Drawing.Point(416, 30);
            this.txtTonGiao.Margin = new System.Windows.Forms.Padding(4);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.Size = new System.Drawing.Size(143, 25);
            this.txtTonGiao.TabIndex = 5;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Location = new System.Drawing.Point(94, 154);
            this.txtDanToc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(143, 25);
            this.txtDanToc.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(721, 109);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(134, 25);
            this.txtSDT.TabIndex = 11;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtTamTru
            // 
            this.txtTamTru.Location = new System.Drawing.Point(416, 115);
            this.txtTamTru.Margin = new System.Windows.Forms.Padding(4);
            this.txtTamTru.Name = "txtTamTru";
            this.txtTamTru.Size = new System.Drawing.Size(143, 25);
            this.txtTamTru.TabIndex = 7;
            // 
            // txtThuongTru
            // 
            this.txtThuongTru.Location = new System.Drawing.Point(416, 74);
            this.txtThuongTru.Margin = new System.Windows.Forms.Padding(4);
            this.txtThuongTru.Name = "txtThuongTru";
            this.txtThuongTru.Size = new System.Drawing.Size(143, 25);
            this.txtThuongTru.TabIndex = 6;
            // 
            // txtNguyenQuan
            // 
            this.txtNguyenQuan.Location = new System.Drawing.Point(416, 154);
            this.txtNguyenQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNguyenQuan.Name = "txtNguyenQuan";
            this.txtNguyenQuan.Size = new System.Drawing.Size(143, 25);
            this.txtNguyenQuan.TabIndex = 8;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(94, 112);
            this.txtNoiSinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(143, 25);
            this.txtNoiSinh.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(646, 153);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Ghi chú\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(646, 77);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Học vấn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(646, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quốc tịch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tôn giáo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dân tộc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ĐC tạm trú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐC thường trú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nguyên quán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nơi sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 239);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(925, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(94, 22);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(102, 41);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới   ";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(671, 22);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 41);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(471, 22);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 41);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa   ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(280, 22);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 41);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa   ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(10, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 232);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(918, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmthongtincanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmthongtincanhan";
            this.Text = "THÔNG TIN CÁ NHÂN";
            this.Load += new System.EventHandler(this.frmthongtincanhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtHocVan;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.TextBox txtTonGiao;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTamTru;
        private System.Windows.Forms.TextBox txtThuongTru;
        private System.Windows.Forms.TextBox txtNguyenQuan;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}
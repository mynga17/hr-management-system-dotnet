namespace QLNS
{
    partial class frmtimkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtimkiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rbtnCMND = new System.Windows.Forms.RadioButton();
            this.rbtnHoTen = new System.Windows.Forms.RadioButton();
            this.rbtnMaNV = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.rbtnCMND);
            this.groupBox1.Controls.Add(this.rbtnHoTen);
            this.groupBox1.Controls.Add(this.rbtnMaNV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(933, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm ";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(411, 137);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 54);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(47, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 174);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(592, 137);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 54);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát    ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(396, 38);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(368, 24);
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(368, 24);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(368, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "Nhập vào từ khóa tìm kiếm";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rbtnCMND
            // 
            this.rbtnCMND.AutoSize = true;
            this.rbtnCMND.Location = new System.Drawing.Point(621, 79);
            this.rbtnCMND.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCMND.Name = "rbtnCMND";
            this.rbtnCMND.Size = new System.Drawing.Size(74, 21);
            this.rbtnCMND.TabIndex = 0;
            this.rbtnCMND.TabStop = true;
            this.rbtnCMND.Text = "CMND";
            this.rbtnCMND.UseVisualStyleBackColor = true;
            this.rbtnCMND.CheckedChanged += new System.EventHandler(this.rbtnCMND_CheckedChanged);
            // 
            // rbtnHoTen
            // 
            this.rbtnHoTen.AutoSize = true;
            this.rbtnHoTen.Location = new System.Drawing.Point(444, 79);
            this.rbtnHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnHoTen.Name = "rbtnHoTen";
            this.rbtnHoTen.Size = new System.Drawing.Size(87, 21);
            this.rbtnHoTen.TabIndex = 0;
            this.rbtnHoTen.TabStop = true;
            this.rbtnHoTen.Text = "Họ và tên";
            this.rbtnHoTen.UseVisualStyleBackColor = true;
            this.rbtnHoTen.CheckedChanged += new System.EventHandler(this.rbtnHoTen_CheckedChanged);
            // 
            // rbtnMaNV
            // 
            this.rbtnMaNV.AutoSize = true;
            this.rbtnMaNV.Location = new System.Drawing.Point(271, 79);
            this.rbtnMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMaNV.Name = "rbtnMaNV";
            this.rbtnMaNV.Size = new System.Drawing.Size(109, 21);
            this.rbtnMaNV.TabIndex = 1;
            this.rbtnMaNV.TabStop = true;
            this.rbtnMaNV.Text = "Mã nhân viên";
            this.rbtnMaNV.UseVisualStyleBackColor = true;
            this.rbtnMaNV.CheckedChanged += new System.EventHandler(this.rbtnMaNV_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(39, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(937, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(929, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1027, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmtimkiem";
            this.Text = "TÌM KIẾM THÔNG TIN";
            this.Load += new System.EventHandler(this.frmtimkiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rbtnCMND;
        private System.Windows.Forms.RadioButton rbtnHoTen;
        private System.Windows.Forms.RadioButton rbtnMaNV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
    }
}
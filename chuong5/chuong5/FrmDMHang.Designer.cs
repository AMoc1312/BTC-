namespace chuong5
{
    partial class FrmDMHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lbGiaNhap = new System.Windows.Forms.Label();
            this.lbsoLuong = new System.Windows.Forms.Label();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.GiaBan,
            this.GiaNhap,
            this.soLuong});
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "MaHang";
            this.MaHang.Name = "MaHang";
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "TenHang";
            this.TenHang.Name = "TenHang";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "GiaNhap";
            this.GiaNhap.Name = "GiaNhap";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "soLuong";
            this.soLuong.Name = "soLuong";
            // 
            // lbMaHang
            // 
            this.lbMaHang.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.Location = new System.Drawing.Point(45, 24);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(51, 13);
            this.lbMaHang.TabIndex = 1;
            this.lbMaHang.Text = "Ma Hang";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(147, 24);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(161, 20);
            this.txtMaHang.TabIndex = 2;
            // 
            // lbTenHang
            // 
            this.lbTenHang.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Location = new System.Drawing.Point(45, 76);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(55, 13);
            this.lbTenHang.TabIndex = 3;
            this.lbTenHang.Text = "Ten Hang";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(147, 76);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(161, 20);
            this.txtTenHang.TabIndex = 4;
            // 
            // lbGiaNhap
            // 
            this.lbGiaNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbGiaNhap.AutoSize = true;
            this.lbGiaNhap.Location = new System.Drawing.Point(45, 129);
            this.lbGiaNhap.Name = "lbGiaNhap";
            this.lbGiaNhap.Size = new System.Drawing.Size(52, 13);
            this.lbGiaNhap.TabIndex = 5;
            this.lbGiaNhap.Text = "Gia Nhap";
            // 
            // lbsoLuong
            // 
            this.lbsoLuong.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbsoLuong.AutoSize = true;
            this.lbsoLuong.Location = new System.Drawing.Point(354, 83);
            this.lbsoLuong.Name = "lbsoLuong";
            this.lbsoLuong.Size = new System.Drawing.Size(48, 13);
            this.lbsoLuong.TabIndex = 6;
            this.lbsoLuong.Text = "soLuong";
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Location = new System.Drawing.Point(354, 31);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(45, 13);
            this.lbGiaBan.TabIndex = 7;
            this.lbGiaBan.Text = "Gai Ban";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(147, 122);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(161, 20);
            this.txtGiaNhap.TabIndex = 8;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(426, 24);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(161, 20);
            this.txtGiaBan.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(426, 76);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(161, 20);
            this.txtSoLuong.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(48, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 25);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(156, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 25);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(272, 178);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 24);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmDMHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 435);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.lbGiaBan);
            this.Controls.Add(this.lbsoLuong);
            this.Controls.Add(this.lbGiaNhap);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.lbTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.lbMaHang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmDMHang";
            this.Text = "w2";
            this.Load += new System.EventHandler(this.FrmDMHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMaHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lbGiaNhap;
        private System.Windows.Forms.Label lbsoLuong;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;

    }
}
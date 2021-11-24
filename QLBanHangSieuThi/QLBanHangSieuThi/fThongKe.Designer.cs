
namespace QLBanHangSieuThi
{
    partial class fThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongKe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbbQuy = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQLNguoiDung = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnHoaDonBan = new System.Windows.Forms.Button();
            this.btnHoaDonNhap = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 469);
            this.dataGridView1.TabIndex = 0;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.LightGreen;
            this.btTimKiem.FlatAppearance.BorderSize = 0;
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(425, 22);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(79, 29);
            this.btTimKiem.TabIndex = 7;
            this.btTimKiem.Text = "Thống kê";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(122, 25);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(248, 26);
            this.tbTimKiem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập từ khóa";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(6, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1007, 76);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbbQuy);
            this.panel6.Controls.Add(this.btnIn);
            this.panel6.Controls.Add(this.btTimKiem);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.tbTimKiem);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1007, 76);
            this.panel6.TabIndex = 0;
            // 
            // cbbQuy
            // 
            this.cbbQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuy.FormattingEnabled = true;
            this.cbbQuy.Items.AddRange(new object[] {
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
            this.cbbQuy.Location = new System.Drawing.Point(122, 23);
            this.cbbQuy.Margin = new System.Windows.Forms.Padding(2);
            this.cbbQuy.Name = "cbbQuy";
            this.cbbQuy.Size = new System.Drawing.Size(248, 28);
            this.cbbQuy.TabIndex = 8;
            this.cbbQuy.SelectedIndexChanged += new System.EventHandler(this.cbbQuy_SelectedIndexChanged);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.LightGreen;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(568, 22);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(97, 29);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Location = new System.Drawing.Point(6, 82);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1007, 469);
            this.panel8.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(206, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 564);
            this.panel4.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rdo4);
            this.panel1.Controls.Add(this.rdo1);
            this.panel1.Controls.Add(this.rdo2);
            this.panel1.Controls.Add(this.rdo3);
            this.panel1.Location = new System.Drawing.Point(6, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 85);
            this.panel1.TabIndex = 0;
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.Location = new System.Drawing.Point(550, 47);
            this.rdo4.Margin = new System.Windows.Forms.Padding(2);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(411, 23);
            this.rdo4.TabIndex = 0;
            this.rdo4.TabStop = true;
            this.rdo4.Text = "Báo cáo ds 3 Khách hàng mua ít hàng nhất theo quý chọn trước";
            this.rdo4.UseVisualStyleBackColor = true;
            this.rdo4.CheckedChanged += new System.EventHandler(this.rdo4_CheckedChanged);
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(17, 12);
            this.rdo1.Margin = new System.Windows.Forms.Padding(2);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(417, 23);
            this.rdo1.TabIndex = 0;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "Báo cáo danh sách các sản phẩm bán chạy nhất trong một tháng.";
            this.rdo1.UseVisualStyleBackColor = true;
            this.rdo1.CheckedChanged += new System.EventHandler(this.rdo1_CheckedChanged);
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(17, 47);
            this.rdo2.Margin = new System.Windows.Forms.Padding(2);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(524, 23);
            this.rdo2.TabIndex = 0;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "Báo cáo danh sách 3 hoá đơn và tổng tiền nhập hàng nhiều tiền nhất theo một năm.\r" +
    "\n";
            this.rdo2.UseVisualStyleBackColor = true;
            this.rdo2.CheckedChanged += new System.EventHandler(this.rdo2_CheckedChanged);
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(550, 12);
            this.rdo3.Margin = new System.Windows.Forms.Padding(2);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(434, 23);
            this.rdo3.TabIndex = 0;
            this.rdo3.TabStop = true;
            this.rdo3.Text = "Báo cáo danh sách hoá đơn và tổng tiền bán hàng từ một nhân viên.";
            this.rdo3.UseVisualStyleBackColor = true;
            this.rdo3.CheckedChanged += new System.EventHandler(this.rdo3_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQLNguoiDung);
            this.panel2.Controls.Add(this.btnNhanVien);
            this.panel2.Controls.Add(this.btnKhachHang);
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.btnHoaDonBan);
            this.panel2.Controls.Add(this.btnHoaDonNhap);
            this.panel2.Controls.Add(this.btnBanHang);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 511);
            this.panel2.TabIndex = 9;
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.BackColor = System.Drawing.SystemColors.Control;
            this.btnQLNguoiDung.BackgroundImage = global::QLBanHangSieuThi.Properties.Resources.ql_nguoi_dung;
            this.btnQLNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnQLNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNguoiDung.Location = new System.Drawing.Point(0, 437);
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            this.btnQLNguoiDung.Size = new System.Drawing.Size(200, 67);
            this.btnQLNguoiDung.TabIndex = 6;
            this.btnQLNguoiDung.UseVisualStyleBackColor = false;
            this.btnQLNguoiDung.Click += new System.EventHandler(this.btnQLNguoiDung_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackgroundImage = global::QLBanHangSieuThi.Properties.Resources.nhan_vien;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 364);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(200, 67);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackgroundImage = global::QLBanHangSieuThi.Properties.Resources.khach_hang;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 291);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(200, 67);
            this.btnKhachHang.TabIndex = 4;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackgroundImage = global::QLBanHangSieuThi.Properties.Resources.thong_ke;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Location = new System.Drawing.Point(0, 218);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 67);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonBan
            // 
            this.btnHoaDonBan.BackgroundImage = global::QLBanHangSieuThi.Properties.Resources._2;
            this.btnHoaDonBan.FlatAppearance.BorderSize = 0;
            this.btnHoaDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonBan.Location = new System.Drawing.Point(0, 145);
            this.btnHoaDonBan.Name = "btnHoaDonBan";
            this.btnHoaDonBan.Size = new System.Drawing.Size(200, 67);
            this.btnHoaDonBan.TabIndex = 2;
            this.btnHoaDonBan.UseVisualStyleBackColor = true;
            this.btnHoaDonBan.Click += new System.EventHandler(this.btnHoaDonBan_Click);
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.BackgroundImage = global::QLBanHangSieuThi.Properties.Resources._1;
            this.btnHoaDonNhap.FlatAppearance.BorderSize = 0;
            this.btnHoaDonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonNhap.Location = new System.Drawing.Point(0, 72);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(200, 67);
            this.btnHoaDonNhap.TabIndex = 1;
            this.btnHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackgroundImage = global::QLBanHangSieuThi.Properties.Resources.Screenshot_2021_11_14_001054;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Location = new System.Drawing.Point(0, 0);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(200, 67);
            this.btnBanHang.TabIndex = 0;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(206, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1101, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bán hàng";
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1225, 687);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.fThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnHoaDonBan;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHoaDonNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQLNguoiDung;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.ComboBox cbbQuy;
    }
}
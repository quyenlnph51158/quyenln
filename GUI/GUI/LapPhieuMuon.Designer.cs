namespace GUI
{
    partial class LapPhieuMuon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtMaPhieuMuon = new TextBox();
            label9 = new Label();
            txtSDT = new TextBox();
            label1 = new Label();
            txtMaDocGia = new TextBox();
            dgvPhieuMuon = new DataGridView();
            cbbmataikhoan = new ComboBox();
            label2 = new Label();
            btnhienthi = new Button();
            btnsua = new Button();
            btnTaoPhieuMuon = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dgvSach = new DataGridView();
            txtTimKiemSach = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            label8 = new Label();
            cbbPhieuMuon = new ComboBox();
            groupBox4 = new GroupBox();
            txtghichu = new TextBox();
            btnChiTiet = new Button();
            label10 = new Label();
            datengaytra = new DateTimePicker();
            label5 = new Label();
            dateNgaymuon = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            dgvPhieuChitiet = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChitiet).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaPhieuMuon);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaDocGia);
            groupBox1.Controls.Add(dgvPhieuMuon);
            groupBox1.Controls.Add(cbbmataikhoan);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnhienthi);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnTaoPhieuMuon);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 582);
            groupBox1.TabIndex = 144;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phiếu Mượn";
            // 
            // txtMaPhieuMuon
            // 
            txtMaPhieuMuon.Enabled = false;
            txtMaPhieuMuon.Location = new Point(152, 74);
            txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            txtMaPhieuMuon.Size = new Size(207, 27);
            txtMaPhieuMuon.TabIndex = 158;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(26, 72);
            label9.Name = "label9";
            label9.Size = new Size(120, 20);
            label9.TabIndex = 157;
            label9.Text = "Mã phiếu mượn";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(152, 178);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(207, 27);
            txtSDT.TabIndex = 156;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 176);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 155;
            label1.Text = "Số điện thoại";
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.Enabled = false;
            txtMaDocGia.Location = new Point(152, 226);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.Size = new Size(207, 27);
            txtMaDocGia.TabIndex = 154;
            txtMaDocGia.TextChanged += txtMaDocGia_TextChanged;
            // 
            // dgvPhieuMuon
            // 
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuon.Location = new Point(24, 310);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.RowHeadersWidth = 51;
            dgvPhieuMuon.Size = new Size(367, 225);
            dgvPhieuMuon.TabIndex = 153;
            dgvPhieuMuon.CellClick += dgvPhieuMuon_CellClick;
            // 
            // cbbmataikhoan
            // 
            cbbmataikhoan.FormattingEnabled = true;
            cbbmataikhoan.Location = new Point(152, 121);
            cbbmataikhoan.Name = "cbbmataikhoan";
            cbbmataikhoan.Size = new Size(207, 28);
            cbbmataikhoan.TabIndex = 152;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 224);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 150;
            label2.Text = "Tên Độc Giả";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(49, 269);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 149;
            btnhienthi.Text = "Clear";
            btnhienthi.UseVisualStyleBackColor = false;
            btnhienthi.Click += btnhienthi_Click;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(278, 269);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 148;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnTaoPhieuMuon
            // 
            btnTaoPhieuMuon.BackColor = Color.FromArgb(255, 192, 128);
            btnTaoPhieuMuon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaoPhieuMuon.Location = new Point(168, 269);
            btnTaoPhieuMuon.Name = "btnTaoPhieuMuon";
            btnTaoPhieuMuon.Size = new Size(94, 29);
            btnTaoPhieuMuon.TabIndex = 147;
            btnTaoPhieuMuon.Text = "Tạo";
            btnTaoPhieuMuon.UseVisualStyleBackColor = false;
            btnTaoPhieuMuon.Click += btnTaoPhieuMuon_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 124);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 145;
            label3.Text = "Tên nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSach);
            groupBox2.Controls.Add(txtTimKiemSach);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(1056, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(451, 588);
            groupBox2.TabIndex = 145;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Phiếu Mượn";
            // 
            // dgvSach
            // 
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(33, 76);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(403, 486);
            dgvSach.TabIndex = 155;
            dgvSach.CellDoubleClick += dgvSach_CellDoubleClick;
            // 
            // txtTimKiemSach
            // 
            txtTimKiemSach.Location = new Point(115, 21);
            txtTimKiemSach.Name = "txtTimKiemSach";
            txtTimKiemSach.PlaceholderText = "Tìm kiếm dựa theo tên sách";
            txtTimKiemSach.Size = new Size(321, 27);
            txtTimKiemSach.TabIndex = 154;
            txtTimKiemSach.TextChanged += txtTimKiemSach_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(33, 24);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 153;
            label4.Text = "Tìm Kiếm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(cbbPhieuMuon);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(btnChiTiet);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(datengaytra);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dateNgaymuon);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dgvPhieuChitiet);
            groupBox3.Location = new Point(472, 36);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(548, 582);
            groupBox3.TabIndex = 146;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách chọn";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(144, 502);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 156;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(19, 28);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 155;
            label8.Text = "Phiếu mượn";
            // 
            // cbbPhieuMuon
            // 
            cbbPhieuMuon.FormattingEnabled = true;
            cbbPhieuMuon.Location = new Point(144, 26);
            cbbPhieuMuon.Name = "cbbPhieuMuon";
            cbbPhieuMuon.Size = new Size(343, 28);
            cbbPhieuMuon.TabIndex = 154;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtghichu);
            groupBox4.Location = new Point(24, 422);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(420, 69);
            groupBox4.TabIndex = 147;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ghi Chú ";
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(6, 26);
            txtghichu.Multiline = true;
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(387, 37);
            txtghichu.TabIndex = 0;
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.FromArgb(255, 192, 128);
            btnChiTiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChiTiet.Location = new Point(448, 533);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(94, 29);
            btnChiTiet.TabIndex = 153;
            btnChiTiet.Text = "Tạo";
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(275, 505);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 134;
            label10.Text = "VND";
            // 
            // datengaytra
            // 
            datengaytra.Location = new Point(144, 378);
            datengaytra.Name = "datengaytra";
            datengaytra.Size = new Size(308, 27);
            datengaytra.TabIndex = 128;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(19, 376);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 127;
            label5.Text = "Ngày Ngày trả";
            // 
            // dateNgaymuon
            // 
            dateNgaymuon.Location = new Point(144, 331);
            dateNgaymuon.Name = "dateNgaymuon";
            dateNgaymuon.Size = new Size(308, 27);
            dateNgaymuon.TabIndex = 126;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(24, 505);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 125;
            label7.Text = "Tổng Tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(18, 336);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 124;
            label6.Text = "Ngày Mượn";
            // 
            // dgvPhieuChitiet
            // 
            dgvPhieuChitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuChitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuChitiet.Location = new Point(19, 69);
            dgvPhieuChitiet.Name = "dgvPhieuChitiet";
            dgvPhieuChitiet.RowHeadersWidth = 51;
            dgvPhieuChitiet.Size = new Size(468, 255);
            dgvPhieuChitiet.TabIndex = 0;
            dgvPhieuChitiet.CellClick += dgvPhieuChitiet_CellClick;
            // 
            // LapPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LapPhieuMuon";
            Size = new Size(1521, 648);
            Load += LapPhieuMuon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChitiet).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cbbmataikhoan;
        private Label label2;
        private Button btnhienthi;
        private Button btnsua;
        private Button btnTaoPhieuMuon;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtTimKiemSach;
        private Label label4;
        private DataGridView dgvSach;
        private GroupBox groupBox3;
        private DataGridView dgvPhieuChitiet;
        private Button btnChiTiet;
        private Label label10;
        private DateTimePicker datengaytra;
        private Label label5;
        private DateTimePicker dateNgaymuon;
        private Label label7;
        private Label label6;
        private GroupBox groupBox4;
        private TextBox txtghichu;
        private DataGridView dgvPhieuMuon;
        private Label label8;
        private ComboBox cbbPhieuMuon;
        private TextBox txtSDT;
        private Label label1;
        private TextBox txtMaDocGia;
        private TextBox txtMaPhieuMuon;
        private Label label9;
        private TextBox textBox1;
    }
}

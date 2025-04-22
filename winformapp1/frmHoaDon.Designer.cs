namespace WinFormsApp2
{
    partial class frmHoaDon
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
            label1 = new Label();
            txtMaHD = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMaPhong = new TextBox();
            txtSoChuDien = new TextBox();
            txtGiaDien = new TextBox();
            txtTienNuoc = new TextBox();
            NgayLap = new DateTimePicker();
            rbChuaTT = new RadioButton();
            rbDaTT = new RadioButton();
            txtTongTien = new TextBox();
            btnLuu = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 105);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phòng";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(189, 47);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(154, 27);
            txtMaHD.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 50);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 175);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "Số chữ điện";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 237);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 4;
            label4.Text = "Giá điện";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 291);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "Tiền nước";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 102);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 6;
            label6.Text = "Ngày lập hóa đơn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 265);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 7;
            label7.Text = "Tổng tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(397, 179);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 8;
            label8.Text = "Trạng thái thanh toán";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(189, 102);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(154, 27);
            txtMaPhong.TabIndex = 9;
            // 
            // txtSoChuDien
            // 
            txtSoChuDien.Location = new Point(189, 172);
            txtSoChuDien.Name = "txtSoChuDien";
            txtSoChuDien.Size = new Size(154, 27);
            txtSoChuDien.TabIndex = 10;
            // 
            // txtGiaDien
            // 
            txtGiaDien.Location = new Point(189, 230);
            txtGiaDien.Name = "txtGiaDien";
            txtGiaDien.Size = new Size(154, 27);
            txtGiaDien.TabIndex = 11;
            // 
            // txtTienNuoc
            // 
            txtTienNuoc.Location = new Point(189, 284);
            txtTienNuoc.Name = "txtTienNuoc";
            txtTienNuoc.Size = new Size(154, 27);
            txtTienNuoc.TabIndex = 12;
            // 
            // NgayLap
            // 
            NgayLap.Location = new Point(545, 100);
            NgayLap.Name = "NgayLap";
            NgayLap.Size = new Size(230, 27);
            NgayLap.TabIndex = 15;
            // 
            // rbChuaTT
            // 
            rbChuaTT.AutoSize = true;
            rbChuaTT.Location = new Point(589, 179);
            rbChuaTT.Name = "rbChuaTT";
            rbChuaTT.Size = new Size(139, 24);
            rbChuaTT.TabIndex = 16;
            rbChuaTT.TabStop = true;
            rbChuaTT.Text = "Chưa thanh toán";
            rbChuaTT.UseVisualStyleBackColor = true;
            // 
            // rbDaTT
            // 
            rbDaTT.AutoSize = true;
            rbDaTT.Location = new Point(735, 179);
            rbDaTT.Name = "rbDaTT";
            rbDaTT.Size = new Size(124, 24);
            rbDaTT.TabIndex = 17;
            rbDaTT.TabStop = true;
            rbDaTT.Text = "Đã thanh toán";
            rbDaTT.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(489, 265);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(172, 27);
            txtTongTien.TabIndex = 18;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.ForestGreen;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.Transparent;
            btnLuu.Location = new Point(563, 334);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(98, 33);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Gold;
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = SystemColors.ActiveCaptionText;
            btnCapNhat.Location = new Point(693, 334);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(98, 33);
            btnCapNhat.TabIndex = 20;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Location = new Point(815, 334);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 33);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 382);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(832, 206);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(748, 37);
            button1.Name = "button1";
            button1.Size = new Size(98, 33);
            button1.TabIndex = 23;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLoadDL_Click;
            // 
            // button2
            // 
            button2.Location = new Point(866, 37);
            button2.Name = "button2";
            button2.Size = new Size(98, 33);
            button2.TabIndex = 24;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnThoat_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(986, 613);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuu);
            Controls.Add(txtTongTien);
            Controls.Add(rbDaTT);
            Controls.Add(rbChuaTT);
            Controls.Add(NgayLap);
            Controls.Add(txtTienNuoc);
            Controls.Add(txtGiaDien);
            Controls.Add(txtSoChuDien);
            Controls.Add(txtMaPhong);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMaHD);
            Controls.Add(label1);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaHD;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMaPhong;
        private TextBox txtSoChuDien;
        private TextBox txtGiaDien;
        private TextBox txtTienNuoc;
        private DateTimePicker NgayLap;
        private RadioButton rbChuaTT;
        private RadioButton rbDaTT;
        private TextBox txtTongTien;
        private Button btnLuu;
        private Button btnCapNhat;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}
namespace WinFormsApp2
{
    partial class frmHoaDonKhachHang
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
            label2 = new Label();
            label8 = new Label();
            txtMaPhong = new TextBox();
            txtTongTien = new TextBox();
            dataGridView1 = new DataGridView();
            btnXem = new Button();
            txtMaHD = new TextBox();
            rbChuaTT = new RadioButton();
            rbDaTT = new RadioButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 106);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phòng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(504, 197);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 7;
            label8.Text = "Tổng tiền";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(228, 99);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(172, 27);
            txtMaPhong.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(582, 190);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(172, 27);
            txtTongTien.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 334);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(790, 171);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(579, 290);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(111, 34);
            btnXem.TabIndex = 18;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(228, 149);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(172, 27);
            txtMaHD.TabIndex = 19;
            // 
            // rbChuaTT
            // 
            rbChuaTT.AutoSize = true;
            rbChuaTT.Location = new Point(582, 99);
            rbChuaTT.Name = "rbChuaTT";
            rbChuaTT.Size = new Size(139, 24);
            rbChuaTT.TabIndex = 20;
            rbChuaTT.TabStop = true;
            rbChuaTT.Text = "Chưa thanh toán";
            rbChuaTT.UseVisualStyleBackColor = true;
            // 
            // rbDaTT
            // 
            rbDaTT.AutoSize = true;
            rbDaTT.Location = new Point(727, 99);
            rbDaTT.Name = "rbDaTT";
            rbDaTT.Size = new Size(124, 24);
            rbDaTT.TabIndex = 21;
            rbDaTT.TabStop = true;
            rbDaTT.Text = "Đã thanh toán";
            rbDaTT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 152);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 22;
            label1.Text = "Mã hóa đơn";
            // 
            // frmHoaDonKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 517);
            Controls.Add(label1);
            Controls.Add(rbDaTT);
            Controls.Add(rbChuaTT);
            Controls.Add(txtMaHD);
            Controls.Add(btnXem);
            Controls.Add(dataGridView1);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaPhong);
            Controls.Add(label8);
            Controls.Add(label2);
            Name = "frmHoaDonKhachHang";
            Text = "frmHoaDonKhachHang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label8;
        private TextBox txtMaPhong;
        private TextBox txtTongTien;
        private DataGridView dataGridView1;
        private Button btnXem;
        private TextBox txtMaHD;
        private RadioButton rbChuaTT;
        private RadioButton rbDaTT;
        private Label label1;
    }
}
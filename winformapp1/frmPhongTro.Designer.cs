namespace WinFormsApp2
{
    partial class frmPhongTro
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaPhong = new TextBox();
            txtGiaPhong = new TextBox();
            txtDienTich = new TextBox();
            txtSoLuongKhach = new TextBox();
            dataGridView1 = new DataGridView();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            cbTinhTrang = new ComboBox();
            btnFilter = new Button();
            label7 = new Label();
            btnThoat = new Button();
            rbTrong = new RadioButton();
            rbThue = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 72);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 126);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "Tình trạng phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 163);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Số khách thuê";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 251);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 4;
            label5.Text = "Diện tích";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 202);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Giá phòng";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(250, 69);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(172, 27);
            txtMaPhong.TabIndex = 0;
            // 
            // txtGiaPhong
            // 
            txtGiaPhong.Location = new Point(250, 202);
            txtGiaPhong.Name = "txtGiaPhong";
            txtGiaPhong.Size = new Size(172, 27);
            txtGiaPhong.TabIndex = 3;
            // 
            // txtDienTich
            // 
            txtDienTich.Location = new Point(250, 248);
            txtDienTich.Name = "txtDienTich";
            txtDienTich.Size = new Size(172, 27);
            txtDienTich.TabIndex = 4;
            // 
            // txtSoLuongKhach
            // 
            txtSoLuongKhach.Location = new Point(250, 163);
            txtSoLuongKhach.Name = "txtSoLuongKhach";
            txtSoLuongKhach.Size = new Size(172, 27);
            txtSoLuongKhach.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 364);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(738, 197);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.ForestGreen;
            btnLuu.Location = new Point(366, 304);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(99, 37);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Goldenrod;
            btnSua.Location = new Point(484, 304);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(108, 37);
            btnSua.TabIndex = 6;
            btnSua.Text = "Cập Nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(625, 304);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 37);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // cbTinhTrang
            // 
            cbTinhTrang.FormattingEnabled = true;
            cbTinhTrang.Location = new Point(712, 137);
            cbTinhTrang.Name = "cbTinhTrang";
            cbTinhTrang.Size = new Size(128, 28);
            cbTinhTrang.TabIndex = 14;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.ForestGreen;
            btnFilter.Location = new Point(755, 193);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(85, 29);
            btnFilter.TabIndex = 16;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(534, 142);
            label7.Name = "label7";
            label7.Size = new Size(172, 23);
            label7.TabIndex = 17;
            label7.Text = "Lọc tình trạng phòng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(750, 39);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(81, 34);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // rbTrong
            // 
            rbTrong.AutoSize = true;
            rbTrong.Location = new Point(252, 127);
            rbTrong.Name = "rbTrong";
            rbTrong.Size = new Size(96, 24);
            rbTrong.TabIndex = 19;
            rbTrong.TabStop = true;
            rbTrong.Text = "Còn trống";
            rbTrong.UseVisualStyleBackColor = true;
            // 
            // rbThue
            // 
            rbThue.AutoSize = true;
            rbThue.Location = new Point(375, 127);
            rbThue.Name = "rbThue";
            rbThue.Size = new Size(99, 24);
            rbThue.TabIndex = 20;
            rbThue.TabStop = true;
            rbThue.Text = "Đang thuê";
            rbThue.UseVisualStyleBackColor = true;
            // 
            // frmPhongTro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(866, 573);
            Controls.Add(rbThue);
            Controls.Add(rbTrong);
            Controls.Add(btnThoat);
            Controls.Add(label7);
            Controls.Add(btnFilter);
            Controls.Add(cbTinhTrang);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(dataGridView1);
            Controls.Add(txtSoLuongKhach);
            Controls.Add(txtDienTich);
            Controls.Add(txtGiaPhong);
            Controls.Add(txtMaPhong);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmPhongTro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPhongTro";
            Load += frmPhongTro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaPhong;
        private TextBox txtGiaPhong;
        private TextBox txtDienTich;
        private TextBox txtSoLuongKhach;
        private DataGridView dataGridView1;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private ListBox listBox1;
        private ListBox listBox2;
        private ComboBox cbTinhTrang;
        private Button btnFilter;
        private Label label7;
        private Button btnThoat;
        private RadioButton rbTrong;
        private RadioButton rbThue;
    }
}
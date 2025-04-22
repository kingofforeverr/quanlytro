namespace WinFormsApp2
{
    partial class frmKhachHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCanCuoc = new TextBox();
            label2 = new Label();
            txtTenKH = new TextBox();
            label3 = new Label();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnLuu = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            btnSua = new Button();
            btnThoat = new Button();
            label6 = new Label();
            txtQueQuan = new TextBox();
            label7 = new Label();
            txtMaPhong = new TextBox();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 94);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "CCCD";
            // 
            // txtCanCuoc
            // 
            txtCanCuoc.Location = new Point(187, 91);
            txtCanCuoc.Name = "txtCanCuoc";
            txtCanCuoc.Size = new Size(145, 27);
            txtCanCuoc.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 142);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên khách thuê";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(187, 142);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(145, 27);
            txtTenKH.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 195);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(187, 195);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(145, 27);
            txtSoDienThoai.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(371, 94);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Giới tính";
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(464, 90);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 24);
            rbNam.TabIndex = 7;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(543, 90);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 8;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(371, 149);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 9;
            label5.Text = "Ngày Sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(464, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.ForestGreen;
            btnLuu.Location = new Point(278, 330);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(111, 40);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(565, 330);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(111, 40);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 394);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(717, 202);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Goldenrod;
            btnSua.Location = new Point(423, 330);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(111, 40);
            btnSua.TabIndex = 14;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(751, 42);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(89, 34);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(374, 202);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 16;
            label6.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(464, 195);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(274, 27);
            txtQueQuan.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(67, 245);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 18;
            label7.Text = "Mã phòng";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(187, 245);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(145, 27);
            txtMaPhong.TabIndex = 19;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.ForestGreen;
            btnLoad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.Ivory;
            btnLoad.Location = new Point(739, 245);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(101, 38);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Làm mới";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(865, 629);
            Controls.Add(btnLoad);
            Controls.Add(txtMaPhong);
            Controls.Add(label7);
            Controls.Add(txtQueQuan);
            Controls.Add(label6);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(rbNu);
            Controls.Add(rbNam);
            Controls.Add(label4);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label3);
            Controls.Add(txtTenKH);
            Controls.Add(label2);
            Controls.Add(txtCanCuoc);
            Controls.Add(label1);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            FormClosing += frmKhachHang_FormClosing;
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCanCuoc;
        private Label label2;
        private TextBox txtTenKH;
        private Label label3;
        private TextBox txtSoDienThoai;
        private Label label4;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button btnLuu;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private Button btnSua;
        private Button btnThoat;
        private Label label6;
        private TextBox txtQueQuan;
        private Label label7;
        private TextBox txtMaPhong;
        private Button btnLoad;
    }
}

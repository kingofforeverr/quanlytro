namespace WinFormsApp2
{
    partial class frmTaiKhoan
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
            txtTenDN = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtMatKhau = new TextBox();
            label4 = new Label();
            btnTao = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            btnThoat = new Button();
            btnLammoi = new Button();
            rbKhach = new RadioButton();
            rbadmin = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 32);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 0;
            label1.Text = "Quản lý tài khoản";
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(234, 99);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(172, 27);
            txtTenDN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 102);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 162);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(234, 155);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(172, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(104, 217);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 5;
            label4.Text = "Vai trò";
            // 
            // btnTao
            // 
            btnTao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTao.ForeColor = Color.ForestGreen;
            btnTao.Location = new Point(303, 276);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(129, 44);
            btnTao.TabIndex = 7;
            btnTao.Text = "Tạo tài khoản";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Goldenrod;
            btnSua.Location = new Point(460, 276);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 44);
            btnSua.TabIndex = 8;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(620, 276);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 44);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 367);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(635, 157);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(684, 55);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(104, 41);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLammoi
            // 
            btnLammoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLammoi.ForeColor = Color.ForestGreen;
            btnLammoi.Location = new Point(551, 55);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(104, 41);
            btnLammoi.TabIndex = 12;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // rbKhach
            // 
            rbKhach.AutoSize = true;
            rbKhach.Location = new Point(329, 217);
            rbKhach.Name = "rbKhach";
            rbKhach.Size = new Size(103, 24);
            rbKhach.TabIndex = 13;
            rbKhach.TabStop = true;
            rbKhach.Text = "Khách thuê";
            rbKhach.UseVisualStyleBackColor = true;
            // 
            // rbadmin
            // 
            rbadmin.AutoSize = true;
            rbadmin.Location = new Point(234, 217);
            rbadmin.Name = "rbadmin";
            rbadmin.Size = new Size(78, 24);
            rbadmin.TabIndex = 14;
            rbadmin.TabStop = true;
            rbadmin.Text = "Chủ trọ";
            rbadmin.UseVisualStyleBackColor = true;
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 536);
            Controls.Add(rbadmin);
            Controls.Add(rbKhach);
            Controls.Add(btnLammoi);
            Controls.Add(btnThoat);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnTao);
            Controls.Add(label4);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenDN);
            Controls.Add(label1);
            Name = "frmTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTaiKhoan";
            Load += frmTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenDN;
        private Label label2;
        private Label label3;
        private TextBox txtMatKhau;
        private Label label4;
        private Button btnTao;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private Button btnThoat;
        private Button btnLammoi;
        private RadioButton rbKhach;
        private RadioButton rbadmin;
    }
}
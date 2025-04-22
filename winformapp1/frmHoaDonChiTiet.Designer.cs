namespace WinFormsApp2
{
    partial class frmHoaDonChiTiet
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaHD = new TextBox();
            txtMaDV = new TextBox();
            txtSoLuong = new TextBox();
            txtThanhTien = new TextBox();
            dataGridView1 = new DataGridView();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 73);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 120);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 170);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 170);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "Thành tiền";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(179, 66);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(166, 27);
            txtMaHD.TabIndex = 4;
            // 
            // txtMaDV
            // 
            txtMaDV.Location = new Point(179, 113);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(166, 27);
            txtMaDV.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(179, 170);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(166, 27);
            txtSoLuong.TabIndex = 6;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(545, 163);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(140, 27);
            txtThanhTien.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(690, 178);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(321, 232);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 32);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(453, 232);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 32);
            btnSua.TabIndex = 10;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(585, 232);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 32);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // button1
            // 
            button1.Location = new Point(682, 31);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 12;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThoat_Click;
            // 
            // button2
            // 
            button2.Location = new Point(569, 31);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 13;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnLoadDL_Click;
            // 
            // frmHoaDonChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 469);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(dataGridView1);
            Controls.Add(txtThanhTien);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaDV);
            Controls.Add(txtMaHD);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmHoaDonChiTiet";
            Text = "frmHoaDonChiTiet";
            Load += frmHoaDonChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaHD;
        private TextBox txtMaDV;
        private TextBox txtSoLuong;
        private TextBox txtThanhTien;
        private DataGridView dataGridView1;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button button1;
        private Button button2;
    }
}
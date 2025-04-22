namespace WinFormsApp2
{
    partial class frmDichVu
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
            txtMaDV = new TextBox();
            txtGiaDV = new TextBox();
            txtTenDV = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLuu = new Button();
            btnCapNhat = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            btnLoadDL = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 76);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã dịch vụ";
            // 
            // txtMaDV
            // 
            txtMaDV.Location = new Point(163, 69);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(122, 27);
            txtMaDV.TabIndex = 1;
            // 
            // txtGiaDV
            // 
            txtGiaDV.Location = new Point(163, 185);
            txtGiaDV.Name = "txtGiaDV";
            txtGiaDV.Size = new Size(122, 27);
            txtGiaDV.TabIndex = 2;
            // 
            // txtTenDV
            // 
            txtTenDV.Location = new Point(163, 131);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(122, 27);
            txtTenDV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 192);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Giá dịch vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 131);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Tên dịch vụ";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(153, 258);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(89, 31);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(300, 258);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(89, 31);
            btnCapNhat.TabIndex = 7;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // button3
            // 
            button3.Location = new Point(438, 258);
            button3.Name = "button3";
            button3.Size = new Size(89, 31);
            button3.TabIndex = 8;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(645, 174);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // btnLoadDL
            // 
            btnLoadDL.Location = new Point(506, 41);
            btnLoadDL.Name = "btnLoadDL";
            btnLoadDL.Size = new Size(86, 31);
            btnLoadDL.TabIndex = 10;
            btnLoadDL.Text = "Làm mới";
            btnLoadDL.UseVisualStyleBackColor = true;
            btnLoadDL.Click += btnLoadDL_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(616, 41);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 31);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 497);
            Controls.Add(btnThoat);
            Controls.Add(btnLoadDL);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenDV);
            Controls.Add(txtGiaDV);
            Controls.Add(txtMaDV);
            Controls.Add(label1);
            Name = "frmDichVu";
            Text = "frmDichVu";
            Load += frmDichVu_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaDV;
        private TextBox txtGiaDV;
        private TextBox txtTenDV;
        private Label label2;
        private Label label3;
        private Button btnLuu;
        private Button btnCapNhat;
        private Button button3;
        private DataGridView dataGridView1;
        private Button btnLoadDL;
        private Button btnThoat;
    }
}
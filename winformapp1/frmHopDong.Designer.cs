namespace WinFormsApp2
{
    partial class frmHopDong
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
            label5 = new Label();
            txtMaHopDong = new TextBox();
            txtTienCoc = new TextBox();
            txtMaPhong = new TextBox();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            txtNgayDen = new DateTimePicker();
            txtNgayDi = new DateTimePicker();
            button4 = new Button();
            btnXem = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 61);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hợp đồng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 123);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày đến";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 167);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày đi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 209);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Số tiền cọc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 257);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Mã phòng";
            // 
            // txtMaHopDong
            // 
            txtMaHopDong.Location = new Point(193, 58);
            txtMaHopDong.Name = "txtMaHopDong";
            txtMaHopDong.Size = new Size(248, 27);
            txtMaHopDong.TabIndex = 5;
            // 
            // txtTienCoc
            // 
            txtTienCoc.Location = new Point(193, 209);
            txtTienCoc.Name = "txtTienCoc";
            txtTienCoc.Size = new Size(248, 27);
            txtTienCoc.TabIndex = 8;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(193, 254);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(248, 27);
            txtMaPhong.TabIndex = 9;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.ForestGreen;
            btnLuu.Location = new Point(394, 303);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(84, 34);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Thêm";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Goldenrod;
            btnSua.Location = new Point(507, 303);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 34);
            btnSua.TabIndex = 11;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(625, 303);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 34);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 356);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(656, 171);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtNgayDen
            // 
            txtNgayDen.Location = new Point(193, 118);
            txtNgayDen.Name = "txtNgayDen";
            txtNgayDen.Size = new Size(248, 27);
            txtNgayDen.TabIndex = 14;
            // 
            // txtNgayDi
            // 
            txtNgayDi.Location = new Point(193, 167);
            txtNgayDi.Name = "txtNgayDi";
            txtNgayDi.Size = new Size(248, 27);
            txtNgayDi.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.ForestGreen;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Ivory;
            button4.Location = new Point(567, 54);
            button4.Name = "button4";
            button4.Size = new Size(84, 34);
            button4.TabIndex = 16;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnXem
            // 
            btnXem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXem.ForeColor = Color.ForestGreen;
            btnXem.Location = new Point(272, 303);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(84, 34);
            btnXem.TabIndex = 17;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(666, 54);
            button1.Name = "button1";
            button1.Size = new Size(104, 34);
            button1.TabIndex = 18;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 554);
            Controls.Add(button1);
            Controls.Add(btnXem);
            Controls.Add(button4);
            Controls.Add(txtNgayDi);
            Controls.Add(txtNgayDen);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(txtMaPhong);
            Controls.Add(txtTienCoc);
            Controls.Add(txtMaHopDong);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmHopDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHopDong";
            Load += frmHopDong_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaHopDong;
        private TextBox txtTienCoc;
        private TextBox txtMaPhong;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private DateTimePicker txtNgayDen;
        private DateTimePicker txtNgayDi;
        private Button button4;
        private Button btnXem;
        private Button button1;
    }
}
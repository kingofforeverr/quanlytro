namespace WinFormsApp2
{
    partial class frmHopDongKhach
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
            txtMaPhong = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnThoat = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMaPhong
            // 
            txtMaPhong.BackColor = Color.WhiteSmoke;
            txtMaPhong.BorderStyle = BorderStyle.FixedSingle;
            txtMaPhong.Location = new Point(313, 123);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(151, 27);
            txtMaPhong.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(693, 139);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(454, 205);
            button1.Name = "button1";
            button1.Size = new Size(107, 33);
            button1.TabIndex = 2;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(660, 42);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 33);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 130);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã phòng";
            // 
            // frmHopDongKhach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtMaPhong);
            Name = "frmHopDongKhach";
            Text = "frmHopDongKhach";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaPhong;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnThoat;
        private Label label1;
    }
}
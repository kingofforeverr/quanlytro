namespace WinFormsApp2
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            quảnLýPhòngTrọToolStripMenuItem = new ToolStripMenuItem();
            quảnLýDịchVụToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnChiTiếtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHợpĐồngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýKháchHàngToolStripMenuItem, quảnLýPhòngTrọToolStripMenuItem, quảnLýDịchVụToolStripMenuItem, quảnLýHóaĐơnToolStripMenuItem, quảnLýTàiKhoảnToolStripMenuItem, quảnLýHợpĐồngToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1050, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem });
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(152, 24);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.Size = new Size(159, 26);
            thêmMớiToolStripMenuItem.Text = "Thêm mới";
            // 
            // quảnLýPhòngTrọToolStripMenuItem
            // 
            quảnLýPhòngTrọToolStripMenuItem.Name = "quảnLýPhòngTrọToolStripMenuItem";
            quảnLýPhòngTrọToolStripMenuItem.Size = new Size(143, 24);
            quảnLýPhòngTrọToolStripMenuItem.Text = "Quản lý phòng trọ";
            quảnLýPhòngTrọToolStripMenuItem.Click += quảnLýPhòngTrọToolStripMenuItem_Click;
            // 
            // quảnLýDịchVụToolStripMenuItem
            // 
            quảnLýDịchVụToolStripMenuItem.Name = "quảnLýDịchVụToolStripMenuItem";
            quảnLýDịchVụToolStripMenuItem.Size = new Size(124, 24);
            quảnLýDịchVụToolStripMenuItem.Text = "Quản lý dịch vụ";
            quảnLýDịchVụToolStripMenuItem.Click += quảnLýDịchVụToolStripMenuItem_Click;
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hóaĐơnToolStripMenuItem, hóaĐơnChiTiếtToolStripMenuItem });
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(132, 24);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            quảnLýHóaĐơnToolStripMenuItem.Click += quảnLýHóaĐơnToolStripMenuItem_Click;
            // 
            // hóaĐơnChiTiếtToolStripMenuItem
            // 
            hóaĐơnChiTiếtToolStripMenuItem.Name = "hóaĐơnChiTiếtToolStripMenuItem";
            hóaĐơnChiTiếtToolStripMenuItem.Size = new Size(224, 26);
            hóaĐơnChiTiếtToolStripMenuItem.Text = "Hóa đơn chi tiết";
            hóaĐơnChiTiếtToolStripMenuItem.Click += hóaĐơnChiTiếtToolStripMenuItem_Click;
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            quảnLýTàiKhoảnToolStripMenuItem.Size = new Size(138, 24);
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            quảnLýTàiKhoảnToolStripMenuItem.Click += quảnLýTàiKhoảnToolStripMenuItem_Click;
            // 
            // quảnLýHợpĐồngToolStripMenuItem
            // 
            quảnLýHợpĐồngToolStripMenuItem.Name = "quảnLýHợpĐồngToolStripMenuItem";
            quảnLýHợpĐồngToolStripMenuItem.Size = new Size(142, 24);
            quảnLýHợpĐồngToolStripMenuItem.Text = "Quản lý hợp đồng";
            quảnLýHợpĐồngToolStripMenuItem.Click += quảnLýHợpĐồngToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(91, 24);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(224, 26);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1050, 530);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            FormClosed += frmMain_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem quảnLýPhòngTrọToolStripMenuItem;
        private ToolStripMenuItem quảnLýDịchVụToolStripMenuItem;
        private ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýHợpĐồngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnChiTiếtToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
    }
}
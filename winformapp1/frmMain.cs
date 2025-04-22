using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaculator maytinnh = new frmCaculator();
            //maytinnh.MdiParent = this;
            maytinnh.Show();
            this.Hide();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
            this.Hide();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan acc = new frmTaiKhoan();
            acc.Show();
            this.Hide();
        }

        private void quảnLýPhòngTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongTro phong = new frmPhongTro();
            phong.Show();
            this.Hide();

        }

        private void quảnLýHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHopDong hopdong = new frmHopDong();
            hopdong.Show();
            this.Hide();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDangNhap a = new frmDangNhap();
            a.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap a = new frmDangNhap();
            a.Show();
            this.Hide();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVu dichVu = new frmDichVu();
            dichVu.Show();
            this.Hide();
        }

        private void hóaĐơnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonChiTiet hoadonchitiet = new frmHoaDonChiTiet();
            hoadonchitiet.Show();
            this.Hide();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon hoadon = new frmHoaDon();
            hoadon.Show();
            this.Hide();
        }
    }
}

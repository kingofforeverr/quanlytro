using Microsoft.Data.SqlClient;
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
    public partial class frmHoaDonKhachHang : Form
    {

        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public frmHoaDonKhachHang()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Kết nối DB
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                string maPhong = txtMaPhong.Text.Trim();
                string sQuery;

                if (!string.IsNullOrEmpty(maPhong))
                {
                    // Lấy dữ liệu theo mã phòng
                    sQuery = "SELECT * FROM HoaDon WHERE MaPhong = @MaPhong";
                }
                else
                {
                    // Lấy tất cả dữ liệu
                    sQuery = "SELECT * FROM HoaDon";
                }

                // Chuẩn bị lệnh SQL
                SqlCommand cmd = new SqlCommand(sQuery, con);
                if (!string.IsNullOrEmpty(maPhong))
                {
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Đổ dữ liệu vào DataSet
                DataSet ds = new DataSet();
                adapter.Fill(ds, "HoaDon");

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = ds.Tables["HoaDon"];

                con.Open();

                // Lấy dữ liệu
               
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình tải dữ liệu.");
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
            txtTongTien.Text = dataGridView1.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();
            txtMaPhong.Text = dataGridView1.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
            //txtMaHD.Enabled = false;
            string iTrangThai = dataGridView1.Rows[e.RowIndex].Cells["TrangThaiThanhToan"].Value.ToString();
            if (iTrangThai == "Chưa thanh toán")
            {
                rbChuaTT.Checked = true;
            }
            else
            {
                rbDaTT.Checked = true;
            }
        }
    }
}

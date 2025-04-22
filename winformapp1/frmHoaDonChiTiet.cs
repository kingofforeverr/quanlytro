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
    public partial class frmHoaDonChiTiet : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public frmHoaDonChiTiet()
        {
            InitializeComponent();
        }

        private void frmHoaDonChiTiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Xin chào và hẹn gặp lại!", "Thông báo");
        }
        private void frmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Kết nối DB
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();

                // Lấy dữ liệu
                string sQuery = "SELECT * FROM HoaDonChiTiet";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "HoaDonChiTiet");

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = ds.Tables["HoaDonChiTiet"];
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Khởi tạo kết nối
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return;
            }

            // Chuẩn bị dữ liệu
            string sMaHD = txtMaHD.Text;
            // Kiểm tra nếu mã hóa đơn không tồn tại tồn tại
            string checkQuery1 = "SELECT COUNT(*) FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            SqlCommand checkCmd1 = new SqlCommand(checkQuery1, con);
            checkCmd1.Parameters.AddWithValue("@MaHoaDon", sMaHD);

            int count1 = (int)checkCmd1.ExecuteScalar();
            if (count1 < 1)
            {
                MessageBox.Show("Mã hóa đơn không tồn tại. Vui lòng nhập mã khác.");
                con.Close();
                return;
            }

            // Chuẩn bị dữ liệu
            string sMaDV = txtMaDV.Text;
            // Kiểm tra nếu mã dịch vụ không tồn tại trong bảng dịch vụ
            string checkQuery2 = "SELECT COUNT(*) FROM DichVu WHERE MaDichVu = @MaDichVu";
            SqlCommand checkCmd2 = new SqlCommand(checkQuery2, con);
            checkCmd2.Parameters.AddWithValue("@MaDichVu", sMaDV);

            int count2 = (int)checkCmd2.ExecuteScalar();
            if (count2 < 1)
            {
                MessageBox.Show("Mã dịch vụ không tồn tại. Vui lòng nhập mã khác.");
                con.Close();
                return;
            }
            int iSoLuong = int.Parse(txtSoLuong.Text);

            // Câu lệnh SQL
            string sQuery = @"
                            IF EXISTS (SELECT 1 FROM HoaDonChiTiet WHERE MaHoaDon = @MaHoaDon AND MaDichVu = @MaDichVu)
                            BEGIN
                                UPDATE HoaDonChiTiet
                                SET SoLuong = SoLuong + @SoLuong
                                WHERE MaHoaDon = @MaHoaDon AND MaDichVu = @MaDichVu
                            END
                            ELSE
                            BEGIN
                                INSERT INTO HoaDonChiTiet(MaHoaDon, MaDichVu, SoLuong) VALUES (@MaHoaDon, @MaDichVu, @SoLuong)
                            END";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số
            cmd.Parameters.AddWithValue("@MaHoaDon", sMaHD);
            cmd.Parameters.AddWithValue("@MaDichVu", sMaDV);
            cmd.Parameters.AddWithValue("@SoLuong", iSoLuong);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");

                // Tải lại dữ liệu
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới.");
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
            txtMaDV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
            txtSoLuong.Text = dataGridView1.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtThanhTien.Text = dataGridView1.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
            //txtMaKH.Enabled = false;
        }

        private void btnSuu_Click(object sender, EventArgs e)
        {
            // Khởi tạo kết nối
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return;
            }

            // Chuẩn bị dữ liệu
            string sMaHD = txtMaHD.Text;
            string sMaDV = txtMaDV.Text;
            int iSoLuong = int.Parse(txtSoLuong.Text);

            // Câu lệnh SQL
            string sQuery = "UPDATE HoaDonChiTiet SET SoLuong = @SoLuong " +
                            "WHERE MaHoaDon = @MaHoaDon AND MaDichVu = @MaDichVu";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số
            cmd.Parameters.AddWithValue("@MaHoaDon", sMaHD);
            cmd.Parameters.AddWithValue("@MaDichVu", sMaDV);
            cmd.Parameters.AddWithValue("@SoLuong", iSoLuong);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");

                // Tải lại dữ liệu
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật.");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi trong quá trình kết nối DB");
            }

            string sMaHD = txtMaHD.Text;
            string sMaDV = txtMaDV.Text;

            string sQuery = "delete from HoaDonChiTiet where MaHoaDon=@MaHoaDon and MaDichVu=@MaDichVu";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@MaHoaDon", sMaHD);
            cmd.Parameters.AddWithValue("@MaDichVu", sMaDV);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin thành công");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi trong quá trình xóa thông tin.");

            }
            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();

            // Đóng form admin hiện tại
            this.Close();
        }

        private void btnLoadDL_Click(object sender, EventArgs e)
        {
            txtMaDV.Clear();
            txtMaHD.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
            LoadData();
        }
    }
}
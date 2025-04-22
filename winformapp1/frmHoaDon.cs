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
    public partial class frmHoaDon : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Xin chào và hẹn gặp lại!", "Thông báo");
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
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
                string sQuery = "SELECT * FROM HoaDon";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "HoaDon");

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = ds.Tables["HoaDon"];
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
            // Kiểm tra nếu mã khách hàng đã tồn tại
            string checkQuery1 = "SELECT COUNT(*) FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            SqlCommand checkCmd1 = new SqlCommand(checkQuery1, con);
            checkCmd1.Parameters.AddWithValue("@MaHoaDon", sMaHD);

            int count1 = (int)checkCmd1.ExecuteScalar();
            if (count1 > 0)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại. Vui lòng nhập mã khác.");
                con.Close();
                return;
            }
            string sSoChuDien = txtSoChuDien.Text;
            int iSoChuDien = int.Parse(sSoChuDien);
            string sGiaDien = txtGiaDien.Text;
            decimal dGiaDien = Convert.ToDecimal(sGiaDien);
            string sTienNuoc = txtTienNuoc.Text;
            decimal dTienNuoc = Convert.ToDecimal(sTienNuoc);
            string sNgayLap = NgayLap.Value.ToString("yyyy-MM-dd");
            string iTrangThai = rbChuaTT.Checked ? "Chưa thanh toán" : "Đã thanh toán";
            string sMaPhong = txtMaPhong.Text;
            // Kiểm tra nếu mã phòng không tồn tại
            string checkQuery2 = "SELECT COUNT(*) FROM PhongTro WHERE MaPhong = @MaPhong";
            SqlCommand checkCmd2 = new SqlCommand(checkQuery2, con);
            checkCmd2.Parameters.AddWithValue("@MaPhong", sMaPhong);

            int count2 = (int)checkCmd2.ExecuteScalar();
            if (count2 < 1)
            {
                MessageBox.Show("Mã phòng trọ không tồn tại. Vui lòng nhập mã khác.");
                con.Close();
                return;
            }
            // Câu lệnh SQL
            string sQuery = "INSERT INTO HoaDon(MaHoaDon, SoChuDien, GiaDien, TienNuoc, NgayLapHoaDon, TrangThaiThanhToan, MaPhong) VALUES (@MaHoaDon, @SoChuDien, @GiaDien, @TienNuoc, @NgayLap, @TrangThai, @MaPhong)";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số
            cmd.Parameters.AddWithValue("@MaHoaDon", sMaHD);
            cmd.Parameters.AddWithValue("@SoChuDien", iSoChuDien);
            cmd.Parameters.AddWithValue("@GiaDien", dGiaDien);
            cmd.Parameters.AddWithValue("@TienNuoc", dTienNuoc);
            cmd.Parameters.AddWithValue("@NgayLap", sNgayLap);
            cmd.Parameters.AddWithValue("@TrangThai", iTrangThai);
            cmd.Parameters.AddWithValue("@MaPhong", sMaPhong);

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
            if (e.RowIndex < 0)
            {
                return;
            }

            txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
            txtSoChuDien.Text = dataGridView1.Rows[e.RowIndex].Cells["SoChuDien"].Value.ToString();
            txtGiaDien.Text = dataGridView1.Rows[e.RowIndex].Cells["GiaDien"].Value.ToString();
            txtTienNuoc.Text = dataGridView1.Rows[e.RowIndex].Cells["TienNuoc"].Value.ToString();
            txtTongTien.Text = dataGridView1.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();
            NgayLap.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayLapHoaDon"].Value);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
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

            string sMaHD = txtMaHD.Text;
            string sSoChuDien = txtSoChuDien.Text;
            string sGiaDien = txtGiaDien.Text;
            string sTienNuoc = txtTienNuoc.Text;
            string sNgayLap = NgayLap.Value.ToString("yyyy-MM-dd");
            string iTrangThai = rbChuaTT.Checked ? "Chưa thanh toán" : "Đã thanh toán"; ;
            string sMaPhong = txtMaPhong.Text;
            string sQuery = "UPDATE HoaDon SET SoChuDien = @SoChuDien, GiaDien = @GiaDien, " +
                            "TienNuoc = @TienNuoc, NgayLapHoaDon = @NgayLap, TrangThaiThanhToan=@TrangThai,MaPhong=@MaPhong " +
                            "WHERE MaHoaDon = @MaHoaDon";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHoaDon", sMaHD);
            cmd.Parameters.AddWithValue("@SoChuDien", sSoChuDien);
            cmd.Parameters.AddWithValue("@GiaDien", sGiaDien);
            cmd.Parameters.AddWithValue("@TienNuoc", sTienNuoc);
            cmd.Parameters.AddWithValue("@NgayLap", sNgayLap);
            cmd.Parameters.AddWithValue("@TrangThai", iTrangThai);
            cmd.Parameters.AddWithValue("@MaPhong", sMaPhong);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                LoadData(); // Tải lại dữ liệu sau khi cập nhật
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

            string sQuery = "delete from HoaDon where MaHoaDon=@MaHoaDon";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@MaHoaDon", sMaHD);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin hóa đơn thành công");
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
            txtMaHD.Clear();
            txtGiaDien.Clear();
            txtMaPhong.Clear();
            txtSoChuDien.Clear();
            txtTienNuoc.Clear();
            NgayLap.Value = DateTime.Now;
            rbChuaTT.Checked = false;
            rbDaTT.Checked = false;
            txtTongTien.Clear();
            LoadData();
        }
    }
}
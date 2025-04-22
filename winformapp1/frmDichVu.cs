using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmDichVu : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Xin chào và hẹn gặp lại!", "Thông báo");
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
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
            string sMaDV = txtMaDV.Text;
            string sTenDV = txtTenDV.Text;
            string sGiaDV = txtGiaDV.Text;
            if (string.IsNullOrWhiteSpace(sMaDV) || string.IsNullOrWhiteSpace(sTenDV) || string.IsNullOrWhiteSpace(sGiaDV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                con.Close();
                return;
            }
            // Kiểm tra nếu mã khách hàng đã tồn tại
            string checkQuery = "SELECT COUNT(*) FROM DichVu WHERE MaDichVu = @MaDichVu";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@MaDichVu", sMaDV);

            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Mã dịch vụ đã tồn tại. Vui lòng nhập mã khác.");
                con.Close();
                return;
            }
            
            decimal dGia = decimal.Parse(sGiaDV);
            if (dGia <=0)
            {
                MessageBox.Show("Giá phòng không được âm");
                con.Close();
                return;
            }
            // Câu lệnh SQL
            string sQuery = "INSERT INTO DichVu VALUES (@MaDichVu, @TenDichVu, @GiaDichVu)";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số
            cmd.Parameters.AddWithValue("@MaDichVu", sMaDV);
            cmd.Parameters.AddWithValue("@TenDichVu", sTenDV);
            cmd.Parameters.AddWithValue("@GiaDichVu", dGia);

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
        private void btnCapNhat_Click(object sender, EventArgs e)
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
            string sMaDV = txtMaDV.Text;
            string sTenDV = txtTenDV.Text;
            string sGiaDV = txtGiaDV.Text;
            if (string.IsNullOrWhiteSpace(sTenDV) || string.IsNullOrWhiteSpace(sGiaDV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                con.Close();
                return;
            }
            decimal dGia = decimal.Parse(sGiaDV);
            if (dGia <= 0)
            {
                MessageBox.Show("Giá phòng không được âm");
                con.Close();
                return;
            }
            // Câu lệnh SQL
            string sQuery = "UPDATE DichVu set TenDichVu=@TenDichVu, GiaDichVu=@GiaDichVu " +
                            "where MaDichVu=@MaDichVu";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số
            cmd.Parameters.AddWithValue("@MaDichVu", sMaDV);
            cmd.Parameters.AddWithValue("@TenDichVu", sTenDV);
            cmd.Parameters.AddWithValue("@GiaDichVu", sGiaDV);

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

            string sMaDV = txtMaDV.Text;

            string sQuery = "delete from DichVu where MaDichVu=@MaDV";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@MaDV", sMaDV);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin dịch vụ thành công");
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
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtMaDV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
            txtTenDV.Text = dataGridView1.Rows[e.RowIndex].Cells["TenDichVu"].Value.ToString();
            txtGiaDV.Text = dataGridView1.Rows[e.RowIndex].Cells["GiaDichVu"].Value.ToString();

            txtMaDV.Enabled = false;
        }
        private void LoadData()
        {
            // Kết nối DB
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();

                // Lấy dữ liệu
                string sQuery = "SELECT * FROM DichVu";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "DichVu");

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = ds.Tables["DichVu"];
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

        private void btnLoadDL_Click(object sender, EventArgs e)
        {
            txtMaDV.Clear();
            txtTenDV.Clear();   
            txtGiaDV.Clear();
            LoadData();
            txtMaDV.Enabled=true;
        }

        private void frmDichVu_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
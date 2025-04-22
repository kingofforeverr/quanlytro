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
    public partial class frmTaiKhoan : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                con.Open();

                // Câu lệnh SQL
                string query = @"
            OPEN SYMMETRIC KEY QLT7
            DECRYPTION BY PASSWORD = 'qlt@';

            SELECT TenDangNhap, ChucVu, 
                   CAST(DECRYPTBYKEY(MatKhauMaHoa) AS VARCHAR(50)) AS MatKhauGiaiMa
            FROM TaiKhoan;

            CLOSE SYMMETRIC KEY QLT7;
        ";

                // Tạo SqlDataAdapter để thực hiện truy vấn
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                // Tạo DataSet để lưu trữ dữ liệu
                DataSet ds = new DataSet();
                da.Fill(ds, "TaiKhoan");

                // Gán dữ liệu cho DataGridView
                dataGridView1.DataSource = ds.Tables["TaiKhoan"];
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi chi tiết
                MessageBox.Show($"Xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối
                con.Close();
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Lỗi tại hàng {e.RowIndex}, cột {e.ColumnIndex}: {e.Exception.Message}", "Lỗi dữ liệu");
            e.ThrowException = false;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối DB");
            }

            string sTenDN = txtTenDN.Text;
            if (string.IsNullOrWhiteSpace(sTenDN))
            {
                MessageBox.Show("Tên đăng nhập không được để trống.");
                con.Close();
                return;
            }
            //check username
            string checkQuery = "select count(*) from taikhoan where TendangNhap = @username";

            SqlCommand checkcmd = new SqlCommand(checkQuery, con);
            checkcmd.Parameters.AddWithValue("@username", sTenDN);
            int count = (int)checkcmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại, vui lòng nhập tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string sMatKhau = txtMatKhau.Text;
            //string sRole = txtRole.Text;
            //string iRole = rbKhach.Checked ? "Khách thuê" : "Chủ trọ";
            string iRole = rbKhach.Checked ? "Khách thuê" : (rbadmin.Checked ? "Chủ trọ" : null);
            if (string.IsNullOrWhiteSpace(sMatKhau))
            {
                MessageBox.Show("Mật khẩu không được để trống.");
                con.Close();
                return;
            }

            if (iRole == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ.");
                con.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand("AddUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", sTenDN);
            cmd.Parameters.AddWithValue("@chucvu", iRole);
            cmd.Parameters.AddWithValue("@password", sMatKhau);

            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo mới tài khoản thành công");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi tạo tài khoản");
            }
            finally { con.Close(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối DB");
            }

            string sTenDN = txtTenDN.Text;
            //check username


            string sMatKhau = txtMatKhau.Text;
            //string sRole = txtRole.Text;
            string iRole = rbKhach.Checked ? "Khách thuê" : "Chủ trọ";


            SqlCommand cmd = new SqlCommand("UpdateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", sTenDN);
            cmd.Parameters.AddWithValue("@new_chucvu", iRole);
            cmd.Parameters.AddWithValue("@new_password", sMatKhau);

            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật tài khoản thành công");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi cập nhật tài khoản");
            }
            finally { con.Close(); }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtTenDN.Text = dataGridView1.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
            txtMatKhau.Text = dataGridView1.Rows[e.RowIndex].Cells["MatKhauGiaiMa"].Value.ToString();
            
            string iRole = dataGridView1.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();
            if (iRole == "Khách thuê")
            {
                rbKhach.Checked = true;
            }
            else
            {
                rbadmin.Checked = true;
            }
            txtTenDN.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {

                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối DB");
            }

            string sTenDN = txtTenDN.Text;

            string sQuery = "delete from taikhoan where TenDangNhap = @tendn";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@tendn", sTenDN);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa tài khoản thành công");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa tài khoản");
            }
            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtTenDN.Clear();
            rbadmin.Checked= false;
            rbKhach.Checked= false;
            txtMatKhau.Clear();
            txtTenDN.Enabled = true;
        }

        //private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    frmMain frmMain = new frmMain();
        //    frmMain.Show();
        //    this.Close();
        //}
    }
}

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
    public partial class frmPhongTro : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Trust Server Certificate=True";

        public frmPhongTro()
        {
            InitializeComponent();
        }

        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    string sMaPhong = txtMaPhong.Text;
        //    SqlConnection con = new SqlConnection(sCon);
        //    try
        //    {
        //        con.Open();
        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Lỗi quá trình kết nối DB");
        //    }
        //    //check mã phòng tồn tại
        //    string sCheckQuery = "SELECT COUNT(*) FROM PhongTro WHERE MaPhong = @maphong";
        //    SqlCommand checkcmd = new SqlCommand(sCheckQuery, con);
        //    checkcmd.Parameters.AddWithValue("@maphong", sMaPhong);

        //    int count = (int)checkcmd.ExecuteScalar();
        //    if (count > 0)
        //    {
        //        MessageBox.Show("Mã phòng đã tồn tại vui lòng nhập mã khác");
        //        con.Close();
        //        return;
        //    }

        //    string sTinhTrang = txtTinhTrang.Text;
        //    string sSoLuongKhach = txtSoLuongKhach.Text;
        //    int iSoLuongKhach = Convert.ToInt32(sSoLuongKhach);
        //    string sGiaPhong = txtGiaPhong.Text;
        //    decimal dGiaPhong = Convert.ToDecimal(sGiaPhong);
        //    string sDienTich = txtDienTich.Text;
        //    decimal dDienTich = Convert.ToDecimal(sDienTich);
        //    //thêm mới
        //    string sQuery = "insert into PhongTro values(@maphong,@tinhtrang, @soluong,@giaphong, @dientich)";

        //    SqlCommand cmd = new SqlCommand(sQuery, con);
        //    cmd.Parameters.AddWithValue("@maphong", sMaPhong);
        //    cmd.Parameters.AddWithValue("@tinhtrang", sTinhTrang);
        //    cmd.Parameters.AddWithValue("@soluong", iSoLuongKhach);
        //    cmd.Parameters.AddWithValue("@giaphong", dGiaPhong);
        //    cmd.Parameters.AddWithValue("@dientich", dDienTich);

        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Thêm mới phòng thành công");
        //        LoadData();

        //    }
        //    catch(Exception ex) 
        //    {
        //        MessageBox.Show("bị lỗi cmnr");

        //    }
        //    con.Close();

        //}
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sMaPhong = txtMaPhong.Text.Trim();

            // Kiểm tra nếu mã phòng chưa được nhập
            if (string.IsNullOrEmpty(sMaPhong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Kiểm tra mã phòng tồn tại
                    string sCheckQuery = "SELECT COUNT(*) FROM PhongTro WHERE MaPhong = @maphong";
                    SqlCommand checkcmd = new SqlCommand(sCheckQuery, con);
                    checkcmd.Parameters.AddWithValue("@maphong", sMaPhong);

                    int count = (int)checkcmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã phòng đã tồn tại, vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Lấy các giá trị từ TextBox
                    string sTinhTrang = rbThue.Checked ? "Đang thuê" : (rbTrong.Checked ? "Còn trống" : null);
                    if (sTinhTrang == null)

                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                        con.Close();
                        return;
                    }
                    string sSoLuongKhach = txtSoLuongKhach.Text.Trim();
                    string sGiaPhong = txtGiaPhong.Text.Trim();
                    string sDienTich = txtDienTich.Text.Trim();

                    // Kiểm tra các trường nhập vào có hợp lệ không
                    if (string.IsNullOrEmpty(sTinhTrang) || string.IsNullOrEmpty(sSoLuongKhach) ||
                        string.IsNullOrEmpty(sGiaPhong) || string.IsNullOrEmpty(sDienTich))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Chuyển đổi dữ liệu
                    int iSoLuongKhach = Convert.ToInt32(sSoLuongKhach);
                    decimal dGiaPhong = Convert.ToDecimal(sGiaPhong);
                    decimal dDienTich = Convert.ToDecimal(sDienTich);
                    if (iSoLuongKhach > 0 && sTinhTrang == "Còn trống")
                    {
                        sTinhTrang = "Đang thuê";
                        rbThue.Checked = true;
                    }
                    // Thực hiện thêm mới phòng
                    string sQuery = "INSERT INTO PhongTro VALUES(@maphong, @tinhtrang, @soluong, @giaphong, @dientich)";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@maphong", sMaPhong);
                    cmd.Parameters.AddWithValue("@tinhtrang", sTinhTrang);
                    cmd.Parameters.AddWithValue("@soluong", iSoLuongKhach);
                    cmd.Parameters.AddWithValue("@giaphong", dGiaPhong);
                    cmd.Parameters.AddWithValue("@dientich", dDienTich);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu sau khi thêm mới
                    LoadData();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng kiểm tra lại các trường số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xảy ra lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);

            try
            {

                con.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối DB");

            }

            string sMaPhong = txtMaPhong.Text;
            string sCheckQuery = "SELECT COUNT(*) FROM PhongTro WHERE MaPhong = @maphong";
            SqlCommand checkcmd = new SqlCommand(sCheckQuery, con);
            checkcmd.Parameters.AddWithValue("@maphong", sMaPhong);

            int count = (int)checkcmd.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Mã phòng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }

            string sTinhTrang = rbThue.Checked ? "Đang thuê" : "Còn trống";

            string sSoLuongKhach = txtSoLuongKhach.Text;
            string sGiaPhong = txtGiaPhong.Text;
            string sDienTich = txtDienTich.Text;
            if (string.IsNullOrEmpty(sGiaPhong)|| string.IsNullOrEmpty(sDienTich) || string.IsNullOrEmpty(sSoLuongKhach))
            {
                MessageBox.Show("Vui lòng điền đầy đủ");
                return;
            }
            int iSoLuongKhach = Convert.ToInt32(sSoLuongKhach);
            decimal dGiaPhong = Convert.ToDecimal(sGiaPhong);
            if (iSoLuongKhach >0 && sTinhTrang == "Còn trống")
            {
                sTinhTrang = "Đang thuê";
                rbThue.Checked = true;
            }
            decimal dDienTich = Convert.ToDecimal(sDienTich);
            string sQuery = "update PhongTro " +
                "set TinhTrangPhong = @tinhtrang, SoKhachThue = @soluong,GiaPhong = @giaphong," +
                " DienTich=@dientich " +
                "where MaPhong = @maphong";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maphong", sMaPhong);
            cmd.Parameters.AddWithValue("@tinhtrang", sTinhTrang);
            cmd.Parameters.AddWithValue("@soluong", iSoLuongKhach);
            cmd.Parameters.AddWithValue("@giaphong", dGiaPhong);
            cmd.Parameters.AddWithValue("@dientich", dDienTich);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin phòng thành công");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi quá trình cập nhật");
            }
            con.Close();
        }

        private void frmPhongTro_Load(object sender, EventArgs e)
        {
            LoadData();
            cbTinhTrang.Items.Clear();
            cbTinhTrang.Items.Add("Tất cả");
            cbTinhTrang.Items.Add("Còn Trống");
            cbTinhTrang.Items.Add("Đang Thuê");
            //cbTinhTrang.SelectedIndex = 0;
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();

                // Lấy dữ liệu
                string sQuery = "SELECT * FROM phongtro";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "PhongTro");

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = ds.Tables["PhongTro"];
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



        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            string selectedTinhTrang = cbTinhTrang.SelectedItem.ToString();

            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();
                if (selectedTinhTrang == "Tất cả")
                {
                    string query = "select * from phongtro";
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);
                    DataSet dataSet = new DataSet();
                    adp.Fill(dataSet, "PhongTro");
                    dataGridView1.DataSource = dataSet.Tables["PhongTro"];
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("LocPhongTheoTrangThai", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TinhTrang", selectedTinhTrang);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "PhongTro");

                        // Hiển thị kết quả vào DataGridView
                        dataGridView1.DataSource = ds.Tables["PhongTro"];
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();

            }
            catch
            {

                MessageBox.Show("Lỗi kết nối DB");
            }
            string sMaPhong = txtMaPhong.Text;
            string sQuery = "delete from phongtro where maphong = @maphong";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maphong",sMaPhong);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin phòng thành công");
                LoadData();
            }
            catch {
                MessageBox.Show("Lỗi không thể xóa thông tin phòng này");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtMaPhong.Text = dataGridView1.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
            string iRole = dataGridView1.Rows[e.RowIndex].Cells["TinhTrangPhong"].Value.ToString();
            if (iRole == "Đang thuê")
            {
                rbThue.Checked = true;
            }
            else
            {
                rbTrong.Checked = true;
            }
            
            txtSoLuongKhach.Text = dataGridView1.Rows[e.RowIndex].Cells["SoKhachThue"].Value.ToString();
            txtGiaPhong.Text = dataGridView1.Rows[e.RowIndex].Cells["GiaPhong"].Value.ToString();
            txtDienTich.Text = dataGridView1.Rows[e.RowIndex].Cells["DienTich"].Value.ToString();
        }
    }
}

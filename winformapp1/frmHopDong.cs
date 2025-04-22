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
    public partial class frmHopDong : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            //LoadData();
            //txtMaHopDong.Enabled = true;
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();

                // Lấy dữ liệu
                string sQuery = "select * from hopdong";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "HopDong");

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = ds.Tables["HopDong"];
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
            txtMaHopDong.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            txtMaHopDong.Clear();
            txtNgayDen.Value = DateTime.Now;
            txtNgayDi.Value = DateTime.Now;
            txtTienCoc.Clear();
            txtMaPhong.Clear();
            txtMaHopDong.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi kết nối DB");
            }
            string sMaHopDong = txtMaHopDong.Text;
            if (string.IsNullOrWhiteSpace(sMaHopDong))
            {
                MessageBox.Show("Mã hợp đồng không được để trống.");
                con.Close();
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM hopdong WHERE MaHopDong = @mahopdong";
            SqlCommand checkcmd = new SqlCommand(checkQuery, con);
            checkcmd.Parameters.AddWithValue("@mahopdong", sMaHopDong);
            int count = (int)checkcmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Mã hợp đồng đã tồn tại. Vui lòng nhập mã khác.");
                con.Close();
                return;
            }
            string sNgayDen = txtNgayDen.Value.ToString("yyyy-MM-dd");
            string sNgayDi = txtNgayDi.Value.ToString("yyyy-MM-dd");
            string sTienCoc = txtTienCoc.Text;
            if (string.IsNullOrEmpty(sTienCoc))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                con.Close();
                return;
            }
            decimal dTienCoc = Convert.ToDecimal(sTienCoc);
            string sMaPhong = txtMaPhong.Text;
            string sQuery = "insert into HopDong values(@mahopdong, @ngayden,@ngaydi,@tiencoc,@maphong)";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@mahopdong", sMaHopDong);
            cmd.Parameters.AddWithValue("@ngayden", sNgayDen);
            cmd.Parameters.AddWithValue("@ngaydi", sNgayDi);
            cmd.Parameters.AddWithValue("@tiencoc", dTienCoc);
            cmd.Parameters.AddWithValue("@maphong", sMaPhong);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới hợp đồng thành công");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi thêm mới hợp đồng");
            }
            con.Close();
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

                MessageBox.Show("Lỗi kết nối DB");
            }
            string sMaHopDong = txtMaHopDong.Text;
            string sCheckQuery = "SELECT COUNT(*) FROM HopDong WHERE MaHopDong = @mahopdong";
            SqlCommand checkCmd = new SqlCommand(sCheckQuery, con);
            checkCmd.Parameters.AddWithValue("@mahopdong", sMaHopDong);

            int count = (int)checkCmd.ExecuteScalar(); // Sử dụng ExecuteScalar để kiểm tra số lượng
            if (count == 0)
            {
                MessageBox.Show("Mã hợp đồng không tồn tại. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sNgayDen = txtNgayDen.Value.ToString("yyyy-MM-dd");
            string sNgayDi = txtNgayDi.Value.ToString("yyyy-MM-dd");
            string sTienCoc = txtTienCoc.Text;
            decimal dTienCoc = Convert.ToDecimal(sTienCoc);
            string sMaPhong = txtMaPhong.Text;

            string sQuery = "update HopDong set NgayDen = @ngayden,NgayDi=@ngaydi," +
                "SoTiencoc=@tiencoc,MaPhong =@maphong where MaHopDong=@mahopdong";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@mahopdong", sMaHopDong);
            cmd.Parameters.AddWithValue("@ngayden", sNgayDen);
            cmd.Parameters.AddWithValue("@ngaydi", sNgayDi);
            cmd.Parameters.AddWithValue("@tiencoc", dTienCoc);
            cmd.Parameters.AddWithValue("@maphong", sMaPhong);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật hợp đồng thành công");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi cập nhật hợp đồng");
            }
            con.Close();
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

                MessageBox.Show("Lỗi kết nối DB");
            }
            string sMaHopDong = txtMaHopDong.Text;
            string sCheckQuery = "SELECT COUNT(*) FROM HopDong WHERE MaHopDong = @mahopdong";
            SqlCommand checkCmd = new SqlCommand(sCheckQuery, con);
            checkCmd.Parameters.AddWithValue("@mahopdong", sMaHopDong);

            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Mã hợp đồng không tồn tại. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sNgayDen = txtNgayDen.Value.ToString("yyyy-MM-dd");
            string sNgayDi = txtNgayDi.Value.ToString("yyyy-MM-dd");
            string sTienCoc = txtTienCoc.Text;
            decimal dTienCoc = Convert.ToDecimal(sTienCoc);
            string sMaPhong = txtMaPhong.Text;

            string sQuery = "delete from HopDong where MaHopDong = @mahopdong";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@mahopdong", sMaHopDong);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa hợp đồng thành công");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi xóa hợp đồng");
            }
            con.Close();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtMaHopDong.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHopDong"].Value.ToString();
            txtTienCoc.Text = dataGridView1.Rows[e.RowIndex].Cells["SoTiencoc"].Value.ToString();
            txtMaPhong.Text = dataGridView1.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
            //dateTimePicker1.Value = Convert.ToDateTime
            //(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            if (dataGridView1.Rows[e.RowIndex].Cells["NgayDen"].Value != null)
            {
                txtNgayDen.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayDen"].Value);
            }
            else
            {
                txtNgayDen.Value = DateTime.Now;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells["NgayDi"].Value != null)
            {
                txtNgayDi.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayDi"].Value);
            }
            else
            {
                txtNgayDi.Value = DateTime.Now;
            }
            txtMaHopDong.Enabled = false;
        }

        private void frmHopDong_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain();
            a.Show();
            this.Close();
        }
    }
}

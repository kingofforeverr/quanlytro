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
    public partial class frmHopDongKhach : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public frmHopDongKhach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                if (string.IsNullOrEmpty(maPhong))
                {
                    MessageBox.Show("Không tồn tại hóa đơn");
                    // Lấy dữ liệu theo mã phòng
                }
               

                string  sQuery = "SELECT * FROM HopDong WHERE MaPhong = @MaPhong";
                // Chuẩn bị lệnh SQL
                SqlCommand cmd = new SqlCommand(sQuery, con);
                if (!string.IsNullOrEmpty(maPhong))
                {
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Đổ dữ liệu vào DataSet
                DataSet ds = new DataSet();
                adapter.Fill(ds, "HopDong");

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = ds.Tables["HopDong"];

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

            txtMaPhong.Text = dataGridView1.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
            //dateTimePicker1.Value = Convert.ToDateTime
            //(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            
            
        }
    }
}

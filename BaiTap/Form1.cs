using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        SqlCommandBuilder cmdb;
        string str = @"Data Source=DESKTOP-P47PEOK\SQLEXPRESS;Initial Catalog=CGV;Integrated Security=True";
        public void GetData()
        {
            SqlConnection conn = new SqlConnection(str);
            // Bước 3: Khởi tạo Select query
            conn.Open();
            string select_query = "select * from KhachHang";
            // Bước 4: Khởi tạo SqlDataAdapter
            da = new SqlDataAdapter(select_query, conn);
            // Bước 5: Khởi tạo DataSet
            ds = new DataSet();
            // Bước 6: Đổ dữ liệu từ truy vấn lên DataSet
            da.Fill(ds, "Khoa");
            // Bước 7: Hiển thị dữ liệu lên DataGridView
            dataGridView1.DataSource = ds.Tables["Khoa"];
            // Bước 8: Khởi tạo các truy vấn Insert/Update/Delete thông qua SqlCommandBuilder
            SqlCommandBuilder cmbd = new SqlCommandBuilder(da);
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            da.Update(ds,"Khoa");
        }
    }
}

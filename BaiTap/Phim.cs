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
using BaiTap.DTO;

namespace BaiTap
{
    public partial class Phim : Form
    {
        public Phim()
        {
            InitializeComponent();
        }
        string query = @"Data Source=DESKTOP-P47PEOK\SQLEXPRESS;Initial Catalog=CGV;Integrated Security=True";
        List<DTO.VeXemPhim> dsve;
        public void getdata()
        {
            SqlConnection connect = new SqlConnection(query);
            connect.Open();
            dsve = new List<VeXemPhim>();
            string query1 = "SELECT * FROM VeXemPhim";
            SqlCommand cmd = new SqlCommand(query1, connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string MaVe = dr["MaVe"] is DBNull ? "" : dr["MaVe"].ToString();
                string MaLoaiVe = dr["MaLoaiVe"] is DBNull ? "" : dr["MaLoaiVe"].ToString();
                string MaKH = dr["MaKH"] is DBNull ? "" : dr["MaKH"].ToString();
                string TenPhim = dr["TenPhim"] is DBNull ? "" : dr["TenPhim"].ToString();
                string NgayGioChieu = dr["NgayGioChieu"] is DBNull ? "" : dr["NgayGioChieu"].ToString();
                string NuocNgot = dr["NuocNgot"] is DBNull ? "" : dr["NuocNgot"].ToString();
                string BongNgo = dr["BongNgo"] is DBNull ? "" : dr["BongNgo"].ToString();
                string ThanhTien = dr["ThanhTien"] is DBNull ? "" : dr["ThanhTien"].ToString();
                dsve.Add(new VeXemPhim(MaVe, MaLoaiVe, MaKH, TenPhim, NgayGioChieu, NuocNgot, BongNgo, ThanhTien));
            }
            connect.Close();
            dataGridView1.DataSource = dsve;
        }
        public void GetMaLoaiVe()
        {
            SqlConnection connect = new SqlConnection(query);
            connect.Open();
            string query1 = "SELECT * FROM LoaiVe";
            SqlCommand cmd = new SqlCommand(query1, connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "LoaiVe");
            cb_MaLoaiVe.DataSource = ds.Tables["LoaiVe"];
            cb_MaLoaiVe.DisplayMember = "MaLoaiVe";
            cb_MaLoaiVe.ValueMember = "GiaVe";
        }
        public void GetMaKH()
        {
            SqlConnection connect = new SqlConnection(query);
            connect.Open();
            string query1 = "SELECT * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(query1, connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "KhachHang");
            cb_MaKH.DataSource = ds.Tables["KhachHang"];
            cb_MaKH.DisplayMember = "MaKH";
            cb_MaKH.ValueMember = "MaKH";
        }
        public void ADD()
        {
            int MaVe = int.Parse(txt_MaVe.Text);
            int MaLoaiVe = int.Parse(cb_MaLoaiVe.SelectedItem.ToString());
            int MaKH = int.Parse(cb_MaKH.SelectedValue.ToString());
            string tenPhim = txt_TenPhim.Text;
            DateTime NgayGiochieu = DateTime.Parse(NgayGioChieu.Value.ToString());
            float NN = 0;
            float BN = 0;
            float thanhtien = 0;
            if(cb_NuocNgot.Checked)
            {
                thanhtien = float.Parse(cb_MaLoaiVe.SelectedValue.ToString()) + 20000;
                NN = 1;             
            }
            if(cb_BongNgo.Checked)
            {
                thanhtien = float.Parse(cb_MaLoaiVe.SelectedValue.ToString()) + 25000;
                 BN = 1;
            }    
            if(cb_BongNgo.Checked && cb_NuocNgot.Checked)
            {
                thanhtien = float.Parse(cb_MaLoaiVe.SelectedValue.ToString()) + 20000 + 25000;
                 NN = 1;
                 BN = 1;
            }    
            SqlConnection connect = new SqlConnection(query);
            connect.Open();
            dsve = new List<VeXemPhim>();
            string query1 = "INSERT INTO VeXemPhim(MaVe,MaLoaiVe,MaKH,TenPhim,NgayGioChieu,NuocNgot,BongNgo,ThanhTien) VALUES ('"+MaVe+"','"+MaLoaiVe+"','"+MaKH+"','"+tenPhim+"','"+ NgayGiochieu+"','"+ NN +"','"+ BN +"','"+ thanhtien +"');";
            SqlCommand cmd = new SqlCommand(query1, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            getdata();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_TenPhim_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phim_Load(object sender, EventArgs e)
        {
            getdata();
            GetMaKH();
            GetMaLoaiVe();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ADD();
        }
    }
}

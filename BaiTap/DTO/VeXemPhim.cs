using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.DTO
{
    public class VeXemPhim
    {
        private string MaVe;
        private string MaLoaiVe;
        private string MaKH;
        private string TenPhim;
        private string NgayGioChieu;
        private string NuocNgot;
        private string BongNgo;
        private string ThanhTien;

        public VeXemPhim(string maVe, string maLoaiVe, string maKH, string tenPhim, string ngayGioChieu, string nuocNgot, string bongNgo, string thanhTien)
        {
            MaVe = maVe;
            MaLoaiVe = maLoaiVe;
            MaKH = maKH;
            TenPhim = tenPhim;
            NgayGioChieu = ngayGioChieu;
            NuocNgot = nuocNgot;
            BongNgo = bongNgo;
            ThanhTien = thanhTien;
        }

        public string MaVe1 { get => MaVe; set => MaVe = value; }
        public string MaLoaiVe1 { get => MaLoaiVe; set => MaLoaiVe = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenPhim1 { get => TenPhim; set => TenPhim = value; }
        public string NgayGioChieu1 { get => NgayGioChieu; set => NgayGioChieu = value; }
        public string NuocNgot1 { get => NuocNgot; set => NuocNgot = value; }
        public string BongNgo1 { get => BongNgo; set => BongNgo = value; }
        public string ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
    }
}

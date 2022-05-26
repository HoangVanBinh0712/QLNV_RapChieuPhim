using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class LUONGDAO
    {
        private int MaNV;
        private DateTime Ngaythangnam;
        private int Sogiolam;
        private int Luongtheogio;
        private int Thuong;
        private int Tongluong;
        public int getLuongID()
        {
            return this.MaNV;
        }
        public void setLuongID(int manv)
        {
            this.MaNV = manv;
        }
        public DateTime getLuongdate()
        {
            return this.Ngaythangnam;
        }
        public void setLuongdate(DateTime ngaythangnam)
        {
            this.Ngaythangnam = ngaythangnam;
        }
        public int getLuongSogiolam()
        {
            return this.Sogiolam;
        }
        public void setLuongSogiolam(int Sogiolam)
        {
            this.Sogiolam = Sogiolam;
        }
        public int getLuongLtheogio()
        {
            return this.Luongtheogio;
        }
        public void setLuongLtheogio(int Luongtheogio)
        {
            this.Luongtheogio = Luongtheogio;
        }
        public int getLuongThuong()
        {
            return this.Thuong;
        }
        public void setLuongThuong(int Thuong)
        {
            this.Thuong = Thuong;
        }
        public int getLuongTongLuong()
        {
            return this.Tongluong;
        }
        public void setLuongTongLuong(int TongLuong)
        {
            this.Tongluong = TongLuong;
        }
    }
}

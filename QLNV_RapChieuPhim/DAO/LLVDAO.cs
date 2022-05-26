using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class LLVDAO
    {
        private int LLV_ID;
        private float GioLam;
        private TimeSpan GioBatDau;
        private TimeSpan GioKetThuc;
        private DateTime NgayLam;
        //ID
        public int getLLVid()
        {
            return this.LLV_ID;
        }
        public void setLLVid(int id)
        {
            this.LLV_ID = id;
        }
        //Giờ Làm
        public float getGioLam()
        {
            return this.GioLam;
        }
        public void setGioLam(float GioLam)
        {
            this.GioLam = GioLam;
        }
        //Giờ bắt đầu
        public TimeSpan getGioBatDau()
        {
            return this.GioBatDau;
        }
        public void setGioBatDau(TimeSpan GioBatDau)
        {
            this.GioBatDau = GioBatDau;
        }
        // Giờ Kết thúc
        public TimeSpan getGioKetThuc()
        {
            return this.GioKetThuc;
        }
        public void setGioKetThuc(TimeSpan GioKetThuc)
        {
            this.GioKetThuc = GioKetThuc;
        }
        // Ngày làm
        public DateTime getNgayLam()
        {
            return this.NgayLam;
        }
        public void setNgayLam(DateTime NgayLam)
        {
            this.NgayLam = NgayLam;
        }
    }

}

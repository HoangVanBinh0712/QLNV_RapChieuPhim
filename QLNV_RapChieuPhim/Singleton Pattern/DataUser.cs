using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class DataUser
    {
        static DataUser dataUser;
        private NhanVienDAO nhanvien;
        public static DataUser getInstance()
        {
            if(dataUser == null)
            {
                dataUser = new DataUser();
            }
            return dataUser;
        }
        public DataUser() { }
        public NhanVienDAO getNhanVien()
        {
            return nhanvien;
        }

        public void setNhanVien(NhanVienDAO nhanvien)
        {
            this.nhanvien = nhanvien;
        }
    }
}

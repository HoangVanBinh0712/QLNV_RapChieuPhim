using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public interface INhanVien
    {
        bool InsertNhanVien(ref string err, NhanVienDAO nv); 
        void UơdateNhanVien();
        void DeleteNhanVien();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public interface ILuong
    {
        bool UpdateLuong(ref string err, int id, int Luongtheogio, DateTime DAY, int Thuong);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class LuongAdapter : ILuong
    {
        DBBusiness db;
        public LuongAdapter()
        {
            db = new DBBusiness();
        }

        //public bool updateLuong(ref string err, int id,DateTime DAY, int Luongtheogio, int Thuong)
        //Doi vi tri
        public bool UpdateLuong(ref string err, int id, int Luongtheogio, DateTime DAY, int Thuong)
        {
            return (db.updateLuong(ref err, id, DAY, Luongtheogio, Thuong));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class LLVAdapter : ILLV
    {
        DBBusiness db;
        public LLVAdapter()
        {
            db = new DBBusiness();
        }
        public bool InsertLLV(ref string err, LLVDAO llv)
        {
            return (db.insertLLV(ref err, llv.getLLVid(), ((int)llv.getGioLam()), llv.getGioBatDau(),
                llv.getGioKetThuc(), llv.getNgayLam()));
        }

        public bool UpdateLLV(ref string err, LLVDAO llv)
        {
            return (db.updateLLV(ref err, llv.getLLVid(), ((int)llv.getGioLam()), llv.getGioBatDau(),
                llv.getGioKetThuc(), llv.getNgayLam()));
        }
    }
}

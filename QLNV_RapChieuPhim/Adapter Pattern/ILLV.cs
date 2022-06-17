using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public interface ILLV
    {
        bool InsertLLV(ref string err, LLVDAO llv);
        bool UpdateLLV(ref string err, LLVDAO llv);
    }
}

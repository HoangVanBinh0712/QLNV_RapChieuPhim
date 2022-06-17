using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public interface ICV
    {
        bool InsertCV(ref string err, CVDAO cv);
        bool UpdateCV(ref string err, CVDAO cv);
    }
}

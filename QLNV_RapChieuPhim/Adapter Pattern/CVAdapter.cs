using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class CVAdapter : ICV
    {
        DBBusiness db;
        public CVAdapter()
        {
            db = new DBBusiness();
        }
        public bool InsertCV(ref string err, CVDAO cv)
        {
            return (db.insertCV(ref err, cv.getMaCV(), cv.getTenCV(), cv.getMoTa(), cv.getMaNV()));
        }

        public bool UpdateCV(ref string err, CVDAO cv)
        {
            return (db.updateCV(ref err, cv.getMaCV(), cv.getTenCV(), cv.getMoTa(), cv.getMaNV()));
        }
    }
}

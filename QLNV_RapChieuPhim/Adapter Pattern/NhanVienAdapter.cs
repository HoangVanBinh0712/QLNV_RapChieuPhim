using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class NhanVienAdapter : INhanVien
    {
        DBBusiness db;
        public NhanVienAdapter()
        {
            db = new DBBusiness();
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public void DeleteNhanVien()
        {
            throw new NotImplementedException();
        }

        public bool InsertNhanVien(ref string err, NhanVienDAO nv)
        {
            //
           return (db.insertNV(ref err, nv.getNVid(), nv.getNVName(),
                nv.getNVBirth(), nv.getNVPNum(), nv.getNVEmail(),
                nv.getNVJob(), nv.getpassword(), nv.getDRented(),
                imageToByteArray(nv.getNVimg())));

        }

        public void UơdateNhanVien()
        {
            throw new NotImplementedException();
        }
    }
}

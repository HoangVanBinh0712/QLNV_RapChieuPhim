using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class CVDAO
    {
        private int MaCV;
        private int MaNV;
        private string TenCV;
        private string MoTa;

        public CVDAO()
        {

        }
        public CVDAO(int maCV, int maNV, string tenCV, string moTa)
        {
            MaCV = maCV;
            MaNV = maNV;
            TenCV = tenCV;
            MoTa = moTa;
        }

        public int getMaCV() {
            return MaCV;
        }
        public int getMaNV() { return MaNV; }
        public string getTenCV() { return TenCV; }

        public string getMoTa() { return MoTa; }

        public void setMaCV(int MaCV)
        {
            this.MaCV = MaCV;
        }
        public void setMaNV(int MaNV) { this.MaNV= MaNV; }
        public void setTenCV(string TenCV) { this.TenCV = TenCV; }

        public void setMoTa(string MoTa) { this.MoTa = MoTa; }

    }
}

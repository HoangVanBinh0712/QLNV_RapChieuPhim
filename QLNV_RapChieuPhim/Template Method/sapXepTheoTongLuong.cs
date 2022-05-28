using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class SapXepTheoTongLuong : SortAlgorithm
    {
        public override bool compare(object[] a, object[] b, bool des)
        {
            int numa = int.Parse(a.GetValue(5).ToString());
            int numb = int.Parse(b.GetValue(5).ToString());
            if (numa > numb)
                return des != true;
            return des != false;
        }
    }
}

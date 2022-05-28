using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class sapXepTheoSoGioLam : SortAlgorithm
    {
        public override bool compare(object[] a, object[] b, bool des)
        {
            int numa = int.Parse(a.GetValue(2).ToString());
            int numb = int.Parse(b.GetValue(2).ToString());
            if (numa > numb)
                return des != true;
            return des != false;
        }
    }
}

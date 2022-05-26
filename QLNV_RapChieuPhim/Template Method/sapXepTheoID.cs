using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class sapXepTheoID : SortAlgorithm
    {
        public override bool compare(object[] a, object[] b)
        {
            int numa = int.Parse(a.GetValue(0).ToString());
            int numb = int.Parse(b.GetValue(0).ToString());
            if (numa > numb)
                return true;
            return false;
        }
    }
}

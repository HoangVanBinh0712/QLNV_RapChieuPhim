using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class sapXepTheoNgay : SortAlgorithm
    {
        public override bool compare(object[] a, object[] b,bool des)
        {
            DateTime date1 = Convert.ToDateTime(a.GetValue(1).ToString());
            DateTime date2 = Convert.ToDateTime(b.GetValue(1).ToString());
            int result = DateTime.Compare(date1, date2);
            if (result < 0)
                return des != false;
            return des != true;
        }
    }
}

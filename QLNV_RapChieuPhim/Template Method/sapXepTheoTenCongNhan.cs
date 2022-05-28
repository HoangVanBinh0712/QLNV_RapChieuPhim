using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class sapXepTheoTenCongNhan : SortAlgorithm
    {
        public override bool compare(object[] a, object[] b, bool des)
        {
            string fullnamea = a.GetValue(1).ToString().Trim();
            string fullnameb = b.GetValue(1).ToString().Trim();
            string[] namea = fullnamea.Split(' ');
            string[] nameb = fullnameb.Split(' ');


            int lena = namea.Length - 1;
            int lenb = nameb.Length - 1;

            while (lena >= 0 && lenb >= 0)
            {
                string root = namea[lena];
                string root2 = nameb[lenb];
                int comparison = String.Compare(root, root2, comparisonType: StringComparison.OrdinalIgnoreCase);

                if (comparison < 0)
                {
                    return des != false;
                }
                else if (comparison > 0)
                {
                    return des != true;

                }
                lena--;
                lenb--;
            }
            if (lena > lenb)
                return des != true;
            return des != false;
        }
    }
}

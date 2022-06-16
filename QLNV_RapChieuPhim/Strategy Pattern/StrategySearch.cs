using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim.Strategy_Pattern
{
    public abstract class StrategySearch
    {
        public abstract DataTable SearchResult(string searchContent, DataTable arr);
    }
}

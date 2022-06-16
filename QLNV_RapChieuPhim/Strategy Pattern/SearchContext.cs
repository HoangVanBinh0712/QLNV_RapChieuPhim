using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim.Strategy_Pattern
{
    public class SearchContext
    {
        StrategySearch strategy;
        // Constructor
        public SearchContext(StrategySearch strategy)
        {
            this.strategy = strategy;
        }
        public DataTable SearchResult(string searchContent, DataTable arr)
        {
            return strategy.SearchResult(searchContent, arr);
        }
    }
}

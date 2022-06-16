using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim.Strategy_Pattern
{
	public class SearchNV : StrategySearch
	{
		public override DataTable SearchResult(string searchContent, DataTable arr)
		{


			DataRow[] dataRows = new DataRow[arr.Rows.Count];
			DataRow[] dataRows2 = new DataRow[arr.Rows.Count];
			int index = 0;
			int index2 = 0;

			string scontent = searchContent;
			//Get
			foreach (DataRow row in arr.Rows)
			{
				dataRows[index] = row;
				index++;
			}

			for (int i = 0; i < dataRows.Length; i++)
			{
				string content;
				content = dataRows[i][1].ToString();
				if (content.Contains(scontent) == true)
				{
					dataRows2[index2] = dataRows[i];
					index2++;
				}
			}

			DataTable datatable = new DataTable();
			datatable.Clear();
			//Add column name
			foreach (DataColumn dtc in arr.Columns)
			{
				datatable.Columns.Add(dtc.ColumnName);
			}
			//Import row
			for (int i = 0; i < dataRows2.Length; i++)
			{
				datatable.ImportRow(dataRows2[i]);
			}
			arr.Clear();
			arr = datatable;
			return arr;
		}
	}
}

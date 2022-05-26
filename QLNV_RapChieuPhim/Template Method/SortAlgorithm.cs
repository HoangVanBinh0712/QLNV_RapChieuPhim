using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public abstract class SortAlgorithm
    {
		DataTable arr;
		public DataTable returnArray()
		{
			return arr;
		}
		public abstract bool compare(object[] a, object[] b);
		public void processArray(DataTable arr)
		{
			this.arr = arr;
			sort();
		}
		public void sort()
		{
			DataRow[] dataRows = new DataRow[arr.Rows.Count];
			int index = 0;
			//Get
			foreach (DataRow row in arr.Rows)
			{
				dataRows[index] = row;
				index++;
			}
			for (int i = 0; i < dataRows.Length; i++)
			{
				for (int j = 0; j < dataRows.Length - 1; j++)
				{
					if (compare(dataRows[j].ItemArray , dataRows[j + 1].ItemArray))
					{
						DataRow temp = dataRows[j];
						dataRows[j] = dataRows[j + 1];
						dataRows[j + 1] = temp;
					}
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
			for (int i = 0; i < dataRows.Length; i++)
			{
				datatable.ImportRow(dataRows[i]);
			}
			arr.Clear();
			arr = datatable;
		}
	}
}

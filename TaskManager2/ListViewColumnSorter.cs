using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace TaskManager2
{
	internal class ListViewColumnSorter : IComparer
	{
		//int SortColumn;
		//SortOrder Order;
		public int SortColumn
		{
			get; set;
		}
		public SortOrder Order
		{
			get; set;
		}
		CaseInsensitiveComparer objectCompare;
		public ListViewColumnSorter()
		{
			SortColumn = 0;
			Order = SortOrder.Unspecified;
			objectCompare = new CaseInsensitiveComparer();
		}
		public int Compare(object x, object y)
		{
			System.Windows.Forms.ListViewItem listViewX = (System.Windows.Forms.ListViewItem)x;
			System.Windows.Forms.ListViewItem listViewY = (System.Windows.Forms.ListViewItem)y;
			int compareResult;
			if (double.TryParse(listViewX.SubItems[SortColumn].Text, out _))
			{
				compareResult = objectCompare.Compare(Convert.ToDouble(listViewX.SubItems[SortColumn].Text), Convert.ToDouble(listViewY.SubItems[SortColumn].Text));
			}
			else
			{
				compareResult = objectCompare.Compare(listViewX.SubItems[SortColumn].Text, listViewY.SubItems[SortColumn].Text);
			}
			
			if (Order == SortOrder.Ascending) return compareResult;
			else if (Order == SortOrder.Descending) return -compareResult;
			return compareResult;

		}
		
	}
}

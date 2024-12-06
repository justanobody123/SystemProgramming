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
		int columnToSort;
		SortOrder orderOfSort;
		CaseInsensitiveComparer objectCompare;
		public ListViewColumnSorter()
		{
			columnToSort = 0;
			orderOfSort = SortOrder.Unspecified;
			objectCompare = new CaseInsensitiveComparer();
		}
		public int Compare(object x, object y)
		{
			System.Windows.Forms.ListViewItem listViewX = (System.Windows.Forms.ListViewItem)x;
			System.Windows.Forms.ListViewItem listViewY = (System.Windows.Forms.ListViewItem)y;
			int compareResult;
			if (double.TryParse(listViewX.SubItems[columnToSort].Text, out _))
			{
				compareResult = objectCompare.Compare(Convert.ToDouble(listViewX.SubItems[columnToSort].Text), Convert.ToDouble(listViewY.SubItems[columnToSort].Text));
			}
			else
			{
				compareResult = objectCompare.Compare(listViewX.SubItems[columnToSort].Text, listViewY.SubItems[columnToSort].Text);
			}
			
			if (orderOfSort == SortOrder.Ascending) return compareResult;
			else if (orderOfSort == SortOrder.Descending) return -compareResult;
			else return compareResult;

		}
		public int SortColumn
		{
			set => columnToSort = value;
			get => columnToSort;
		}
		public SortOrder Order
		{
			get => orderOfSort;
			set => orderOfSort = value;
		}
	}
}

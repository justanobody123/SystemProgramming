using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace TaskManager
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			AllocConsole();
			Console.WriteLine("Hello, world!");
			InitializeComponent();
			//UpdateApplications();
			//UpdateBackgroundProcesses();
			//UpdateWindowsProcesses();
			UpdateProcessesList();
		}
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();

		private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ToolStripMenuItemParametersPin_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = ToolStripMenuItemParametersPin.Checked;
		}

		private void ToolStripMenuItemFileExecute_Click(object sender, EventArgs e)
		{
			Processes.MainForm form = new Processes.MainForm();
			if (form.ShowDialog(this) == DialogResult.OK)
			{
				form.Close();
			}
		}
		//void UpdateApplications()
		//{
		//	foreach (Process process in Process.GetProcesses())
		//	{
		//		//У приложений есть хэндл активного окна
		//		if (process.MainWindowHandle != IntPtr.Zero)
		//		{
		//			ListViewItem item = new ListViewItem(process.ProcessName);
		//			item.Tag = process.Id;
		//			item.SubItems.Add(process.Id.ToString());
		//			item.Group = listViewProcesses.Groups["listViewGroupApplications"];
		//			listViewProcesses.Items.Add(item);
		//		}
		//	}
		//}
		//void UpdateBackgroundProcesses()
		//{
		//	foreach (Process process in Process.GetProcesses())
		//	{
		//		if (process.MainWindowHandle == IntPtr.Zero && process.SessionId != 0)
		//		{
		//			ListViewItem item = new ListViewItem(process.ProcessName);
		//			item.Tag = process.Id;
		//			item.SubItems.Add(process.Id.ToString());
		//			item.Group = listViewProcesses.Groups["listViewGroupBackgroundProcesses"];
		//			listViewProcesses.Items.Add(item);
		//		}
		//	}
		//}
		//void UpdateWindowsProcesses()
		//{
		//	foreach (Process process in Process.GetProcesses())
		//	{
		//		if (process.SessionId == 0)
		//		{
		//			ListViewItem item = new ListViewItem(process.ProcessName);
		//			item.Tag = process.Id;
		//			item.SubItems.Add(process.Id.ToString());
		//			item.Group = listViewProcesses.Groups["listViewGroupWindowsProcesses"];
		//			listViewProcesses.Items.Add(item);
		//		}
		//	}
		//}
		void UpdateProcessesList()
		{
			Dictionary<int, Process> currentProcesses = Process.GetProcesses().ToDictionary(p => p.Id);
			//Идем с конца потому что в процессе удаления индексация коллекции меняется
			for (int i = listViewProcesses.Items.Count - 1; i >= 0; i--)
			{
				ListViewItem item = listViewProcesses.Items[i];
				int processId = (int)item.Tag;
				if (!currentProcesses.ContainsKey(processId))
				{
					listViewProcesses.Items.Remove(item);
				}
			}
			foreach (KeyValuePair<int, Process> kvp in currentProcesses)
			{
				Process process = kvp.Value;
				ListViewItem existingItem = null;
				foreach (ListViewItem item in listViewProcesses.Items)
				{
					if ((int)item.Tag == process.Id)
					{
						existingItem = item;
						break;
					}
				}
				if (existingItem == null)
				{
					ListViewItem newItem = new ListViewItem(process.ProcessName)
					{
						Tag = process.Id,
						Name = process.ProcessName
					};
					newItem.SubItems.Add(process.Id.ToString());
					newItem.Group = DetermineGroup(process);
					listViewProcesses.Items.Add(newItem);
				}
			}
		}
		ListViewGroup DetermineGroup(Process process)
		{
			//У приложения есть хэндл главного окна
			if (process.MainWindowHandle != IntPtr.Zero)
			{
				return listViewProcesses.Groups["listViewGroupApplications"];
			}
			else if (process.SessionId != 0)
			{
				return listViewProcesses.Groups["listViewGroupBackgroundProcesses"];
			}
			else
			{
				return listViewProcesses.Groups["listViewGroupWindowsProcesses"];
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			UpdateProcessesList();
		}

		private void ToolStripMenuItemStopProcess_Click(object sender, EventArgs e)
		{
			if (listViewProcesses.SelectedItems.Count > 0)
			{
				ListViewItem selectedItem = listViewProcesses.SelectedItems[0];
                Console.WriteLine(selectedItem.ToString());
                string processName = selectedItem.Text;
				int processId = (int)selectedItem.Tag;
				try
				{
					Process process = Process.GetProcessById(processId);
					process.Kill();
					process.WaitForExit();
					listViewProcesses.Items.Remove(selectedItem);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error: {ex.Message}", "Error");
				}
			}
		}
	}
}

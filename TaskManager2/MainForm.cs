﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management;
using System.Security.Principal;

namespace TaskManager2
{
	public partial class MainForm : Form
	{
		Dictionary<int, Process> processes;
		ListViewColumnSorter lvColumnSorter;
		public MainForm()
		{
			AllocConsole();
			InitializeComponent();
			LoadProcesses();
			switch (timer.Interval)
			{
				case 1000:
					mainMenuViewRefreshRateHigh.Checked = true;
					break;
				case 2000:
					mainMenuViewRefreshRateNormal.Checked = true;
					break;
				case 3000:
					mainMenuViewRefreshRateLow.Checked = true;
					break;
			}
			AdjustColumnsWidth();
			lvColumnSorter = new ListViewColumnSorter();
			listViewProcesses.ListViewItemSorter = lvColumnSorter;
			//SetColumns();
		}
		void SetColumns()
		{
			listViewProcesses.Columns.Clear();
			listViewProcesses.Columns.Add("Name");
			if (mainMenuViewColumnsPID.Checked)
			{
				listViewProcesses.Columns.Add("PID");
			}
			if (mainMenuViewColumnsOwner.Checked) 
			{
				listViewProcesses.Columns.Add("Owner");
			}
			if (mainMenuViewColumnsFilePath.Checked)
			{
				listViewProcesses.Columns.Add("File path");
			}
        }
		void AdjustColumnsWidth()
		{
			foreach (ColumnHeader ch in this.listViewProcesses.Columns)
			{
				ch.Width = -1;
			}
		}
		int GetColumnIndex(string name)
		{
			for (int i = 0; i < listViewProcesses.Columns.Count; i ++)
			{
				if (name == listViewProcesses.Columns[i].Text) return i;
			}
			return -1;
		}
		[DllImport("kernel32")]
		static extern bool AllocConsole();
		void LoadProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			foreach (KeyValuePair<int, Process> pair in processes)
			{
				AddProcessToListView(pair.Value);
			}
		}
		void AddNewProcesses()
		{
			foreach (KeyValuePair<int, Process> p in processes)
			{
				//if (!listViewProcesses.Items.ContainsKey(p.Key.ToString()))
				bool isFound = false;
				foreach (ListViewItem item in listViewProcesses.Items)
				{
					if ((item.SubItems[1].Text == p.Key.ToString()))
					{
						isFound = true;
					}
				}
				if (!isFound)
				{
					AddProcessToListView(p.Value);
				}
			}
		}
		void RemoveOldProcesses()
		{
			foreach (ListViewItem i in listViewProcesses.Items)
			{
				//Console.WriteLine("Итератор: " + Convert.ToInt32(i.SubItems[1].Text));
				if (!processes.ContainsKey(Convert.ToInt32(i.SubItems[1].Text)))
				{
					//Console.WriteLine("Ремув: " + Convert.ToInt32(i.SubItems[1].Text));
					listViewProcesses.Items.Remove(i);
				}
			}
		}
		void AddProcessToListView(Process p)
		{
			ListViewItem item = new ListViewItem();
			item.Name = item.Text = p.ProcessName.ToString();
			item.SubItems.Add(p.Id.ToString());
			//item.SubItems.Add((p.WorkingSet64 / (1024 * 1024.0)).ToString());
			try
			{
				item.SubItems.Add(p.MainModule.FileName);

			}
			catch (Win32Exception)
			{
				item.SubItems.Add("Access denied");
			}
			catch (InvalidOperationException)
			{

			}
			item.SubItems.Add(GetProcessUser(p));

			listViewProcesses.Items.Add(item);
		}
		void RefreshProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			RemoveOldProcesses();
			AddNewProcesses();
			//Тут надо бы наапдейтить память.
			//UpdateResourcesConsumptionInfo();
		}
		//Возможно, сюда добавится не только память, но и проц, диск и что там еще надо.
		void UpdateResourcesConsumptionInfo()
		{
			foreach (ListViewItem item in listViewProcesses.Items)
			{
				if (item.SubItems[2].Text != (processes[Convert.ToInt32(item.SubItems[1].Text)].WorkingSet64 / (1024 * 1024.0)).ToString())
				{
					item.SubItems[2].Text = (processes[Convert.ToInt32(item.SubItems[1].Text)].WorkingSet64 / (1024 * 1024.0)).ToString();
				}

			}
		}
		void DestroyProcess(int pId)
		{
			processes[pId].Kill();
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			RefreshProcesses();
			toolStripStatusLabelProcessesCounter.Text = $"Processes count: {listViewProcesses.Items.Count.ToString()}; Refresh speed: {timer.Interval}";
			//SetColumns();
		}

		private void mainMenuViewTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = mainMenuViewTopmost.Checked;
		}
		void SetRefreshRateRadioButton(object sender)
		{
			mainMenuViewRefreshRateHigh.Checked = false;
			mainMenuViewRefreshRateLow.Checked = false;
			mainMenuViewRefreshRateNormal.Checked = false;
			(sender as ToolStripMenuItem).Checked = true;
		}

		private void MainMenuViewRefreshRateHigh_Click(object sender, EventArgs e)
		{
			SetRefreshRateRadioButton(sender);
			timer.Interval = 1000;
		}

		private void MainMenuViewRefreshRateNormal_Click(object sender, EventArgs e)
		{
			SetRefreshRateRadioButton(sender);
			timer.Interval = 2000;
		}

		private void MainMenuViewRefreshRateLow_Click(object sender, EventArgs e)
		{
			SetRefreshRateRadioButton(sender);
			timer.Interval = 3000;
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				notifyIcon.Visible = true;
				Hide();
			}
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
			notifyIcon.Visible = false;
		}

		private void mainMenuFileRun_Click(object sender, EventArgs e)
		{
			RunFileDlg(this.Handle, IntPtr.Zero, "C:\\Windows\\System32\\", "Run PD_311", "Task manager! Hello from PD_311", 0);
		}
		[DllImport("shell32.dll", EntryPoint = "#61", CharSet = CharSet.Unicode)]
		public static extern int RunFileDlg
			(
				[In] IntPtr hwnd,
				[In] IntPtr icon,
				[In] string path,
				[In] string title,
				[In] string prompt,
				[In] uint flags
			);
		[DllImport("shell32.dll")]
		static extern IntPtr ShellExecute
			(
			IntPtr hwnd,
			string lpOperation,
			string lpFile,
			string lpParameters,
			string lpDirectory,
			int nCmdShow
			);
		private void destroyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listViewProcesses.SelectedItems.Count > 0)
			{
				DestroyProcess(Convert.ToInt32(listViewProcesses.SelectedItems[0].SubItems[1].Text));
			}

		}

		private void contextMenuProcList_Opening(object sender, CancelEventArgs e)
		{
			toolStripMenuItemDestroy.Enabled = ToolStripMenuItemOpenFileLocation.Enabled = listViewProcesses.SelectedItems.Count > 0;
		}

		private void ToolStripMenuItemOpenFileLocation_Click(object sender, EventArgs e)
		{
			string filename = processes[Convert.ToInt32(listViewProcesses.SelectedItems[0].SubItems[1].Text)].MainModule.FileName;
			Console.WriteLine(filename);
			//filename = filename.Remove(filename.LastIndexOf("\\"));
			//ShellExecute(this.Handle, "open", "explorer.exe", $"/select, \"{filename}\"", "", 4);
			//MessageBox.Show(this, filename, "Location", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Process.Start("explorer", filename);
			Process p = Process.Start(new ProcessStartInfo("explorer.exe", $"/select, \"{filename}\""));
			//Process.GetCurrentProcess().
			IntPtr hwnd = FindWindow(null, p.MainWindowTitle);
			SetWindowPos(hwnd, -1, 0, 0, 0, 0, 1 | 2);
		}
		[DllImport("user32.dll")]
		static extern IntPtr FindWindow
			(
				string lpclassName,
				string lpWindowName
			);
		[DllImport("user32.dll")]
		static extern bool SetWindowPos
			(
				 [In] IntPtr hWnd,
				 [In, Optional] int hWndInsertAfter,
				 [In] int X,
				 [In] int Y,
				 [In] int cx,
				 [In] int cy,
				 [In] uint uFlags
			);

		private void mainMenuViewColumnsRAM_CheckedChanged(object sender, EventArgs e)
		{
			listViewProcesses.Columns[2].Width = mainMenuViewColumnsRAM.Checked ? 90 : 0;
		}

		private void listViewProcesses_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == lvColumnSorter.SortColumn)
			{
				if (!(lvColumnSorter.Order == System.Data.SqlClient.SortOrder.Descending))
				{
					lvColumnSorter.Order = System.Data.SqlClient.SortOrder.Descending;
				}
				else
				{
					lvColumnSorter.Order = System.Data.SqlClient.SortOrder.Ascending;
				}
			}
			else
			{
				lvColumnSorter.SortColumn = e.Column;
				lvColumnSorter.Order = System.Data.SqlClient.SortOrder.Ascending;
			}
			this.listViewProcesses.Sort();
		}
		[DllImport("advapi32.dll", SetLastError = true)]
		static extern bool OpenProcessToken(IntPtr handle, uint DesiredAccess, out IntPtr Tokenhandle);
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool Closehandle(IntPtr hObject);
		static string GetProcessUser(Process process)
		{
			IntPtr processHandle = IntPtr.Zero;
			string userName = "N/A";
			try
			{
				OpenProcessToken(process.Handle, 8, out processHandle);
				using (WindowsIdentity wi = new WindowsIdentity(processHandle))
				{
					userName = wi.Name;
				}
			}
			catch (Win32Exception)
			{

			}
			catch(InvalidOperationException) 
			{ }
			return userName;
		}
	}
}

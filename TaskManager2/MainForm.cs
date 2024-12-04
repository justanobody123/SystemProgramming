using System;
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

namespace TaskManager2
{
	public partial class MainForm : Form
	{
		Dictionary<int, Process> processes;
		public MainForm()
		{
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
		}
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
				if (!listViewProcesses.Items.ContainsKey(p.Key.ToString()))
				{
					AddProcessToListView(p.Value);
				}
			}
		}
		void RemoveOldProcesses()
		{
			foreach (ListViewItem i in listViewProcesses.Items)
			{
				if (!processes.ContainsKey(Convert.ToInt32(i.SubItems[0].Text)))
				{
					listViewProcesses.Items.Remove(i);
				}
			}
		}
		void AddProcessToListView(Process p)
		{
			ListViewItem item = new ListViewItem();
			item.Name = item.Text = p.Id.ToString();
			item.SubItems.Add(p.ProcessName);
			listViewProcesses.Items.Add(item);
		}
		void RefreshProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			RemoveOldProcesses();
			AddNewProcesses();
		}
		void DestroyProcess(int pId)
		{
			processes[pId].Kill();
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			RefreshProcesses();
			toolStripStatusLabelProcessesCounter.Text = $"Processes count: {listViewProcesses.Items.Count.ToString()}; Refresh speed: {timer.Interval}";
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

		private void destroyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listViewProcesses.SelectedItems.Count > 0) 
			{
				DestroyProcess(Convert.ToInt32(listViewProcesses.SelectedItems[0].Name));
			}
			
		}

		private void contextMenuProcList_Opening(object sender, CancelEventArgs e)
		{
			toolStripMenuItemDestroy.Enabled = ToolStripMenuItemOpenFileLocation.Enabled = listViewProcesses.SelectedItems.Count > 0;
		}
	}
}

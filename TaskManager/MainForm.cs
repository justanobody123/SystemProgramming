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

namespace TaskManager
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			AllocConsole();
            Console.WriteLine("Hello, world!");
            InitializeComponent();
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
	}
}

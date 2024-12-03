namespace TaskManager2
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuFileRun = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewHide = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewSelectColumns = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mainMenuViewRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewRefreshRate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.MainMenuViewRefreshRateHigh = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuViewRefreshRateNormal = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuViewRefreshRateLow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripStatusLabelProcessesCounter = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageProcesses = new System.Windows.Forms.TabPage();
			this.tabPagePerformance = new System.Windows.Forms.TabPage();
			this.listViewProcesses = new System.Windows.Forms.ListView();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mainMenu.SuspendLayout();
			this.statusStripMain.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageProcesses.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(800, 30);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuFileRun,
            this.toolStripSeparator1,
            this.mainMenuFileExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mainMenuFileRun
			// 
			this.mainMenuFileRun.Name = "mainMenuFileRun";
			this.mainMenuFileRun.Size = new System.Drawing.Size(224, 26);
			this.mainMenuFileRun.Text = "Run";
			// 
			// mainMenuFileExit
			// 
			this.mainMenuFileExit.Name = "mainMenuFileExit";
			this.mainMenuFileExit.Size = new System.Drawing.Size(224, 26);
			this.mainMenuFileExit.Text = "Exit";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuViewTopmost,
            this.mainMenuViewHide,
            this.toolStripSeparator2,
            this.mainMenuViewSelectColumns,
            this.toolStripSeparator3,
            this.mainMenuViewRefresh,
            this.mainMenuViewRefreshRate});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// mainMenuViewTopmost
			// 
			this.mainMenuViewTopmost.CheckOnClick = true;
			this.mainMenuViewTopmost.Name = "mainMenuViewTopmost";
			this.mainMenuViewTopmost.Size = new System.Drawing.Size(237, 26);
			this.mainMenuViewTopmost.Text = "Topmost";
			this.mainMenuViewTopmost.CheckedChanged += new System.EventHandler(this.mainMenuViewTopmost_CheckedChanged);
			// 
			// mainMenuViewHide
			// 
			this.mainMenuViewHide.CheckOnClick = true;
			this.mainMenuViewHide.Name = "mainMenuViewHide";
			this.mainMenuViewHide.Size = new System.Drawing.Size(237, 26);
			this.mainMenuViewHide.Text = "Hide when minimized";
			// 
			// mainMenuViewSelectColumns
			// 
			this.mainMenuViewSelectColumns.Name = "mainMenuViewSelectColumns";
			this.mainMenuViewSelectColumns.Size = new System.Drawing.Size(237, 26);
			this.mainMenuViewSelectColumns.Text = "Select columns";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
			// 
			// mainMenuViewRefresh
			// 
			this.mainMenuViewRefresh.Name = "mainMenuViewRefresh";
			this.mainMenuViewRefresh.Size = new System.Drawing.Size(237, 26);
			this.mainMenuViewRefresh.Text = "Refresh";
			// 
			// mainMenuViewRefreshRate
			// 
			this.mainMenuViewRefreshRate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuViewRefreshRateHigh,
            this.MainMenuViewRefreshRateNormal,
            this.MainMenuViewRefreshRateLow});
			this.mainMenuViewRefreshRate.Name = "mainMenuViewRefreshRate";
			this.mainMenuViewRefreshRate.Size = new System.Drawing.Size(237, 26);
			this.mainMenuViewRefreshRate.Text = "Refresh rate";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(234, 6);
			// 
			// statusStripMain
			// 
			this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelProcessesCounter});
			this.statusStripMain.Location = new System.Drawing.Point(0, 424);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(800, 26);
			this.statusStripMain.TabIndex = 1;
			this.statusStripMain.Text = "statusStrip1";
			// 
			// MainMenuViewRefreshRateHigh
			// 
			this.MainMenuViewRefreshRateHigh.CheckOnClick = true;
			this.MainMenuViewRefreshRateHigh.Name = "MainMenuViewRefreshRateHigh";
			this.MainMenuViewRefreshRateHigh.Size = new System.Drawing.Size(224, 26);
			this.MainMenuViewRefreshRateHigh.Text = "High";
			this.MainMenuViewRefreshRateHigh.Click += new System.EventHandler(this.MainMenuViewRefreshRateHigh_Click);
			// 
			// MainMenuViewRefreshRateNormal
			// 
			this.MainMenuViewRefreshRateNormal.CheckOnClick = true;
			this.MainMenuViewRefreshRateNormal.Name = "MainMenuViewRefreshRateNormal";
			this.MainMenuViewRefreshRateNormal.Size = new System.Drawing.Size(224, 26);
			this.MainMenuViewRefreshRateNormal.Text = "Normal";
			this.MainMenuViewRefreshRateNormal.Click += new System.EventHandler(this.MainMenuViewRefreshRateNormal_Click);
			// 
			// MainMenuViewRefreshRateLow
			// 
			this.MainMenuViewRefreshRateLow.CheckOnClick = true;
			this.MainMenuViewRefreshRateLow.Name = "MainMenuViewRefreshRateLow";
			this.MainMenuViewRefreshRateLow.Size = new System.Drawing.Size(224, 26);
			this.MainMenuViewRefreshRateLow.Text = "Low";
			this.MainMenuViewRefreshRateLow.Click += new System.EventHandler(this.MainMenuViewRefreshRateLow_Click);
			// 
			// toolStripStatusLabelProcessesCounter
			// 
			this.toolStripStatusLabelProcessesCounter.Name = "toolStripStatusLabelProcessesCounter";
			this.toolStripStatusLabelProcessesCounter.Size = new System.Drawing.Size(151, 20);
			this.toolStripStatusLabelProcessesCounter.Text = "toolStripStatusLabel1";
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageProcesses);
			this.tabControl.Controls.Add(this.tabPagePerformance);
			this.tabControl.Location = new System.Drawing.Point(13, 32);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(787, 389);
			this.tabControl.TabIndex = 2;
			// 
			// tabPageProcesses
			// 
			this.tabPageProcesses.Controls.Add(this.listViewProcesses);
			this.tabPageProcesses.Location = new System.Drawing.Point(4, 25);
			this.tabPageProcesses.Name = "tabPageProcesses";
			this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProcesses.Size = new System.Drawing.Size(779, 360);
			this.tabPageProcesses.TabIndex = 0;
			this.tabPageProcesses.Text = "Processes";
			this.tabPageProcesses.UseVisualStyleBackColor = true;
			// 
			// tabPagePerformance
			// 
			this.tabPagePerformance.Location = new System.Drawing.Point(4, 25);
			this.tabPagePerformance.Name = "tabPagePerformance";
			this.tabPagePerformance.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePerformance.Size = new System.Drawing.Size(779, 360);
			this.tabPagePerformance.TabIndex = 1;
			this.tabPagePerformance.Text = "Performance";
			this.tabPagePerformance.UseVisualStyleBackColor = true;
			// 
			// listViewProcesses
			// 
			this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPID,
            this.columnHeaderName});
			this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewProcesses.FullRowSelect = true;
			this.listViewProcesses.GridLines = true;
			this.listViewProcesses.HideSelection = false;
			this.listViewProcesses.Location = new System.Drawing.Point(3, 3);
			this.listViewProcesses.MultiSelect = false;
			this.listViewProcesses.Name = "listViewProcesses";
			this.listViewProcesses.Size = new System.Drawing.Size(773, 354);
			this.listViewProcesses.TabIndex = 0;
			this.listViewProcesses.UseCompatibleStateImageBehavior = false;
			this.listViewProcesses.View = System.Windows.Forms.View.Details;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "Name";
			this.columnHeaderName.Width = 120;
			// 
			// columnHeaderPID
			// 
			this.columnHeaderPID.Text = "PID";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "MainForm";
			this.Text = "Task Manager";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.statusStripMain.ResumeLayout(false);
			this.statusStripMain.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageProcesses.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mainMenuFileRun;
		private System.Windows.Forms.ToolStripMenuItem mainMenuFileExit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewTopmost;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewHide;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewSelectColumns;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRefresh;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRefreshRate;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.ToolStripMenuItem MainMenuViewRefreshRateHigh;
		private System.Windows.Forms.ToolStripMenuItem MainMenuViewRefreshRateNormal;
		private System.Windows.Forms.ToolStripMenuItem MainMenuViewRefreshRateLow;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProcessesCounter;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageProcesses;
		private System.Windows.Forms.TabPage tabPagePerformance;
		private System.Windows.Forms.ListView listViewProcesses;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ColumnHeader columnHeaderPID;
	}
}


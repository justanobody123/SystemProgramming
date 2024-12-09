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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuFileRun = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mainMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewHide = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mainMenuViewSelectColumns = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewColumnsPID = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewColumnsOwner = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewColumnsFilePath = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewColumnsRAM = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mainMenuViewRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewRefreshRate = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewRefreshRateHigh = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewRefreshRateNormal = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuViewRefreshRateLow = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelProcessesCounter = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageProcesses = new System.Windows.Forms.TabPage();
			this.listViewProcesses = new System.Windows.Forms.ListView();
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderRAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderCpuUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuProcList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItemOpenFileLocation = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemDestroy = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPagePerformance = new System.Windows.Forms.TabPage();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.mainMenu.SuspendLayout();
			this.statusStripMain.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageProcesses.SuspendLayout();
			this.contextMenuProcList.SuspendLayout();
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
			this.mainMenu.Size = new System.Drawing.Size(800, 28);
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
			this.mainMenuFileRun.Size = new System.Drawing.Size(117, 26);
			this.mainMenuFileRun.Text = "Run";
			this.mainMenuFileRun.Click += new System.EventHandler(this.mainMenuFileRun_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
			// 
			// mainMenuFileExit
			// 
			this.mainMenuFileExit.Name = "mainMenuFileExit";
			this.mainMenuFileExit.Size = new System.Drawing.Size(117, 26);
			this.mainMenuFileExit.Text = "Exit";
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
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
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
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
			// 
			// mainMenuViewSelectColumns
			// 
			this.mainMenuViewSelectColumns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuViewColumnsPID,
            this.mainMenuViewColumnsOwner,
            this.mainMenuViewColumnsFilePath,
            this.mainMenuViewColumnsRAM});
			this.mainMenuViewSelectColumns.Name = "mainMenuViewSelectColumns";
			this.mainMenuViewSelectColumns.Size = new System.Drawing.Size(237, 26);
			this.mainMenuViewSelectColumns.Text = "Select columns";
			// 
			// mainMenuViewColumnsPID
			// 
			this.mainMenuViewColumnsPID.CheckOnClick = true;
			this.mainMenuViewColumnsPID.Name = "mainMenuViewColumnsPID";
			this.mainMenuViewColumnsPID.Size = new System.Drawing.Size(224, 26);
			this.mainMenuViewColumnsPID.Text = "PID";
			this.mainMenuViewColumnsPID.CheckedChanged += new System.EventHandler(this.mainMenuViewColumns_CheckedChanged);
			this.mainMenuViewColumnsPID.Click += new System.EventHandler(this.mainMenuViewColumns_Click);
			// 
			// mainMenuViewColumnsOwner
			// 
			this.mainMenuViewColumnsOwner.CheckOnClick = true;
			this.mainMenuViewColumnsOwner.Name = "mainMenuViewColumnsOwner";
			this.mainMenuViewColumnsOwner.Size = new System.Drawing.Size(224, 26);
			this.mainMenuViewColumnsOwner.Text = "Owner";
			this.mainMenuViewColumnsOwner.CheckedChanged += new System.EventHandler(this.mainMenuViewColumns_CheckedChanged);
			this.mainMenuViewColumnsOwner.Click += new System.EventHandler(this.mainMenuViewColumns_Click);
			// 
			// mainMenuViewColumnsFilePath
			// 
			this.mainMenuViewColumnsFilePath.CheckOnClick = true;
			this.mainMenuViewColumnsFilePath.Name = "mainMenuViewColumnsFilePath";
			this.mainMenuViewColumnsFilePath.Size = new System.Drawing.Size(224, 26);
			this.mainMenuViewColumnsFilePath.Text = "Path";
			this.mainMenuViewColumnsFilePath.CheckedChanged += new System.EventHandler(this.mainMenuViewColumns_CheckedChanged);
			this.mainMenuViewColumnsFilePath.Click += new System.EventHandler(this.mainMenuViewColumns_Click);
			// 
			// mainMenuViewColumnsRAM
			// 
			this.mainMenuViewColumnsRAM.CheckOnClick = true;
			this.mainMenuViewColumnsRAM.Name = "mainMenuViewColumnsRAM";
			this.mainMenuViewColumnsRAM.Size = new System.Drawing.Size(224, 26);
			this.mainMenuViewColumnsRAM.Text = "RAM";
			this.mainMenuViewColumnsRAM.CheckedChanged += new System.EventHandler(this.mainMenuViewColumns_CheckedChanged);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(234, 6);
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
            this.mainMenuViewRefreshRateHigh,
            this.mainMenuViewRefreshRateNormal,
            this.mainMenuViewRefreshRateLow});
			this.mainMenuViewRefreshRate.Name = "mainMenuViewRefreshRate";
			this.mainMenuViewRefreshRate.Size = new System.Drawing.Size(237, 26);
			this.mainMenuViewRefreshRate.Text = "Refresh rate";
			// 
			// mainMenuViewRefreshRateHigh
			// 
			this.mainMenuViewRefreshRateHigh.CheckOnClick = true;
			this.mainMenuViewRefreshRateHigh.Name = "mainMenuViewRefreshRateHigh";
			this.mainMenuViewRefreshRateHigh.Size = new System.Drawing.Size(224, 26);
			this.mainMenuViewRefreshRateHigh.Text = "High";
			this.mainMenuViewRefreshRateHigh.Click += new System.EventHandler(this.MainMenuViewRefreshRateHigh_Click);
			// 
			// mainMenuViewRefreshRateNormal
			// 
			this.mainMenuViewRefreshRateNormal.CheckOnClick = true;
			this.mainMenuViewRefreshRateNormal.Name = "mainMenuViewRefreshRateNormal";
			this.mainMenuViewRefreshRateNormal.Size = new System.Drawing.Size(224, 26);
			this.mainMenuViewRefreshRateNormal.Text = "Normal";
			this.mainMenuViewRefreshRateNormal.Click += new System.EventHandler(this.MainMenuViewRefreshRateNormal_Click);
			// 
			// mainMenuViewRefreshRateLow
			// 
			this.mainMenuViewRefreshRateLow.CheckOnClick = true;
			this.mainMenuViewRefreshRateLow.Name = "mainMenuViewRefreshRateLow";
			this.mainMenuViewRefreshRateLow.Size = new System.Drawing.Size(224, 26);
			this.mainMenuViewRefreshRateLow.Text = "Low";
			this.mainMenuViewRefreshRateLow.Click += new System.EventHandler(this.MainMenuViewRefreshRateLow_Click);
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
			// listViewProcesses
			// 
			this.listViewProcesses.AllowColumnReorder = true;
			this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPID,
            this.columnHeaderRAM,
            this.columnHeaderFilePath,
            this.columnHeaderUser,
            this.columnHeaderCpuUsage});
			this.listViewProcesses.ContextMenuStrip = this.contextMenuProcList;
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
			this.listViewProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProcesses_ColumnClick);
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
			// columnHeaderRAM
			// 
			this.columnHeaderRAM.Text = "RAM";
			this.columnHeaderRAM.Width = 90;
			// 
			// columnHeaderFilePath
			// 
			this.columnHeaderFilePath.Text = "Path";
			// 
			// columnHeaderUser
			// 
			this.columnHeaderUser.Text = "User";
			// 
			// columnHeaderCpuUsage
			// 
			this.columnHeaderCpuUsage.Text = "ColumnHeaderCpuUsage";
			// 
			// contextMenuProcList
			// 
			this.contextMenuProcList.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuProcList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpenFileLocation,
            this.toolStripSeparator4,
            this.toolStripMenuItemDestroy});
			this.contextMenuProcList.Name = "contextMenuProcList";
			this.contextMenuProcList.Size = new System.Drawing.Size(198, 58);
			this.contextMenuProcList.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuProcList_Opening);
			// 
			// ToolStripMenuItemOpenFileLocation
			// 
			this.ToolStripMenuItemOpenFileLocation.Name = "ToolStripMenuItemOpenFileLocation";
			this.ToolStripMenuItemOpenFileLocation.Size = new System.Drawing.Size(197, 24);
			this.ToolStripMenuItemOpenFileLocation.Text = "Open file location";
			this.ToolStripMenuItemOpenFileLocation.Click += new System.EventHandler(this.ToolStripMenuItemOpenFileLocation_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(194, 6);
			// 
			// toolStripMenuItemDestroy
			// 
			this.toolStripMenuItemDestroy.Name = "toolStripMenuItemDestroy";
			this.toolStripMenuItemDestroy.Size = new System.Drawing.Size(197, 24);
			this.toolStripMenuItemDestroy.Text = "Destroy";
			this.toolStripMenuItemDestroy.Click += new System.EventHandler(this.destroyToolStripMenuItem_Click);
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
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon";
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
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
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.statusStripMain.ResumeLayout(false);
			this.statusStripMain.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageProcesses.ResumeLayout(false);
			this.contextMenuProcList.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRefreshRateHigh;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRefreshRateNormal;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewRefreshRateLow;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProcessesCounter;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageProcesses;
		private System.Windows.Forms.TabPage tabPagePerformance;
		private System.Windows.Forms.ListView listViewProcesses;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ColumnHeader columnHeaderPID;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewColumnsRAM;
		private System.Windows.Forms.ContextMenuStrip contextMenuProcList;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpenFileLocation;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDestroy;
		private System.Windows.Forms.ColumnHeader columnHeaderRAM;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewColumnsFilePath;
		private System.Windows.Forms.ColumnHeader columnHeaderFilePath;
		private System.Windows.Forms.ColumnHeader columnHeaderUser;
		private System.Windows.Forms.ColumnHeader columnHeaderCpuUsage;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewColumnsPID;
		private System.Windows.Forms.ToolStripMenuItem mainMenuViewColumnsOwner;
	}
}


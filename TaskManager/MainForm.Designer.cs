namespace TaskManager
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemFileExecute = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemParameters = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemParametersPin = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageProcesses = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.menuStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.White;
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemParameters});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 30);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// ToolStripMenuItemFile
			// 
			this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFileExecute,
            this.ToolStripMenuItemFileExit});
			this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
			this.ToolStripMenuItemFile.Size = new System.Drawing.Size(59, 26);
			this.ToolStripMenuItemFile.Text = "Файл";
			// 
			// ToolStripMenuItemFileExecute
			// 
			this.ToolStripMenuItemFileExecute.Name = "ToolStripMenuItemFileExecute";
			this.ToolStripMenuItemFileExecute.Size = new System.Drawing.Size(259, 26);
			this.ToolStripMenuItemFileExecute.Text = "Запустить новую задачу";
			// 
			// ToolStripMenuItemFileExit
			// 
			this.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
			this.ToolStripMenuItemFileExit.Size = new System.Drawing.Size(259, 26);
			this.ToolStripMenuItemFileExit.Text = "Выход";
			this.ToolStripMenuItemFileExit.Click += new System.EventHandler(this.ToolStripMenuItemFileExit_Click);
			// 
			// ToolStripMenuItemParameters
			// 
			this.ToolStripMenuItemParameters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemParametersPin});
			this.ToolStripMenuItemParameters.Name = "ToolStripMenuItemParameters";
			this.ToolStripMenuItemParameters.Size = new System.Drawing.Size(104, 26);
			this.ToolStripMenuItemParameters.Text = "Параметры";
			// 
			// ToolStripMenuItemParametersPin
			// 
			this.ToolStripMenuItemParametersPin.CheckOnClick = true;
			this.ToolStripMenuItemParametersPin.Name = "ToolStripMenuItemParametersPin";
			this.ToolStripMenuItemParametersPin.Size = new System.Drawing.Size(259, 26);
			this.ToolStripMenuItemParametersPin.Text = "Поверх остальных окон";
			this.ToolStripMenuItemParametersPin.CheckedChanged += new System.EventHandler(this.ToolStripMenuItemParametersPin_CheckedChanged);
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageProcesses);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Location = new System.Drawing.Point(0, 32);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 406);
			this.tabControl.TabIndex = 1;
			// 
			// tabPageProcesses
			// 
			this.tabPageProcesses.Location = new System.Drawing.Point(4, 25);
			this.tabPageProcesses.Name = "tabPageProcesses";
			this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProcesses.Size = new System.Drawing.Size(792, 377);
			this.tabPageProcesses.TabIndex = 0;
			this.tabPageProcesses.Text = "Процессы";
			this.tabPageProcesses.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 377);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "Task Manager";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExecute;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemParameters;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemParametersPin;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageProcesses;
		private System.Windows.Forms.TabPage tabPage2;
	}
}


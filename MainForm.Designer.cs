/*
 * Created by SharpDevelop.
 * User: pannengchong
 * Date: 2017/12/5
 * Time: 11:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MagicApp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnStartTask;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox textExcelFile;
		private System.Windows.Forms.Button btnSelectFolder;
		private System.Windows.Forms.TextBox textFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog openExcelDialog;
		private System.Windows.Forms.ProgressBar progressBarAll;
		private System.Windows.Forms.Timer timerProgress;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.progressBarAll = new System.Windows.Forms.ProgressBar();
			this.btnStartTask = new System.Windows.Forms.Button();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.textExcelFile = new System.Windows.Forms.TextBox();
			this.btnSelectFolder = new System.Windows.Forms.Button();
			this.textFolder = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openExcelDialog = new System.Windows.Forms.OpenFileDialog();
			this.timerProgress = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.progressBarAll);
			this.groupBox1.Controls.Add(this.btnStartTask);
			this.groupBox1.Controls.Add(this.btnSelectFile);
			this.groupBox1.Controls.Add(this.textExcelFile);
			this.groupBox1.Controls.Add(this.btnSelectFolder);
			this.groupBox1.Controls.Add(this.textFolder);
			this.groupBox1.Location = new System.Drawing.Point(12, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1119, 146);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// progressBarAll
			// 
			this.progressBarAll.Location = new System.Drawing.Point(25, 106);
			this.progressBarAll.Name = "progressBarAll";
			this.progressBarAll.Size = new System.Drawing.Size(835, 23);
			this.progressBarAll.TabIndex = 5;
			// 
			// btnStartTask
			// 
			this.btnStartTask.Location = new System.Drawing.Point(877, 106);
			this.btnStartTask.Name = "btnStartTask";
			this.btnStartTask.Size = new System.Drawing.Size(215, 23);
			this.btnStartTask.TabIndex = 4;
			this.btnStartTask.Text = "开始执行";
			this.btnStartTask.UseVisualStyleBackColor = true;
			this.btnStartTask.Click += new System.EventHandler(this.BtnStartTaskClick);
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(878, 62);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(215, 23);
			this.btnSelectFile.TabIndex = 3;
			this.btnSelectFile.Text = "选择文件";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFileClick);
			// 
			// textExcelFile
			// 
			this.textExcelFile.Location = new System.Drawing.Point(26, 62);
			this.textExcelFile.Name = "textExcelFile";
			this.textExcelFile.Size = new System.Drawing.Size(835, 21);
			this.textExcelFile.TabIndex = 2;
			this.textExcelFile.Text = "请选择核对的文件";
			// 
			// btnSelectFolder
			// 
			this.btnSelectFolder.Location = new System.Drawing.Point(877, 21);
			this.btnSelectFolder.Name = "btnSelectFolder";
			this.btnSelectFolder.Size = new System.Drawing.Size(215, 23);
			this.btnSelectFolder.TabIndex = 1;
			this.btnSelectFolder.Text = "选择文件夹";
			this.btnSelectFolder.UseVisualStyleBackColor = true;
			this.btnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolderClick);
			// 
			// textFolder
			// 
			this.textFolder.Location = new System.Drawing.Point(25, 21);
			this.textFolder.Name = "textFolder";
			this.textFolder.Size = new System.Drawing.Size(835, 21);
			this.textFolder.TabIndex = 0;
			this.textFolder.Text = "请选择文件夹";
			// 
			// openExcelDialog
			// 
			this.openExcelDialog.FileName = "选择文件";
			// 
			// timerProgress
			// 
			this.timerProgress.Interval = 1000;
			this.timerProgress.Tick += new System.EventHandler(this.TimerProgressTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1162, 627);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "MagicApp";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}

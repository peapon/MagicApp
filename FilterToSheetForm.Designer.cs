/*
 * 由SharpDevelop创建。
 * 用户： pannengchong
 * 日期: 2017/12/6
 * 时间: 13:41
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace MagicApp
{
	partial class FilterToSheetForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ProgressBar progressBarAll;
		private System.Windows.Forms.Button btnStartTask;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox textExcelFile;
		private System.Windows.Forms.OpenFileDialog openXlsFileDialog;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.progressBarAll = new System.Windows.Forms.ProgressBar();
			this.btnStartTask = new System.Windows.Forms.Button();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.textExcelFile = new System.Windows.Forms.TextBox();
			this.openXlsFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.progressBarAll);
			this.groupBox1.Controls.Add(this.btnStartTask);
			this.groupBox1.Controls.Add(this.btnSelectFile);
			this.groupBox1.Controls.Add(this.textExcelFile);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1119, 146);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// progressBarAll
			// 
			this.progressBarAll.Location = new System.Drawing.Point(21, 70);
			this.progressBarAll.Name = "progressBarAll";
			this.progressBarAll.Size = new System.Drawing.Size(835, 23);
			this.progressBarAll.TabIndex = 5;
			// 
			// btnStartTask
			// 
			this.btnStartTask.Location = new System.Drawing.Point(873, 70);
			this.btnStartTask.Name = "btnStartTask";
			this.btnStartTask.Size = new System.Drawing.Size(215, 23);
			this.btnStartTask.TabIndex = 4;
			this.btnStartTask.Text = "开始执行";
			this.btnStartTask.UseVisualStyleBackColor = true;
			this.btnStartTask.Click += new System.EventHandler(this.BtnStartTaskClick);
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(874, 26);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(215, 23);
			this.btnSelectFile.TabIndex = 3;
			this.btnSelectFile.Text = "选择文件";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFileClick);
			// 
			// textExcelFile
			// 
			this.textExcelFile.Location = new System.Drawing.Point(22, 26);
			this.textExcelFile.Name = "textExcelFile";
			this.textExcelFile.Size = new System.Drawing.Size(835, 21);
			this.textExcelFile.TabIndex = 2;
			// 
			// FilterToSheetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 712);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FilterToSheetForm";
			this.Text = "FilterToSheetForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}

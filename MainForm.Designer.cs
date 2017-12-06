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
		private System.Windows.Forms.TabControl tabCtrlMain;
		private System.Windows.Forms.TabPage tabRename;
		private System.Windows.Forms.TabPage tabFilterToSheet;
		private MagicApp.RenameBySNForm rsForm;
		private MagicApp.FilterToSheetForm ftsForm;
		
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
		/// private void InitializeComponent()
		private void InitializeComponent()
		{
			this.tabCtrlMain = new System.Windows.Forms.TabControl();
			this.tabRename = new System.Windows.Forms.TabPage();
			this.rsForm = new MagicApp.RenameBySNForm();
			this.rsForm.TopLevel = false;
			this.ftsForm = new MagicApp.FilterToSheetForm();
			this.ftsForm.TopLevel = false;
			
			this.tabFilterToSheet = new System.Windows.Forms.TabPage();
			this.tabCtrlMain.SuspendLayout();
			this.tabRename.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCtrlMain
			// 
			this.tabCtrlMain.Controls.Add(this.tabRename);
			this.tabCtrlMain.Controls.Add(this.tabFilterToSheet);
			this.tabCtrlMain.Location = new System.Drawing.Point(1, 1);
			this.tabCtrlMain.Name = "tabCtrlMain";
			this.tabCtrlMain.SelectedIndex = 0;
			this.tabCtrlMain.Size = new System.Drawing.Size(1162, 625);
			this.tabCtrlMain.TabIndex = 0;
			// 
			// tabRename
			// 
			this.tabRename.Controls.Add(this.rsForm);
			this.tabRename.Location = new System.Drawing.Point(4, 22);
			this.tabRename.Name = "tabRename";
			this.tabRename.Padding = new System.Windows.Forms.Padding(3);
			this.tabRename.Size = new System.Drawing.Size(1154, 599);
			this.tabRename.TabIndex = 0;
			this.tabRename.Text = "根据清单重命名";
			this.tabRename.UseVisualStyleBackColor = true;
			// 
			// form
			// 
			this.rsForm.ClientSize = new System.Drawing.Size(1162, 627);
			this.rsForm.ControlBox = false;
			this.rsForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.rsForm.Location = new System.Drawing.Point(0, 0);
			this.rsForm.MaximizeBox = false;
			this.rsForm.MinimizeBox = false;
			this.rsForm.Name = "form";
			this.rsForm.Text = "MagicApp";
			this.rsForm.Visible = true;
			
			this.ftsForm.ClientSize = new System.Drawing.Size(1162, 627);
			this.ftsForm.ControlBox = false;
			this.ftsForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.ftsForm.Location = new System.Drawing.Point(0, 0);
			this.ftsForm.MaximizeBox = false;
			this.ftsForm.MinimizeBox = false;
			this.ftsForm.Name = "form";
			this.ftsForm.Text = "MagicApp";
			this.ftsForm.Visible = true;
			
			
			// 
			// tabFilterToSheet
			// 
			this.tabFilterToSheet.Controls.Add(this.ftsForm);
			this.tabFilterToSheet.Location = new System.Drawing.Point(4, 22);
			this.tabFilterToSheet.Name = "tabFilterToSheet";
			this.tabFilterToSheet.Padding = new System.Windows.Forms.Padding(3);
			this.tabFilterToSheet.Size = new System.Drawing.Size(1154, 599);
			this.tabFilterToSheet.TabIndex = 1;
			this.tabFilterToSheet.Text = "筛选到多个Sheet";
			this.tabFilterToSheet.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1162, 627);
			this.Controls.Add(this.tabCtrlMain);
			this.Name = "MainForm";
			this.Text = "MagicApp";
			this.tabCtrlMain.ResumeLayout(false);
			this.tabRename.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}

/*
 * 由SharpDevelop创建。
 * 用户： pannengchong
 * 日期: 2017/12/6
 * 时间: 13:09
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagicApp
{
	/// <summary>
	/// Description of RenameBySNForm.
	/// </summary>
	public partial class RenameBySNForm : Form
	{
		public RenameBySNForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		MagicProcessor mp = new MagicProcessor();
		
		
		void BtnSelectFolderClick(object sender, EventArgs e)
		{
			if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				textFolder.Text = folderBrowserDialog.SelectedPath;
			}
		}
		void BtnSelectFileClick(object sender, EventArgs e)
		{
			openExcelDialog.Filter="Excel 2003|*.xls|Excel 2007+|*.xlsx";
			if(openExcelDialog.ShowDialog() == DialogResult.OK )
			{
				textExcelFile.Text = openExcelDialog.FileName;
			}
		}
		void BtnStartTaskClick(object sender, EventArgs e)
		{
			string excel = textExcelFile.Text;
			string folder = textFolder.Text;
			if(excel == "" || folder == "")
			{
				MessageBox.Show("没有选择文件或文件夹，或者是选择的文件或文件夹不正确，请重新选择！！！","警告");
				return;
			}
			timerProgress.Start();
			//Thread.Sleep(1000);
			mp.Process(excel, folder);
			//Thread.Sleep(1000);
			timerProgress.Stop();
		}
		void TimerProgressTick(object sender, EventArgs e)
		{
			progressBarAll.Maximum = mp.GetTotal();
			progressBarAll.Value = mp.GetCurrent();
		}
		
	}
}

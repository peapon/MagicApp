/*
 * Created by SharpDevelop.
 * User: pannengchong
 * Date: 2017/12/5
 * Time: 11:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace MagicApp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MagicProcessor mp = new MagicProcessor();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
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

/*
 * 由SharpDevelop创建。
 * 用户： pannengchong
 * 日期: 2017/12/6
 * 时间: 13:41
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagicApp
{
	/// <summary>
	/// Description of FilterToSheetForm.
	/// </summary>
	public partial class FilterToSheetForm : Form
	{
		public FilterToSheetForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSelectFileClick(object sender, EventArgs e)
		{
			openXlsFileDialog.Filter="Excel 2003|*.xls|Excel 2007+|*.xlsx";
			if(openXlsFileDialog.ShowDialog() == DialogResult.OK )
			{
				textExcelFile.Text = openXlsFileDialog.FileName;
			}
		}
		void BtnStartTaskClick(object sender, EventArgs e)
		{
			FiltToSheetProcessor ftsp = new FiltToSheetProcessor();
			ftsp.Process(textExcelFile.Text);
		}
	}
}

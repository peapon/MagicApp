/*
 * 由SharpDevelop创建。
 * 用户： pannengchong
 * 日期: 2017/12/6
 * 时间: 14:42
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using System.Collections.Generic;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.IO;

namespace MagicApp
{
	/// <summary>
	/// Description of FiltToSheetProcessor.
	/// </summary>
	public class FiltToSheetProcessor
	{
		private string fileName = null;
		public FiltToSheetProcessor()
		{
		}
		
		public int Process(string excel)
		{
			fileName = excel;
			ConfigReader cr = new ConfigReader();
			string columnToBefiltered = cr.GetFilterColumn("config.xml");
			string sheet = cr.GetFilterSheet("config.xml");
			bool isFirstRowTitle = cr.IsFirstRowColumn("config.xml");
			
			ExcelHelper eh = new ExcelHelper(fileName);
			DataTable dt = eh.ExcelToDataTable(sheet,isFirstRowTitle);
			
			List<string> catogories = GetAllCatogories(dt, columnToBefiltered);
			string fName = "out.xlsx";
			int count = 0;
			IWorkbook workbook = null;
			
			if (fName.IndexOf(".xlsx") > 0) // 2007版本
				workbook = new XSSFWorkbook();
            else if (fName.IndexOf(".xls") > 0) // 2003版本
            	workbook = new HSSFWorkbook();
            
			foreach(var cat in catogories)
			{
				count += Exacute(dt,workbook,eh,columnToBefiltered,cat);
			}
			
			if (File.Exists(fName))
            {
                File.Delete(fName);
            }
            using (FileStream file = new FileStream(fName, FileMode.Create))
            {
                workbook.Write(file);　　//创建Excel文件。
                file.Close();
            }
			return count;
		}
		
		private List<string> GetAllCatogories(DataTable dt, string filterColumn)
		{
			DataTable dt2 = dt.DefaultView.ToTable(true, filterColumn);
			List<string> catogories = new List<string>();
			foreach (DataRow dr in dt2.Rows)
			{
				catogories.Add(dr[filterColumn].ToString());
			}
			return catogories;
		}
		
		private int Exacute(DataTable dt, IWorkbook workbook,ExcelHelper eh, string filterColumn, string filterValue)
		{
			string filter = filterColumn + "=\'" + filterValue +"\'";
			DataTable newDt = new DataTable();
			newDt = dt.Clone();
			DataRow[] drArr = dt.Select(filter);//查询
			int i = 0;
			foreach(DataRow row in drArr)
			{
				newDt.Rows.Add(row.ItemArray);
				i++;
			}
			eh.DataTableToExcel(newDt,workbook,filterValue,true);
			return i;
		}
	}
}

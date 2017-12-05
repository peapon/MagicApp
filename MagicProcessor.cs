/*
 * Created by SharpDevelop.
 * User: pannengchong
 * Date: 2017/12/5
 * Time: 19:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Data;
using System.IO;

namespace MagicApp
{
	/// <summary>
	/// Description of MagicProcessor.
	/// </summary>
	public class MagicProcessor
	{
		private string fileName = null; //文件名
		private string folderName = null;
        private IWorkbook workbook = null;
        private FileStream fs = null;
        private int current;
        private int totalRows;

		
		public MagicProcessor()
		{
		}
		
		public int Process( string excel, string folder)
		{
			ConfigReader cr = new ConfigReader();
			fileName = excel;
			folderName = folder;
			List<string> columns = cr.GetAllReadingColumn("config.xml");
			string sheetName = cr.GetSheetName("config.xml");
			bool isFirstRowColumn = cr.IsFirstRowColumn("config.xml");
			string find = cr.GetColumnFind("config.xml");
			string body = cr.GetColumnBody("config.xml");
			string connection = cr.GetColumnConnection("config.xml");
			DataTable dt = LoadExcelToDataTable(sheetName, isFirstRowColumn);
			totalRows = dt.Rows.Count;
			current = Exacute(dt, find, body, connection);
			return current;
		}
		
		public int GetTotal()
		{
			return totalRows;
		}
		
		public int GetCurrent()
		{
			return current;
		}
		
		private int Exacute(DataTable datatble, string find, string body, string connection)
		{
			for(int i = 0 ; i < datatble.Rows.Count ; i++)
			{
				string findRet = datatble.Rows[i][find].ToString();
				string bodyRet = datatble.Rows[i][body].ToString();
				string connectionRet = datatble.Rows[i][connection].ToString();
				if(FileExistInFolder(findRet,bodyRet))
				{
					RenameFile(findRet, bodyRet, connectionRet);
				}
				current = i;
			}
			// 如果处理未完成，考虑失败的数目
			return current;
		}
		
		private bool FileExistInFolder(string find, string body)
		{
			string fullPath = folderName + "\\" + find + "." + body;
			return File.Exists(fullPath);
		}
		
		private void RenameFile(string find, string body, string connection)
		{
			string srcFileName = folderName + "\\" + find + "." + body;
			string destFileName = folderName + "\\" + connection + "+" + body;
			File.Move(srcFileName, destFileName);
		}
		
		private DataTable LoadExcelToDataTable(string sheetName, bool isFirstRowColumn)
		{
			ISheet sheet = null;
            DataTable data = new DataTable();
            int startRow = 0;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                if (fileName.IndexOf(".xlsx") > 0) // 2007版本
                    workbook = new XSSFWorkbook(fs);
                else if (fileName.IndexOf(".xls") > 0) // 2003版本
                    workbook = new HSSFWorkbook(fs);

                if (sheetName != null)
                {
                    sheet = workbook.GetSheet(sheetName);
                    if (sheet == null) //如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                }
                else
                {
                    sheet = workbook.GetSheetAt(0);
                }
                if (sheet != null)
                {
                    IRow firstRow = sheet.GetRow(0);
                    int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数

                    if (isFirstRowColumn)
                    {
                        for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                        {
                            ICell cell = firstRow.GetCell(i);
                            if (cell != null)
                            {
                                string cellValue = cell.StringCellValue;
                                if (cellValue != null)
                                {
                                    DataColumn column = new DataColumn(cellValue);
                                    data.Columns.Add(column);
                                }
                            }
                        }
                        startRow = sheet.FirstRowNum + 1;
                    }
                    else
                    {
                        startRow = sheet.FirstRowNum;
                    }

                    //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　
                        
                        DataRow dataRow = data.NewRow();
                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                                dataRow[j] = row.GetCell(j).ToString();
                        }
                        data.Rows.Add(dataRow);
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
		}
	}
}

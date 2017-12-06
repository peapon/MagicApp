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
using System.Text.RegularExpressions;
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
			ExcelHelper eh = new ExcelHelper(fileName);
			List<string> columns = cr.GetAllReadingColumn("config.xml");
			string sheetName = cr.GetSheetName("config.xml");
			bool isFirstRowColumn = cr.IsFirstRowColumn("config.xml");
			string find = cr.GetColumnFind("config.xml");
			string body = cr.GetColumnBody("config.xml");
			string connection = cr.GetColumnConnection("config.xml");
			DataTable dt = eh.ExcelToDataTable(sheetName, isFirstRowColumn);
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
				string dar = GetDARNumber(connectionRet);
				if(FileExistInFolder(findRet,bodyRet))
				{
					RenameFile(findRet, bodyRet, dar);
				}
				current = i;
			}
			// 如果处理未完成，考虑失败的数目
			return current;
		}
		
		private string GetDARNumber(string connection)
		{
			string ret = connection;
			string[] sArray = ret.Split(new Char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
			ret = "";
			if(sArray.Length > 1)
			{
				ret = sArray[1];
			}
			return ret;
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
	}
}

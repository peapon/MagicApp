/*
 * Created by SharpDevelop.
 * User: pannengchong
 * Date: 2017/12/5
 * Time: 19:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MagicApp
{
	/// <summary>
	/// Description of ColumnReader.
	/// </summary>
	public class ConfigReader
	{
		public ConfigReader()
		{
		}
		
		public List<string> GetAllReadingColumn(string path)
		{
			XDocument xDoc = XDocument.Load(path);
			XElement xElement = (XElement)xDoc.Element("config").Element("Columns");
			string ret = xElement.Value;
			string[] sArray=Regex.Split(ret,";",RegexOptions.IgnoreCase);
			List<string> columns = new List<string>();
			foreach (string s in sArray)
				columns.Add(s);
			return columns;
		}
		
		public string GetSheetName(string path)
		{
			XDocument xDoc = XDocument.Load(path);
			XElement xElement = (XElement)xDoc.Element("config").Element("Sheet");
			string ret = xElement.Value;
			return ret;
		}
		
		public bool IsFirstRowColumn(string path)
		{
			XDocument xDoc = XDocument.Load(path);
			XElement xElement = (XElement)xDoc.Element("config").Element("FirstRowAsTitle");
			string ret = xElement.Value;
			return int.Parse(ret) == 1 ? true : false;
		}
		
		public string GetColumnFind(string path)
		{
			XDocument xDoc = XDocument.Load(path);
			XElement xElement = (XElement)xDoc.Element("config").Element("Find");
			string ret = xElement.Value;
			return ret;
		}
		
		public string GetColumnBody(string path)
		{
			XDocument xDoc = XDocument.Load(path);
			XElement xElement = (XElement)xDoc.Element("config").Element("Body");
			string ret = xElement.Value;
			return ret;
		}
		
		public string GetColumnConnection(string path)
		{
			XDocument xDoc = XDocument.Load(path);
			XElement xElement = (XElement)xDoc.Element("config").Element("Connection");
			string ret = xElement.Value;
			return ret;
		}
	}
}

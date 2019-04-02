using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Excel;
using System.Data;
using System;
using System.IO;
public class ExcelContral
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="fileName">全路径名</param>
    /// 
    /// <returns>返回一个string数组</returns>
    public static string[,] DataReader(string fileName, ref int columnNum, ref int rowNum)
    {

        DataRowCollection datarowCollection = ExcelReade(fileName, ref columnNum, ref rowNum);
        string[,] data = new string [rowNum,columnNum] ;
      
        
        for(int i = 0; i < rowNum; i++)
        {
            for (int j = 0; j < columnNum; j++) {
                data[i, j] = datarowCollection[i][j].ToString();
             }
            
        }
       
        return data;
    }
    
  static  DataRowCollection ExcelReade(string fileName,ref int columnNum,ref int rowNum)
    {
        FileStream stream = File.Open(fileName,FileMode.Open,FileAccess.Read,FileShare.Read);
        IExcelDataReader readerExcel = ExcelReaderFactory.CreateOpenXmlReader(stream);

        readerExcel.IsFirstRowAsColumnNames = true;
        DataSet result = readerExcel.AsDataSet();
        columnNum = result.Tables[0].Columns.Count;
        rowNum = result.Tables[0].Rows.Count;
        return result.Tables[0].Rows;

    }
}

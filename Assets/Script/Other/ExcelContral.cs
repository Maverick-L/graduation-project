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
    /// 数据返回
    /// </summary>
    /// <param name="fileName">全路径名</param>
    /// 
    /// <returns>返回一个string数组</returns>
    public static string[,] DataReader(string fileName, ref int columnNum, ref int rowNum)
    {
        DataSet result = OpenExcel(fileName);
        DataRowCollection datarowCollection = ExcelReade(result,ref columnNum, ref rowNum);
        string[,] data = new string[rowNum, columnNum];
        for (int i = 0; i < rowNum; i++)
        {
            for (int j = 0; j < columnNum; j++) {
                data[i, j] = datarowCollection[i][j].ToString();
            }

        }

        return data;
    }

    /// <summary>
    /// 打开一个Excel
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    static DataSet OpenExcel(string fileName)
    {
        FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
        IExcelDataReader readerExcel = ExcelReaderFactory.CreateOpenXmlReader(stream);
        readerExcel.IsFirstRowAsColumnNames = true;
        DataSet result = readerExcel.AsDataSet();
        readerExcel.Close();
       return  result;
    }

    /// <summary>
    /// 数据读取
    /// </summary>
    /// <param name="result"></param>
    /// <param name="columnNum"></param>
    /// <param name="rowNum"></param>
    /// <returns></returns>
    static DataRowCollection ExcelReade(DataSet result, ref int columnNum, ref int rowNum)
    {
        columnNum = result.Tables[0].Columns.Count;
        rowNum = result.Tables[0].Rows.Count;
        return result.Tables[0].Rows;

    }

    /// <summary>
    /// 返回行数
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static int RowsNum(string fileName)
    {
        DataSet result = OpenExcel(fileName);
        return result.Tables[0].Rows.Count;
    }

    /// <summary>
    /// 返回列数
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static int ColumnsNum(string fileName)
    {
        return OpenExcel(fileName).Tables[0].Columns.Count;
    }
}

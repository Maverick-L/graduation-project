using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;
using System.Data;
using System.IO;
using Excel;
using UnityEngine.UI;
namespace LFrameStudy
{
    public class ExcelContral : MonoBehaviour
    {
        public Text text;
        void Start()
        {
            FileStream stream = File.Open(Application.dataPath + "/LFrameStudy/10.Excel表格操作/Arm.xlsx", FileMode.Open, FileAccess.Read, FileShare.Read);
            //Choose one of either 1 or 2
            //1. Reading from a binary Excel file ('97-2003 format; *.xls)

            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            //Choose one of either 3, 4, or 5
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result = excelReader.AsDataSet();

            //4. DataSet - Create column names from first row
            print(result.Tables[0].Columns.Count);
            print(result.Tables[0].Rows.Count);


            for (int i = 0; i < result.Tables[0].Rows.Count; i++)
            {
                text.text += uint.Parse(result.Tables[0].Rows[i][0].ToString());
                text.text += result.Tables[0].Rows[i][1].ToString();
                text.text += uint.Parse(result.Tables[0].Rows[i][2].ToString());
                text.text += result.Tables[0].Rows[i][3].ToString();
                print(uint.Parse(result.Tables[0].Rows[i][0].ToString()) + "     " +
                                 result.Tables[0].Rows[i][1].ToString() + "      " +
                    uint.Parse(result.Tables[0].Rows[i][2].ToString()) + "      " +
                     result.Tables[0].Rows[i][3].ToString());
                

            }
        }


    }
}


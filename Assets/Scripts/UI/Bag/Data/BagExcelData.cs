﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using OfficeOpenXml;

internal class BagExcelData  
{

    public static BagExcelData Singeton=null;//单例
    ExcelPackage excel;
    //装备表
    ExcelWorksheet EquipSheet;
    FileInfo file;
    string filePath;

    public  BagExcelData ( )
    {
        if ( Singeton==null )
        {
            Singeton = this;
        }
        filePath = Application.dataPath + "/StreamingAssets/Data_Bag.xlsx";
        file = new FileInfo ( filePath );
        excel = new ExcelPackage ( file );
        EquipSheet = excel.Workbook.Worksheets[ 1 ];

    }
    public string GetWord ( int i , int j )
    {
        return EquipSheet.Cells[ i , j ].Value.ToString ( );
    }
    public void SetWord ( int i , int j , string InputText )
    {
        EquipSheet.Cells[ i , j ].Value = InputText;
    }
    // 保存
    public void SavaData ( )
    {
        excel.Save ( );
    }

}

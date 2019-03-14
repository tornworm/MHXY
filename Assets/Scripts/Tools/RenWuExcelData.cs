
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using OfficeOpenXml;



public class RenWuExcelData : MonoBehaviour
{

	public static RenWuExcelData Singeton;//单例
    ExcelPackage excel;
    //第一张表，文字表
    ExcelWorksheet WordSheet;
    FileInfo file;
    string filePath;

    void Awake()
    {
        Singeton = this;
		filePath = Application.dataPath + "/StreamingAssets/Data_Renwu.xlsx";
        file = new FileInfo(filePath);
        excel = new ExcelPackage(file);
        WordSheet = excel.Workbook.Worksheets[1];

    }
    public string GetWord(int i, int j)
    {
        return WordSheet.Cells[i, j].Value.ToString();
    }
    public void SetWord(int i, int j, string InputText)
    {
        WordSheet.Cells[i, j].Value = InputText;
    }
    // 保存
    public void SavaData()
    {
        excel.Save();
    }
}




using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using OfficeOpenXml;



public class ExcelEPP : MonoBehaviour
{

    public static ExcelEPP Singeton;
    ExcelPackage excel;
    //第一张表，文字表
    ExcelWorksheet WordSheet;
    //第二张表,内在能力表
    ExcelWorksheet CapacitySheet;

    //ExcelWorksheet FiveSheet;



    //// 第三张表
    //ExcelWorksheet ThreeSheet;
    ////第四张表
    //ExcelWorksheet Four;


    FileInfo file;
    string filePath;

    void Awake()
    {
        Singeton = this;
        filePath = Application.dataPath + "/StreamingAssets/Data_excel.xlsx";
        file = new FileInfo(filePath);
        excel = new ExcelPackage(file);
        WordSheet = excel.Workbook.Worksheets[1];
        CapacitySheet = excel.Workbook.Worksheets[2];
        //ThreeSheet = excel.Workbook.Worksheets[3];
        //Four = excel.Workbook.Worksheets[4];
        //FiveSheet = excel.Workbook.Worksheets[5];
    }
    public string GetWord(int i, int j)
    {
        return WordSheet.Cells[i, j].Value.ToString();
    }
    public void SetWord(int i, int j, string InputText)
    {
        WordSheet.Cells[i, j].Value = InputText;
    }
    public string GetCapacity(int i,int j)
    {
        return CapacitySheet.Cells[i, j].Value.ToString();
    }
    public void SetCapacity(int i, int j, string InputText)
    {
        CapacitySheet.Cells[i, j].Value = InputText;
    }
    // 保存
    public void SavaData()
    {
        excel.Save();
    }
}
        //    //读第二张表
        //    public string GetTwoNetRong(int i,int j)
        //    {
        //        //你的Excel表页的内容（行号和列号）
        //        string neirong = sceondSheet.Cells[i, j].Value.ToString();
        //        return neirong;
        //    }
        //    public string GetThreeNeiRong(int i, int j)
        //    {
        //        //你的Excel表页的内容（行号和列号）
        //        string kkk = ThreeSheet.Cells[i, j].Value.ToString();
        //        return kkk;
        //    }
        //    //存表
        //    public void CunBiao(int i, int j, string InputText)
        //    {
        //        //你的表页的名称（行数和列数）把你的输入的内容存到Excel表
        //        sceondSheet.Cells[i, j].Value = InputText;



//    }

//    public string GetFiveData(int i,int j)
//    {
//        string a = FiveSheet.Cells[i, j].Value.ToString();
//        return a;
//    }



//

//    //读第四张表
//    public string GetFour(int i, int j)
//    {
//        //你的Excel表页的内容（行号和列号）
//        string neirofourneirongng = Four.Cells[i, j].Value.ToString();
//        return neirofourneirongng;
//    }
//    //存第四张表
//    public void CunFour(int i, int j, string InputText)
//    {
//        //你的表页的名称（行数和列数）把你的输入的内容存到Excel表
//        Four.Cells[i, j].Value = InputText;



//    }
//}




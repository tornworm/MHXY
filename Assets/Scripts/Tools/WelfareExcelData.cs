
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using OfficeOpenXml;



public class WelfareExcelData : MonoBehaviour
{

    public static WelfareExcelData Singeton;
    ExcelPackage excel;
    //第一张表，Panel1数据
    ExcelWorksheet Panel1;
    //第二张表,Panel2数据
    ExcelWorksheet Panel2;
    //第三张表，Panel3数据
    ExcelWorksheet Panel3;
    //第四张表,Panel4数据
    ExcelWorksheet Panel4;
    //第五张表，Panel5数据
    ExcelWorksheet Panel5;
    //第六张表,Panel6数据
    ExcelWorksheet Panel6;
    //第七张表，Panel7数据
    ExcelWorksheet Panel7;


    FileInfo file;
    string filePath;

    void Awake()
    {
        Singeton = this;
        filePath = Application.dataPath + "/StreamingAssets/Data_Welfare.xlsx";
        file = new FileInfo(filePath);
        excel = new ExcelPackage(file);
        Panel1 = excel.Workbook.Worksheets[1];
        Panel2 = excel.Workbook.Worksheets[2];
        //ThreeSheet = excel.Workbook.Worksheets[3];
        //Four = excel.Workbook.Worksheets[4];
        Panel5 = excel.Workbook.Worksheets[5];
    }
    //读第一张表
    public string GetPanel1(int i, int j)
    {
        return Panel1.Cells[i, j].Value.ToString();
    }
    //设置第一张表
    public void SetPanel1(int i, int j, string InputText)
    {
        Panel1.Cells[i, j].Value = InputText;
    }
    //读第五张表
    public string GetPanel5(int i, int j)
    {
        return Panel5.Cells[i, j].Value.ToString();
    }
    //设置第五张表
    public void SetPanel5(int i, int j, string InputText)
    {
        Panel5.Cells[i, j].Value = InputText;
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




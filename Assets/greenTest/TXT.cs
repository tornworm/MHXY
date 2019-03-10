/*  _    _
   (o)--(o)
  /.______.\
  \________/    代码神宠
 ./        \.
( .        , )
 \ \_\\//_/ /
  ~~  ~~  ~~
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TXT : MonoBehaviour
{
    private TXT(){}
    public static TXT Instance;
    public int IdCount  // 当前表的所有道具的数量
    {
        get
        {
            return Instance.Data_Dictionary.Keys.Count-1;
        }
    }

    public Dictionary<int, List<string>> Data_Dictionary;

    void Awake() 
	{
        Instance = this;
        Data_Dictionary = new Dictionary<int, List<string>>();
        Txt_LineUnityEngine(); // 存数据
    }


    public DataClass GetWeaponData(int Id)  // 获取对应id的列表 得到读取列表的数据类
    {
        if (Data_Dictionary.ContainsKey(Id))
        {
            DataClass.Instance.GetThisID_ValueList(Data_Dictionary[Id]);       // 每次读取数据都要把对应ID的列表传过去
            return  DataClass.Instance;
        }
        else
        {
            Debug.LogError("未索引到数据");
            return null;
        }
    }

    public void AddWeaponCount(int Id)  // 在字典里增加对应ID的数量
    {
        //GetWeaponData()
    }

    void Txt_LineUnityEngine()  // 存数据
    {

        string[] col;

        StreamReader sr = null;

        sr = File.OpenText(Application.dataPath + "Data_Task");

        string lineInfo;
        int i = 0;
        while ((lineInfo = sr.ReadLine()) != null)  // 如果可以读取到该行的数据
        {
            Debug.Log(lineInfo);
            //List<string> row_List = new List<string>();   //字典每一行对应一个列表
            //Data_Dictionary.Add(i, row_List);  // 字典存放键对应的列表
            //col = lineInfo.Split();  // 空格分割字符串
            //for (int index = 0; index < col.Length; index++)    // TXT表每一行的数据
            //{
            //    row_List.Add(col[index]);  // 此行每一列的数据放到对应行的列表里
            //}
            i++;
        }
        sr.Close();
    }
 
}

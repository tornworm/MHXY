
using System.Collections.Generic;
using UnityEngine;

public class DataClass : MonoBehaviour 
{
    private DataClass(){ }
    public static DataClass Instance;
    public   List<string> TXT_List;

    private string id;
    public string Id
    {
        get
        {
            id = TXT_List[0];
            return id;
        }
    } 
    private string first;
    public string Firts
    {
        get
        {
            first =TXT_List[1];
            return first;
        }
    }  // 物品的名字
    private string second;
    public string Second
    {
        get
        {
            second = TXT_List[2];
            return second;
        }
    }  // 物品的数量
 
    private void Awake()
    {
        Instance = this;
    }

    public void GetThisID_ValueList(List<string>data)  // 每次读数据都把对应ID的列表传过来
    {
       Instance.TXT_List = data;
    }

}


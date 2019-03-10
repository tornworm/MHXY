//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LeanCloud;
using System.Threading.Tasks;
using System.Threading;
public class AVTest : MonoBehaviour {

    private string id;
	
	void Start () {
       // XX();
        
    }
    private void XX()
    {
        var equip = new AVObject("GameEquip");//在服务器的GameEquip表新建一行
        equip["name"] = "短剑";//这一行的第二列为name列，值为短剑
        equip["attackValue"] = 5;
     
        equip["level"] = 1;
        //以下为标准化存储表
        equip.SaveAsync().ContinueWith(
            (preTask) =>
            {
                Debug.Log("存储装备成功:" + equip.ObjectId);
                id = equip.ObjectId;
                TestQueryAVObject();
            }
        );

    
    }
    void TestQueryAVObject()
    {
        AVQuery<AVObject> query = new AVQuery<AVObject>("GameEquip");
        query.GetAsync(id).ContinueWith(
            (preTask) =>
            {
                AVObject equipment = preTask.Result;
                Debug.Log("检索装备成功:" + equipment.ObjectId);
                Debug.Log("==========" + equipment["name"]);
            }
        );
    }



}

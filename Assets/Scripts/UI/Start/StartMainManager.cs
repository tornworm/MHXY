//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LeanCloud;
using LeanCloud.Core.Internal;
using LeanCloud.Storage.Internal;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;



public class StartMainManager : MonoBehaviour {


    private static StartMainManager singeton;
    public static StartMainManager Singeton
    {
        get
        {
            if (singeton == null)
            {
                singeton = new StartMainManager();
            }
            return singeton;
        }
    }
    private StartMainManager() { }

    public string Account;//账号
    public string Key;//密码
    //public void Seek()
    //{
    //    AVQuery<AVObject> query = new AVQuery<AVObject>("_User").WhereContains("Account", Account);
    //    if (query != null)
    //    {
    //        Debug.Log("已经有该用户名！");
    //    }
    //    else
    //    {
    //        Debug.Log("查无此人!");
    //    }
    //}
    public void SignUp()
    {
        Debug.LogError("等明神来接LeanCloudSDK");
        //var user = new AVUser();
        //user.Username = "Tom";
        //user.Password = "cat!@#123";
        //user.Email = "tom@leancloud.cn";
        //await user.SignUpAsync();
        //Debug.Log(user.Username);
    }
}
    //AVCloud.RequestSMSCodeAsync("18").ContinueWith(
        //  (preTask) =>
        //  {
        //      AVObject equipment = preTask.Result;
        //      Debug.Log("检索装备成功:" + equipment.ObjectId);
        //  }
     /* ); */

        //AVQuery<AVObject> query = new AVQuery<AVObject>("_User").WhereContains("Account", Account);
        //if (query== null)
        //{
        //    Debug.Log("已经有该用户名！");

        //    return;
        //}
        //else
        //{
        //    Debug.Log("查无此人!");
        //}
        //var userData = new AVObject("_User");//Excel表名
        //userData["Account"] = Account;

        //userData.SaveAsync().ContinueWith(
        //  (preTask) =>
        //  {
        //      Debug.Log("创建用户成功:" + Account);


        //  });



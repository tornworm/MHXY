using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_BagEquipShow : BaseWindows
 {
    Image BG;

    //初始化
    void Start()
    {
        //查找各个变量
        Find();
    }

    //查找变量
    void Find()
    {
        //背景图片
        BG=transform.Find("BG").GetComponent<Image>();

    }

    //重写父类的鼠标点击方法
    public override void OnPointerClick ( UnityEngine.EventSystems.PointerEventData e )
    {
        //判断鼠标是否点击了背景
        if ( e.pointerEnter==BG.gameObject )
        {
            gameObject.SetActive(false);//关闭界面
        }
    }
}

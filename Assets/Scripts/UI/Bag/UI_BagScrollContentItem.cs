using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_BagScrollContentItem :MonoBehaviour
 {
    //显示图标
    Image goodIcon;
    //显示数量
    Text goodNum;
    public int goodCount;
    //存储的物品对象
    public Good good;
    //格子是否已经有物品
    public bool isNone=true;
    //管理面板
   // UI_BagPanelOne 
    void Start()
    {
        #region 隐藏物品图标显示的优化方法
        //最好整一张透明图片作为物品图标显示的默认图
        #endregion
        //物品图标显示为隐藏
        if ( isNone )//背包没有物品
        {
            if ( goodIcon==null )//没有查找到物品图标的话
            {
                goodIcon = transform.Find ( "GoodIcon" ).GetComponent<Image> ( );//查找物品图标
            }
            goodIcon.transform.gameObject.SetActive(false);//将其设置为隐藏状态
        }
    }
    //查找组件方法
    void Find()
    {
        if ( goodIcon==null )
        {
            goodIcon = transform.Find ( "GoodIcon" ).GetComponent<Image> ( );
            goodNum = transform.Find ( "NumText" ).GetComponent<Text> ( );
        }        
    }
	//外部添加物品并更新显示方法
    public void SetGood(Good _good,int _count)
    {
        //查找各个组件
        Find();
        //赋值
        good=_good;
        goodCount=_count;
        isNone=false;
        //更新显示
        UpdateInfo();
    }
    //外部使用物品并更新显示方法
    public void UseGood(int _count)
    {
        //判断数量是否足够使用
        if ( goodCount >= _count )
        {
            //使用物品
            goodCount-=_count;//减少数量
            //更新显示
            UpdateInfo();
        }
        else
        {
            Debug.Log("您要使用的物品数量不足！");
        }
    }

    //更新显示方法
    void UpdateInfo()
    {
        if ( good!=null )
        {
            //判断物品的数量
            if ( goodCount<=0 )
            {
                goodCount=0;
                //判断物品图标Image是否为显示状态
                if ( !goodIcon.transform.gameObject.activeInHierarchy )
                {
                    goodIcon.transform.gameObject.SetActive(true);//让其显示出来
                }
                goodIcon.sprite=null;
                goodNum.text="";
            }
            else
            {
                goodIcon.sprite = good.SpriteIcon;
                goodNum.text = goodCount.ToString ( );                
            }           
        }
        else
        {
            Debug.Log("格子更新出错，格子里的物品对象为空!");
        }
    }
    //显示被鼠标选中框
    public void ShowSelectImage(bool _show)
    {
        GameObject go= transform.Find("SelectImage").gameObject;
        go.SetActive(_show);
    }

  
}

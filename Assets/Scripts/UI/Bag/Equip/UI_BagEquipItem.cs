using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//这个类是任务装备界面装备格子类
internal class UI_BagEquipItem : MonoBehaviour
 {
    //当前格子存储的装备
    Equip equip;
    //当前格子显示的装备图标
    Image equipIcon;
    
    void Start()
    {
        Find();
    }

    //查找属性变量
    void Find()
    {
        equipIcon=transform.Find("EquipIcon").GetComponent<Image>();
    }
	//外部设置装备方法
    public void SetEquip(Equip _equip)
    {
        //如果格子脚本还未初始化完成，先初始化
        if ( equipIcon==null )
        {
            Find();
        }        
        equip=_equip;
        UpdateEquip();
    }
    //外部卸下装备方法
    public void DropEquip()
    {
        equip=null;
        UpdateEquip();
    }
    //更新显示方法
    void UpdateEquip()
    {
        if ( equip==null )
        {
            equipIcon.sprite=null;
        }
        else
        {
            equipIcon.sprite = equip.SpriteIcon;
        }
       
    }

}

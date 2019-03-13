using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*物品类型*/
public enum GoodType
{
    ST_ITEM ,//道具类物品
    ST_EQUIP//装备类物品
}
//装备的品质
public enum GoodQuality
{
    GQ_WHITE ,//白色，普通
    GQ_GREEN ,//绿色，优秀
    GQ_BLUE ,//蓝色，精良
    GQ_PURPLE ,//紫色，稀有
    GQ_ORANGE//橙色，卓越
}
//装备职业
public enum RoleType
{
    RT_Warrior ,//战士
    RT_Mage//法师
}

/*道具类型*/
public enum ItemType
{
    IT_HP ,//血瓶
    IT_MP ,//蓝瓶
    IT_BOX ,//宝箱
    //IT_HUICHENG,//回城
    IT_GOLD//金币堆
}

/*装备类型*/
public enum EquipType
{
    ET_WEAPON ,//武器
    ET_HEAD ,//头饰
    ET_GLOVE ,//护腕
    ET_BELT ,//腰带
    ET_CLOTHES ,//铠甲
    ET_SHOE//鞋子
}

public class GoodEnum : MonoBehaviour 
{
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipManager : MonoBehaviour
 {
    public static EquipManager Singeton;
    //存储所有装备的字典
    Dictionary<int ,Equip> equipDict=new Dictionary<int,Equip>();

    void Awake()
    {
        Singeton=this;
        
        //读取所有装备信息
        ReadInfo();
        Debug.Log("所有装备已加载到字典中，一共"+equipDict.Count+"件!");
    }
	
    //加载装备到字典中
    void ReadInfo()
    {
        //一共72件装备
        for ( int i = 2 ; i <=73 ; i++ )
        {
            //定义一件装备
            Equip equip = new Equip ( );
            //每件装备有15个属性
            for ( int j = 1 ; j <=15 ; j++ )
            {
                //分别赋值
                equip.Type = GoodType.ST_EQUIP;//物品类型为装备
                equip.CanTrade = true;//可交易
                equip.CanUse = true;//可使用
                //赋值ID
                if (j==1)
                {
                     equip.ID=int.Parse(BagExcelData.Singeton.GetWord(i,j));
                     continue;
                }
                //赋值装备类型
                if ( j == 2 )
                {
                    switch (BagExcelData.Singeton.GetWord(i,j) )
                    {
                        case "腰带":
                            equip.EquipType=EquipType.ET_BELT;
                        break;
                        case "铠甲":
                        equip.EquipType = EquipType.ET_CLOTHES;
                        break;
                        case "护腕":
                        equip.EquipType = EquipType.ET_GLOVE;
                        break;
                        case "头盔":
                        equip.EquipType = EquipType.ET_HEAD;
                        break;
                        case "鞋子":
                        equip.EquipType = EquipType.ET_SHOE;
                        break;
                        case "武器":
                        equip.EquipType = EquipType.ET_WEAPON;
                        break;
                        default:
                            break;
                    }
                    continue;
                }
                //赋值装备的职业类型
                if ( j==3 )
                {
                    switch (BagExcelData.Singeton.GetWord(i,j) )
                    {
                        case"战士":
                        equip.RoleType=RoleType.RT_Warrior;
                        break;
                        case "法师":
                        equip.RoleType = RoleType.RT_Mage;
                        break;
                        default:
                            break;
                    }
                    continue;
                }
	            //赋值装备的名称
                if ( j==4 )
                {
                    equip.Name=BagExcelData.Singeton.GetWord(i,j);
                    continue;
                }
                //赋值装备的限制使用等级
                if ( j==5 )
                {
                    equip.LimitLevel=int.Parse(BagExcelData.Singeton.GetWord(i,j));
                    continue;
                }
                //赋值装备的镶嵌孔数量
                if ( j==6 )
                {
                    equip.InlayNum=int.Parse(BagExcelData.Singeton.GetWord(i,j));
                    continue;
                }
                //赋值装备的星级
                if ( j==7 )
                {
                    equip.StartLevel=int.Parse(BagExcelData.Singeton.GetWord(i,j));
                    continue;
                }
                //赋值装备的攻击属性加成
                if ( j==8 )
                {
                    equip.Attack=int.Parse(BagExcelData.Singeton.GetWord(i,j));
                    continue;
                }
                //赋值装备的防御属性加成
                if ( j==9 )
                {
                    equip.Defence=int.Parse(BagExcelData.Singeton.GetWord(i,j));
                    continue;
                }
                //赋值装备的HP属性加成
                if ( j==10 )
                {
                    equip.AddHp=int.Parse(BagExcelData.Singeton.GetWord(i,j));
                    continue;
                }
                //赋值装备的MP属性加成
                if ( j==11 )
                {
                    equip.AddMp=int.Parse(BagExcelData.Singeton.GetWord(i,j));
                    continue;
                }
                //赋值装备的价格
                if ( j==12 )
                {
                    equip.Price=int.Parse(BagExcelData.Singeton.GetWord(i,j));
                    continue;
                }
                //赋值装备的描述
                if ( j==15 )
                {
                    equip.Description=BagExcelData.Singeton.GetWord(i,j);                    
                }                
                //将装备添加到字典中
               equipDict.Add(equip.ID,equip);                

            }
        }
    }

}

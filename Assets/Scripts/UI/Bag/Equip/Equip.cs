using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : GoodBase
 {

     //装备的类型
     public EquipType mEquipType;
     public EquipType EquipType
     {
         get
         {
             return mEquipType;
         }
         set
         {
             mEquipType = value;
         }
     }
     //装备职业
     public RoleType mRoleType;
     public RoleType RoleType
     {
         get
         {
             return mRoleType;
         }
         set
         {
             mRoleType = value;
         }
     }
     //镶嵌孔数
     public int mInlayNum;
     public int InlayNum
     {
         get
         {
             return mInlayNum;
         }
         set
         {
             mInlayNum = value;
         }
     }

     //是否可以合成
     public bool mIsCompose;
     public bool IsCompose
     {
         get
         {
             return mIsCompose;
         }
         set
         {
             mIsCompose = value;
         }
     }

     //装备的附加攻击力
     public int mAttack;
     public int Attack
     {
         get
         {
             return mAttack;
         }
         set
         {
             mAttack = value;
         }
     }

     //装备的附加防御力
     public int mDefence;
     public int Defence
     {
         get
         {
             return mDefence;
         }
         set
         {
             mDefence = value;
         }
     }

     //装备的附加血量
     public int mAddHp;
     public int AddHp
     {
         get
         {
             return mAddHp;
         }
         set
         {
             mAddHp = value;
         }
     }

     //装备的附加蓝量
     public int mAddMp;
     public int AddMp
     {
         get
         {
             return mAddMp;
         }
         set
         {
             mAddMp = value;
         }
     }
}

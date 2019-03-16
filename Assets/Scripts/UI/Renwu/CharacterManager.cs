using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterManager  
{
	private static CharacterManager singleton;
	public static CharacterManager Singleton
	{
		get {

			if (singleton == null) {
				singleton = new CharacterManager();
			}
			return singleton;
		}
	}



	private CharacterManager() { }

	//人物属性（王海霁）

	public int MaxLv=100;//人物的等级上限
	public int ID;//人物ID号
	public int HP;//人物血量
	public int MaxHp = 378;//人物最大血量
	public int MP;//人物魔法
	public int MaxMp = 230;//人物最大魔法
	public int Anger;//人物的愤怒
	public int MaxAnger;//人物的最大愤怒
	public int Dynamic;//人物的活力
	public int MaxDynamic;//人物的最大活力
	public int HpStorage;//人物的气血储备
	public int MaxHPstorage;//人物的最大气血储备
	public int MPstorage;//人物的魔法存储
	public int MaxMPstorage;//人物的最大魔法储备-
	public int Exp;//人物的经验值
	public int MaxExp = 1140;//人物的最大经验值
	public int ProfitExp;//人物的盈利经验
	public int ContriButtonUnited;//人物的门派贡献
	public int GanGunited;//人物的帮派贡献
	public int HolidayUnited;//人物的节日积分
	public int MountUnited;//人物的坐骑灵珠
	public int MachinegunUnited;//人物的武勋值
	public int ChivalrousUnited;//人物的侠义值
	public int TeacherUnited;//人物的良师值
	public int ArtifactUnited;//人物的神器积分
	public int FishingUnited;//人物的钓鱼积分
	public int MaicweaponUnited;//人物的法宝积分
	public int PetUnited;//人物的宠物积分
	public int SheticUnited;//人物的合宠积分
	public int GodofwarUnited;//人物的战神积分
	public int ATN;//人物攻击
	public int INT;//人物魔法攻击
	public int DEL;//人物防御力
	public int MDEL;//人物魔法防御力
	public int Speed;//人物的速度
	public int CTA; //人物暴击率
	public int ICTA;//人物的魔法暴击率
	public int CHR;//人物暴击伤害
	public int SEAL;//人物的封印命中
	public int ResisTanceSeal;//人物的抗封印
	public int ResisTancecta;//人物抗暴率
	public int ResisTanceicta;//人物的魔抗暴率
	public int TreaTment;//人物的治疗强度
	public int STR;//人物力量属性
	public int CON;//人物的体质
	public int MAG;//人物的魔力
	public int DEX;//人物的敏捷
	public int WIL;//人物的耐力
	public string Name;//人物的名字
	public int Lv = 1;//人物的等级
	public string AppellaTion;//人物的称谓
	public string United;//人物的门派
	public string Gang ;//人物的帮派
	public string AddAlittle;//人物的加点方案


	//活跃活动（谢振东）



	//福利（李俊超）
	public int CurrentsDays;//当前签到天数


	//宠物（梁静莹）
      public Dictionary<int, List<int>> PetsID=new Dictionary<int,List<int>>(); 
    //key为宠物的ID，


	//技能（杨虎）




	}



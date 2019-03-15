using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoad : MonoBehaviour {


	void Start () {

		//人物属性（王海霁）

	    CharacterManager.Singleton.ID = int.Parse (RenWuExcelData.Singeton.GetWord (2, 3));
		CharacterManager.Singleton.HP = int.Parse (RenWuExcelData.Singeton.GetWord (3, 3));
		CharacterManager.Singleton.MP = int.Parse (RenWuExcelData.Singeton.GetWord (4, 3));
		CharacterManager.Singleton.MaxHp = int.Parse (RenWuExcelData.Singeton.GetWord (5, 3));
		CharacterManager.Singleton.MaxMp = int.Parse (RenWuExcelData.Singeton.GetWord (6, 3));
		CharacterManager.Singleton.Anger = int.Parse (RenWuExcelData.Singeton.GetWord (7, 3));
		CharacterManager.Singleton.MaxAnger = int.Parse (RenWuExcelData.Singeton.GetWord (8, 3));
		CharacterManager.Singleton.Dynamic = int.Parse (RenWuExcelData.Singeton.GetWord (9, 3));
		CharacterManager.Singleton.MaxDynamic = int.Parse (RenWuExcelData.Singeton.GetWord (10, 3));
		CharacterManager.Singleton.HpStorage = int.Parse (RenWuExcelData.Singeton.GetWord (11, 3));
		CharacterManager.Singleton.MaxHPstorage = int.Parse (RenWuExcelData.Singeton.GetWord (12, 3));
		CharacterManager.Singleton.MPstorage = int.Parse (RenWuExcelData.Singeton.GetWord (13, 3));
		CharacterManager.Singleton.MaxMPstorage = int.Parse (RenWuExcelData.Singeton.GetWord (14, 3));
		CharacterManager.Singleton.Exp = int.Parse (RenWuExcelData.Singeton.GetWord (15, 3));
		CharacterManager.Singleton.MaxExp = int.Parse (RenWuExcelData.Singeton.GetWord (16, 3));
		CharacterManager.Singleton.ProfitExp = int.Parse (RenWuExcelData.Singeton.GetWord (17, 3));
		CharacterManager.Singleton.ContriButtonUnited = int.Parse (RenWuExcelData.Singeton.GetWord (18, 3));
		CharacterManager.Singleton.GanGunited = int.Parse (RenWuExcelData.Singeton.GetWord (19, 3));
		CharacterManager.Singleton.HolidayUnited = int.Parse (RenWuExcelData.Singeton.GetWord (20, 3));
		CharacterManager.Singleton.MountUnited = int.Parse (RenWuExcelData.Singeton.GetWord (21, 3));
		CharacterManager.Singleton.MachinegunUnited = int.Parse (RenWuExcelData.Singeton.GetWord (22, 3));
		CharacterManager.Singleton.ChivalrousUnited = int.Parse (RenWuExcelData.Singeton.GetWord (23, 3));
		CharacterManager.Singleton.TeacherUnited = int.Parse (RenWuExcelData.Singeton.GetWord (24, 3));
		CharacterManager.Singleton.ArtifactUnited = int.Parse (RenWuExcelData.Singeton.GetWord (25, 3));
		CharacterManager.Singleton.FishingUnited = int.Parse (RenWuExcelData.Singeton.GetWord (26, 3));
		CharacterManager.Singleton.MaicweaponUnited = int.Parse (RenWuExcelData.Singeton.GetWord (27, 3));
		CharacterManager.Singleton.PetUnited = int.Parse (RenWuExcelData.Singeton.GetWord (28, 3));
		CharacterManager.Singleton.SheticUnited = int.Parse (RenWuExcelData.Singeton.GetWord (29, 3));
		CharacterManager.Singleton.GodofwarUnited = int.Parse (RenWuExcelData.Singeton.GetWord (30, 3));
		CharacterManager.Singleton.ATN = int.Parse (RenWuExcelData.Singeton.GetWord (31, 3));
		CharacterManager.Singleton.INT = int.Parse (RenWuExcelData.Singeton.GetWord (32, 3));
		CharacterManager.Singleton.DEL = int.Parse (RenWuExcelData.Singeton.GetWord (33, 3));
		CharacterManager.Singleton.MDEL = int.Parse (RenWuExcelData.Singeton.GetWord (34, 3));
		CharacterManager.Singleton.Speed = int.Parse (RenWuExcelData.Singeton.GetWord (35, 3));
		CharacterManager.Singleton.CTA = int.Parse (RenWuExcelData.Singeton.GetWord (36 ,3));
		CharacterManager.Singleton.ICTA = int.Parse (RenWuExcelData.Singeton.GetWord (37, 3));
		CharacterManager.Singleton.CHR = int.Parse (RenWuExcelData.Singeton.GetWord (38, 3));
		CharacterManager.Singleton.SEAL = int.Parse (RenWuExcelData.Singeton.GetWord (39, 3));
		CharacterManager.Singleton.ResisTanceSeal =int.Parse (RenWuExcelData.Singeton.GetWord (40, 3));
		CharacterManager.Singleton.ResisTancecta = int.Parse (RenWuExcelData.Singeton.GetWord (41, 3));
		CharacterManager.Singleton.ResisTanceicta = int.Parse (RenWuExcelData.Singeton.GetWord (42, 3));
		CharacterManager.Singleton.TreaTment = int.Parse (RenWuExcelData.Singeton.GetWord (43, 3));
		CharacterManager.Singleton.STR = int.Parse (RenWuExcelData.Singeton.GetWord (44, 3));
		CharacterManager.Singleton.CON = int.Parse (RenWuExcelData.Singeton.GetWord (45, 3));
		CharacterManager.Singleton.MAG = int.Parse (RenWuExcelData.Singeton.GetWord (46, 3));
		CharacterManager.Singleton.DEX = int.Parse (RenWuExcelData.Singeton.GetWord (47, 3));
		CharacterManager.Singleton.WIL = int.Parse (RenWuExcelData.Singeton.GetWord (48, 3));
		CharacterManager.Singleton.Name =  (RenWuExcelData.Singeton.GetWord (49, 3));
		CharacterManager.Singleton.Lv =  int.Parse(RenWuExcelData.Singeton.GetWord (50, 3));
		CharacterManager.Singleton.AppellaTion =  (RenWuExcelData.Singeton.GetWord (51, 3));
		CharacterManager.Singleton.United =  (RenWuExcelData.Singeton.GetWord (52, 3));
		CharacterManager.Singleton.Gang=  (RenWuExcelData.Singeton.GetWord (53, 3));
		CharacterManager.Singleton.AddAlittle = (RenWuExcelData.Singeton.GetWord (54, 3));

		//活跃活动（谢振东）



		//福利（李俊超）



		//宠物（梁静莹）



		//技能（杨虎）


	}
}

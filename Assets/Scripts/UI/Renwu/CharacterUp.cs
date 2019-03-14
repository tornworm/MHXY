using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterUp :MonoBehaviour{

	public void SaveCharacterData()
	{
	    RenWuExcelData.Singeton.SetWord (2, 3, CharacterManager.Singleton.ID.ToString());
		RenWuExcelData.Singeton.SetWord (3, 3, CharacterManager.Singleton.HP.ToString());
		RenWuExcelData.Singeton.SetWord (4, 3, CharacterManager.Singleton.MP.ToString());
		RenWuExcelData.Singeton.SetWord (5, 3, CharacterManager.Singleton.MaxHp.ToString());
		RenWuExcelData.Singeton.SetWord (6, 3, CharacterManager.Singleton.MaxMp.ToString());
		RenWuExcelData.Singeton.SetWord (7, 3, CharacterManager.Singleton.Anger.ToString());
		RenWuExcelData.Singeton.SetWord (8, 3, CharacterManager.Singleton.MaxAnger.ToString());
		RenWuExcelData.Singeton.SetWord (9, 3, CharacterManager.Singleton.Dynamic.ToString());
		RenWuExcelData.Singeton.SetWord (10, 3, CharacterManager.Singleton.MaxDynamic.ToString());
		RenWuExcelData.Singeton.SetWord (11, 3, CharacterManager.Singleton.HpStorage.ToString());
		RenWuExcelData.Singeton.SetWord (12, 3, CharacterManager.Singleton.MaxHPstorage.ToString());
		RenWuExcelData.Singeton.SetWord (13, 3, CharacterManager.Singleton.MPstorage.ToString());
		RenWuExcelData.Singeton.SetWord (14, 3, CharacterManager.Singleton.MaxMPstorage.ToString());
		RenWuExcelData.Singeton.SetWord (15, 3, CharacterManager.Singleton.Exp.ToString());
		RenWuExcelData.Singeton.SetWord (16, 3, CharacterManager.Singleton.MaxExp.ToString());
		RenWuExcelData.Singeton.SetWord (17, 3, CharacterManager.Singleton.ProfitExp.ToString());
		RenWuExcelData.Singeton.SetWord (18, 3, CharacterManager.Singleton.ContriButtonUnited.ToString());
		RenWuExcelData.Singeton.SetWord (19, 3, CharacterManager.Singleton.GanGunited.ToString());
		RenWuExcelData.Singeton.SetWord (20, 3, CharacterManager.Singleton.HolidayUnited.ToString());
		RenWuExcelData.Singeton.SetWord (21, 3, CharacterManager.Singleton.MountUnited.ToString());
		RenWuExcelData.Singeton.SetWord (22, 3, CharacterManager.Singleton.MachinegunUnited.ToString());
		RenWuExcelData.Singeton.SetWord (23, 3, CharacterManager.Singleton.ChivalrousUnited.ToString());
		RenWuExcelData.Singeton.SetWord (24, 3, CharacterManager.Singleton.TeacherUnited.ToString());
		RenWuExcelData.Singeton.SetWord (25, 3, CharacterManager.Singleton.ArtifactUnited.ToString());
		RenWuExcelData.Singeton.SetWord (26, 3, CharacterManager.Singleton.FishingUnited.ToString());
		RenWuExcelData.Singeton.SetWord (27, 3, CharacterManager.Singleton.MaicweaponUnited.ToString());
		RenWuExcelData.Singeton.SetWord (28, 3, CharacterManager.Singleton.PetUnited.ToString());
		RenWuExcelData.Singeton.SetWord (29, 3, CharacterManager.Singleton.SheticUnited.ToString());
		RenWuExcelData.Singeton.SetWord (30, 3, CharacterManager.Singleton.GodofwarUnited.ToString());
		RenWuExcelData.Singeton.SetWord (31, 3, CharacterManager.Singleton.ATN.ToString());
		RenWuExcelData.Singeton.SetWord (32, 3, CharacterManager.Singleton.INT.ToString());
		RenWuExcelData.Singeton.SetWord (33, 3, CharacterManager.Singleton.DEL.ToString());
		RenWuExcelData.Singeton.SetWord (34, 3, CharacterManager.Singleton.MDEL.ToString());
		RenWuExcelData.Singeton.SetWord (35,3,CharacterManager.Singleton.Speed.ToString());
		RenWuExcelData.Singeton.SetWord (36, 3, CharacterManager.Singleton.CTA.ToString());
		RenWuExcelData.Singeton.SetWord (37, 3, CharacterManager.Singleton.ICTA.ToString());
		RenWuExcelData.Singeton.SetWord (38, 3, CharacterManager.Singleton.CHR.ToString());
		RenWuExcelData.Singeton.SetWord (39, 3, CharacterManager.Singleton.SEAL.ToString());
		RenWuExcelData.Singeton.SetWord (40, 3, CharacterManager.Singleton.ResisTanceSeal.ToString());
		RenWuExcelData.Singeton.SetWord (41, 3, CharacterManager.Singleton.ResisTancecta.ToString());
		RenWuExcelData.Singeton.SetWord (42, 3, CharacterManager.Singleton.ResisTanceicta.ToString());
		RenWuExcelData.Singeton.SetWord (43, 3, CharacterManager.Singleton.TreaTment.ToString());
		RenWuExcelData.Singeton.SetWord (44, 3, CharacterManager.Singleton.STR.ToString());
		RenWuExcelData.Singeton.SetWord (45, 3, CharacterManager.Singleton.CON.ToString());
		RenWuExcelData.Singeton.SetWord (46, 3, CharacterManager.Singleton.MAG.ToString());
		RenWuExcelData.Singeton.SetWord (47, 3, CharacterManager.Singleton.DEX.ToString());
		RenWuExcelData.Singeton.SetWord (48, 3, CharacterManager.Singleton.WIL.ToString());
		RenWuExcelData.Singeton.SetWord (49, 3, CharacterManager.Singleton.Name.ToString());
		RenWuExcelData.Singeton.SetWord (50, 3, CharacterManager.Singleton.Lv.ToString());
		RenWuExcelData.Singeton.SetWord (51, 3, CharacterManager.Singleton.AppellaTion.ToString());
		RenWuExcelData.Singeton.SetWord (52, 3, CharacterManager.Singleton.United.ToString());
		RenWuExcelData.Singeton.SetWord (53, 3, CharacterManager.Singleton.Gang.ToString());
		RenWuExcelData.Singeton.SetWord (54, 3, CharacterManager.Singleton.AddAlittle.ToString());
		//活跃活动（谢振东）



		//福利（李俊超）



		//宠物（梁晶莹）



		//技能（杨虎）



	    RenWuExcelData.Singeton.SavaData ();

	}
}

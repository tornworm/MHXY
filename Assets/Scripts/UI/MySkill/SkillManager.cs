
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI的工具类
/// </summary>
public class SkillManager
{
    private static SkillManager singeton;
    public static SkillManager Singeton
    {
        get
        {
            if (singeton == null)
            {
                singeton = new SkillManager();
            }
            return singeton;
        }
    }
    private SkillManager() { }

    public string skillID;//技能编号
    public string skillName;//技能名字

    public int manaCost;//技能蓝耗
    public int needMoney;//升级所需钱数
    public int neeDcontri;//升级所需帮贡
    public int maxLevel;//等级上限

}

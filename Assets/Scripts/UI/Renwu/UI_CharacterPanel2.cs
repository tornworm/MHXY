using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_CharacterPanel2 : BaseWindows {

    //数据

    //面板左侧

    public Text hptext;//血气存储
	public Text maxhptext;//最大血气存储
    public Text mptext;//魔法存储
	public Text maxmptext;//最大魔法存储

    //右侧面板

    public Text menpaitext;//门派
    public Text bangpaitext;//帮派
    public Text gongxian;//贡献
    public Text gongxianbp;//帮派贡献
    public Text jieri;//节日
    public Text zuoqi;//坐骑
    public Text wuyun;//武勋
    public Text xiayi;//侠义
    public Text liangshi;//良师
    public Text qita;//其他积分

	void Start () {

		Find();//动态找到面板中对应的组件
		Show();//将数据更新到面板上
	}


	void Update () {

	}
	public void Show() {
		// characterID.text=
		SetTab(0);
	}
	public void Find() 
	{
		hptext = transform.Find ("left/qixue/chubei1/hp/hptext").GetComponent<Text> ();
		maxhptext = transform.Find ("left/qixue/chubei1/hp/maxhptext").GetComponent<Text> ();
		mptext = transform.Find ("left/qixue/chubei2/mp/mptext").GetComponent<Text> ();
		maxmptext = transform.Find ("left/qixue/chubei2/mp/maxmptext").GetComponent<Text> ();
		menpaitext = transform.Find ("light/menpai/mingcheng/menpaitext").GetComponent<Text> ();
		bangpaitext = transform.Find ("light/bangpai/mingcheng/bangpaitext").GetComponent<Text> ();
		gongxian = transform.Find ("light/gongxian").GetComponent<Text> ();
		bangpaitext = transform.Find ("light/gongxianbp").GetComponent<Text> ();
		jieri = transform.Find ("light/jieri").GetComponent<Text> ();
		zuoqi = transform.Find ("light/zuoqi").GetComponent<Text> ();
		wuyun = transform.Find ("light/wuxun").GetComponent<Text> ();
		xiayi = transform.Find ("light/xiayi").GetComponent<Text> ();
		liangshi = transform.Find ("light/liangshi").GetComponent<Text> ();
		qita = transform.Find ("light/qita").GetComponent<Text> ();
	}
	public void SetTab(int id)
	{
		
	}
	
}

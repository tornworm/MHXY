using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_CharacterPanel3 : BaseWindows{
    //数据

    //左侧面板

    public Text jiadian;//加点方案
    public Text qixue;//气血
    public Text mofa;//魔法
    public Text atn;//武理伤害
    public Text matn;//魔法伤害
    public Text del;//物理防御
    public Text mdel;//魔法防御
    public Text sd;//速度

    //右侧面板
    public Text qlText;//潜力点
    public Text tzText;//体质
    public Text mfText;//魔法
    public Text llText;//力量
    public Text nlText;//耐力
    public Text mjText;//敏捷

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
		jiadian = transform.Find ("left/jiadian/Text").GetComponent<Text> ();
		qixue = transform.Find ("left/qixue/Text").GetComponent<Text> ();
		mofa = transform.Find ("left/mofa/Text").GetComponent<Text> ();
		atn = transform.Find ("left/atn/Text").GetComponent<Text> ();
		matn = transform.Find ("left/matn/Text").GetComponent<Text> ();
		del = transform.Find ("left/del/Text").GetComponent<Text> ();
		mdel = transform.Find ("left/mdel/Text").GetComponent<Text> ();
		sd = transform.Find ("left/sd/Text").GetComponent<Text> ();
		qlText = transform.Find ("light/qianli/qlText").GetComponent<Text> ();
		tzText = transform.Find ("light/tizhi/tzText").GetComponent<Text> ();
		mfText = transform.Find ("light/moli/mfText").GetComponent<Text> ();
		llText = transform.Find ("light/liliang/llText").GetComponent<Text> ();
		nlText = transform.Find ("light/naili/nlText").GetComponent<Text> ();
		mjText = transform.Find ("light/minjie/mjText").GetComponent<Text> ();
	}
	public void SetTab(int id)
	{

	}

}

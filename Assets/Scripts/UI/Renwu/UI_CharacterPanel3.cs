using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_CharacterPanel3 : BaseWindows{
    //数据

    //左侧面板

    private Text jiadian;//加点方案
    private Text qixue;//气血
    private Text mofa;//魔法
    private Text atn;//武理伤害
    private Text matn;//魔法伤害
    private Text del;//物理防御
    private Text mdel;//魔法防御
    private Text sd;//速度

    //右侧面板
    private Text qlText;//潜力点
    private Text tzText;//体质
    private Text mfText;//魔法
    private Text llText;//力量
    private Text nlText;//耐力
    private Text mjText;//敏捷

	void Start () {

		Find();//动态找到面板中对应的组件
		Show();//将数据更新到面板上
	}


	void Update () {

	}
    private void Show() {
		// characterID.text=
		SetTab(0);
	}
    private void Find() 
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
    private void SetTab(int id)
	{

	}

}

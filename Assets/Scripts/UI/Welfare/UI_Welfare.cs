using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_Welfare : BaseWindows
{
    private Text title = null;//标题文本
    private Button backBtn = null;//返回

    private Text tabTxt1 = null;//七日登录礼文本
    private Text tabTxt2 = null;//每日福利文本
    private Text tabTxt3 = null;//每周特惠文本
    private Text tabTxt4 = null;//首充礼包文本
    private Text tabTxt5 = null;//升级礼包文本
    private Text tabTxt6 = null;//成长奖励文本
    private Text tabTxt7 = null;//节日礼包文本

    private GameObject panel1 = null;//七日登录礼
    private GameObject panel2 = null;//每日福利
    private GameObject panel3 = null;//每周福利
    private GameObject panel4 = null;//首充礼包
    private GameObject panel5 = null;//升级礼包
    private GameObject panel6 = null;//成长奖励
    private GameObject panel7 = null;//节日礼包

    private GameObject tabImg1 = null;
    private GameObject tabImg2 = null;
    private GameObject tabImg3 = null;
    private GameObject tabImg4 = null;
    private GameObject tabImg5 = null;
    private GameObject tabImg6 = null;
    private GameObject tabImg7 = null;

    List<Text> tabTxt = new List<Text>();
    List<GameObject> tabImg = new List<GameObject>();
    List<GameObject> panel = new List<GameObject>();
	
	private void Start () 
    {
        title = transform.Find("bg/title/Text").GetComponent<Text>();
        backBtn = transform.Find("bg/back").GetComponent<Button>();

        tabTxt.Clear();
        tabTxt1 = transform.Find("bg/ScrollView/Viewport/tabList/tab1/Text").GetComponent<Text>();
        tabTxt2 = transform.Find("bg/ScrollView/Viewport/tabList/tab2/Text").GetComponent<Text>();
        tabTxt3 = transform.Find("bg/ScrollView/Viewport/tabList/tab3/Text").GetComponent<Text>();
        tabTxt4 = transform.Find("bg/ScrollView/Viewport/tabList/tab4/Text").GetComponent<Text>();
        tabTxt5 = transform.Find("bg/ScrollView/Viewport/tabList/tab5/Text").GetComponent<Text>();
        tabTxt6 = transform.Find("bg/ScrollView/Viewport/tabList/tab6/Text").GetComponent<Text>();
        tabTxt7 = transform.Find("bg/ScrollView/Viewport/tabList/tab7/Text").GetComponent<Text>();
        tabTxt.Add(tabTxt1);
        tabTxt.Add(tabTxt2);
        tabTxt.Add(tabTxt3);
        tabTxt.Add(tabTxt4);
        tabTxt.Add(tabTxt5);
        tabTxt.Add(tabTxt6);
        tabTxt.Add(tabTxt7);

        tabImg.Clear();
        tabImg1 = transform.Find("bg/ScrollView/Viewport/tabList/tab1/Image").gameObject;
        tabImg2 = transform.Find("bg/ScrollView/Viewport/tabList/tab2/Image").gameObject;
        tabImg3 = transform.Find("bg/ScrollView/Viewport/tabList/tab3/Image").gameObject;
        tabImg4 = transform.Find("bg/ScrollView/Viewport/tabList/tab4/Image").gameObject;
        tabImg5 = transform.Find("bg/ScrollView/Viewport/tabList/tab5/Image").gameObject;
        tabImg6 = transform.Find("bg/ScrollView/Viewport/tabList/tab6/Image").gameObject;
        tabImg7 = transform.Find("bg/ScrollView/Viewport/tabList/tab7/Image").gameObject;
        tabImg.Add(tabImg1);
        tabImg.Add(tabImg2);
        tabImg.Add(tabImg3);
        tabImg.Add(tabImg4);
        tabImg.Add(tabImg5);
        tabImg.Add(tabImg6);
        tabImg.Add(tabImg7);

        panel.Clear();
        panel1 = transform.Find("bg/panel1").gameObject;
        panel2 = transform.Find("bg/panel2").gameObject;
        panel3 = transform.Find("bg/panel3").gameObject;
        panel4 = transform.Find("bg/panel4").gameObject;
        panel5 = transform.Find("bg/panel5").gameObject;
        panel6 = transform.Find("bg/panel6").gameObject;
        panel7 = transform.Find("bg/panel7").gameObject;
        panel.Add(panel1);
        panel.Add(panel2);
        panel.Add(panel3);
        panel.Add(panel4);
        panel.Add(panel5);
        panel.Add(panel6);
        panel.Add(panel7);
	}

    public override void OnPointerClick(PointerEventData e)
    {
        if (e.pointerEnter.name=="tab1")
        {
            SetTab(0);
        }
        if (e.pointerEnter.name == "tab2")
        {
            SetTab(1);
        }
        if (e.pointerEnter.name == "tab3")
        {
            SetTab(2);
        }
        if (e.pointerEnter.name == "tab4")
        {
            SetTab(3);
        }
        if (e.pointerEnter.name == "tab5")
        {
            SetTab(4);
            Debug.Log(WelfareExcelData.Singeton.GetPanel5(2, 1));
        }
        if (e.pointerEnter.name == "tab6")
        {
            SetTab(5);
        }
        if (e.pointerEnter.name == "tab7")
        {
            SetTab(6);
        }
    }
	
	private void SetTab(int id)
    {
        for (int i = 0; i < tabTxt.Count; i++)
        {
            if (i==id)
            {
                tabImg[i].SetActive(true);
                panel[i].SetActive(true);
            }
            else
            {
                tabImg[i].SetActive(false);
                panel[i].SetActive(false);
            }
        }
    }
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_CharacterPanel1 : BaseWindows {


    //数据



    //面板
    //左侧面板

    private Image characterIcon;//人物头像
    private Image characterGroup;//人物职业
    private Text characterNickName;//人物姓名
    private Text characterLevel;//人物级别
    private Text characterID;//人物ID

    private GameObject lowTab;//基础属性信息标签
    private GameObject highTab;//高级属性信息标签
    private GameObject lowPanel;//基础属性面板
    private GameObject HighPanel;//高级属性面板
    private List<GameObject> tabImg = new List<GameObject>();
    private List<GameObject> panel = new List<GameObject>();

    //右侧面板
	
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
    private void Find() {
        lowTab = transform.Find("right/jichu/jichuImage").gameObject;
        highTab = transform.Find("right/gaoji/gaojiImage").gameObject;
       lowPanel=  transform.Find("right/jichu/kuang").gameObject;
       HighPanel = transform.Find("right/gaoji/kuang").gameObject;

       tabImg.Clear();
       panel.Clear();
       tabImg.Add(lowTab);
       tabImg.Add(highTab);
       panel.Add(lowPanel);
       panel.Add(HighPanel);
    }
    public override void OnPointerClick(PointerEventData e) 
    {
        if (e.pointerEnter.name == "jichu") {
            SetTab(0);
        } else if (e.pointerEnter.name == "gaoji") {
            SetTab(1);
        }

    }
    private void SetTab(int id) {
        for (int i = 0; i < 2; i++) {

            if (i == id) {

                tabImg[i].SetActive(true);
                panel[i].SetActive(true);
            } else {
                tabImg[i].SetActive(false);
                panel[i].SetActive(false);

            }
        }
    }
}

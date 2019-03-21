using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_MySkill : BaseWindows
{
    private Text title = null;//标题文本
    private Button backBtn = null;//返回

    private Text tabTxt1 = null;//属性文本
    private Text tabTxt2 = null;//信息文本
    private Text tabTxt3 = null;//加点文本

    private GameObject panel1 = null;//属性
    private GameObject panel2 = null;//信息
    private GameObject panel3 = null;//加点

    private GameObject tabImg1 = null;
    private GameObject tabImg2 = null;
    private GameObject tabImg3 = null;

    List<Text> tabTxt = new List<Text>();
    List<GameObject> tabImg = new List<GameObject>();
    List<GameObject> panel = new List<GameObject>();
    void Start ()
    {
        title = transform.Find("bg/title/Text").GetComponent<Text>();
        backBtn = transform.Find("bg/back").GetComponent<Button>();


        tabTxt.Clear();
        tabTxt1 = transform.Find("bg/tabList/tab1/Text").GetComponent<Text>();
        tabTxt2 = transform.Find("bg/tabList/tab2/Text").GetComponent<Text>();
        tabTxt3 = transform.Find("bg/tabList/tab3/Text").GetComponent<Text>();
        tabTxt.Add(tabTxt1);
        tabTxt.Add(tabTxt2);
        tabTxt.Add(tabTxt3);

        tabImg.Clear();
        tabImg1 = transform.Find("bg/tabList/tab1/Image").gameObject;
        tabImg2 = transform.Find("bg/tabList/tab2/Image").gameObject;
        tabImg3 = transform.Find("bg/tabList/tab3/Image").gameObject;
        tabImg.Add(tabImg1);
        tabImg.Add(tabImg2);
        tabImg.Add(tabImg3);

        panel.Clear();
        panel1 = transform.Find("bg/panel1").gameObject;
        panel2 = transform.Find("bg/panel2").gameObject;
        panel3 = transform.Find("bg/panel3").gameObject;
        panel.Add(panel1);
        panel.Add(panel2);
        panel.Add(panel3);

        SetTab(0);
    }

    public override void OnPointerClick(PointerEventData e)
    {


        if (e.pointerEnter.name == "tab1")
        {
            SetTab(0);
            title.text = "人物技能";
        }
        else if (e.pointerEnter.name == "tab2")
        {
            SetTab(1);
            title.text = "帮派技能";
        }
        else if (e.pointerEnter.name == "tab3")
        {
            SetTab(2);
            title.text = "修炼技能";
        }
    }
    private void SetTab(int id)
    {
        for (int i = 0; i < 3; i++)
        {

            if (i == id)
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

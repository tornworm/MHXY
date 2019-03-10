//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;




public class UI_Common1 : BaseWindows {

    private Text title = null;//标题文本
    private Button backBtn = null;//返回

    private Text tabTxt1 = null;//属性文本
    private Text tabTxt2 = null;//信息文本
    private Text tabTxt3 = null;//加点文本
    private Text tabTxt4 = null;//修行文本

    private GameObject panel1 = null;//属性
    private GameObject panel2 = null;//信息
    private GameObject panel3 = null;//加点
    private GameObject panel4 = null;//修行

    private GameObject tabImg1 = null;
    private GameObject tabImg2 = null;
    private GameObject tabImg3 = null;
    private GameObject tabImg4 = null;



    List<Text> tabTxt = new List<Text>();
    List<GameObject> tabImg = new List<GameObject>();
    List<GameObject> panel = new List<GameObject>();

    private void Start()
    {
        title = transform.Find("bg/title/Text").GetComponent<Text>();
        backBtn = transform.Find("bg/back").GetComponent<Button>();


        tabTxt.Clear();
        tabTxt1 = transform.Find("bg/tabList/tab1/Text").GetComponent<Text>();
        tabTxt2 = transform.Find("bg/tabList/tab2/Text").GetComponent<Text>();
        tabTxt3 = transform.Find("bg/tabList/tab3/Text").GetComponent<Text>();
        tabTxt4 = transform.Find("bg/tabList/tab4/Text").GetComponent<Text>();
        tabTxt.Add(tabTxt1);
        tabTxt.Add(tabTxt2);
        tabTxt.Add(tabTxt3);
        tabTxt.Add(tabTxt4);

        tabImg.Clear();
        tabImg1 = transform.Find("bg/tabList/tab1/Image").gameObject;
        tabImg2 = transform.Find("bg/tabList/tab2/Image").gameObject;
        tabImg3 = transform.Find("bg/tabList/tab3/Image").gameObject;
        tabImg4 = transform.Find("bg/tabList/tab4/Image").gameObject;
        tabImg.Add(tabImg1);
        tabImg.Add(tabImg2);
        tabImg.Add(tabImg3);
        tabImg.Add(tabImg4);

        panel.Clear();
        panel1 = transform.Find("bg/panel1").gameObject;
        panel2 = transform.Find("bg/panel2").gameObject;
        panel3 = transform.Find("bg/panel3").gameObject;
        panel4 = transform.Find("bg/panel4").gameObject;
        panel.Add(panel1);
        panel.Add(panel2);
        panel.Add(panel3);
        panel.Add(panel4);


        SetTab(1);
    }
    public override void OnPointerClick(PointerEventData e)
    {
    
    
        if (e.pointerEnter.name == "tab1")
        {
            SetTab(0);
        }
        else if (e.pointerEnter.name == "tab2")
        {
            SetTab(1);
        }
        else if (e.pointerEnter.name == "tab3")
        {
            SetTab(2);
        }
        else if (e.pointerEnter.name == "tab4")
        {
            SetTab(3);
        }
    }
    private void SetTab(int id)
    {
        for (int i = 0; i < 4; i++)
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

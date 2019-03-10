//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OfficeOpenXml;




public class UI_Capacity : BaseWindows {

    private Button randomBtn;//骰子按钮
    private Button LBtn;//左按钮
    private Button RBtn;//右按钮
    private string content;//内容数据
    private Text contentText;//内容显示文本
    private string level;//等级数据
    private Image levelImage;//等级背景图片
    private Text levelText;//等级文本
    private int levelImageID;//等级图片对应ID
    private int row;//刷新出的内在能力

	void Start () {

        


        randomBtn = transform.Find("randomBtn").GetComponent<Button>();
        LBtn = transform.Find("LBtn").GetComponent<Button>();
        RBtn = transform.Find("RBtn").GetComponent<Button>();
        contentText = transform.Find("content/Text").GetComponent<Text>();
        levelText = transform.Find("level/Text").GetComponent<Text>();
        levelImage = transform.Find("level/Image").GetComponent<Image>();
        randomBtn.onClick.AddListener(randomCapacity);
        LBtn.onClick.AddListener(confirm);
        RBtn.onClick.AddListener(cancel);
        randomCapacity();


    }

    void randomCapacity()//随机数据
    {
        row = Random.Range(2, 100);
        content = ExcelEPP.Singeton.GetCapacity(row, 3);
        level = ExcelEPP.Singeton.GetCapacity(row, 2);
        Debug.Log(row);
        levelImageID = int.Parse(ExcelEPP.Singeton.GetCapacity(row, 4));
        synchronousShow();
        SendE();

    }
    void confirm()//确认按钮
    {
        Debug.Log(name);
        UITools.Singeton.CloseSelf(name);
    }
    void cancel()//取消按钮
    {
        UITools.Singeton.CloseWindow("UI_Capacity");
    }
    void synchronousShow()//同步显示数据
    {
        contentText.text = content;
        levelText.text = level + ExcelEPP.Singeton.GetWord(2, 2);
        levelImage.sprite = UITools.Singeton.GetLevelImage(levelImageID);
        UITools.Singeton.CreatHintBox("已随机内在能力");
       // Debug.Log("Textures/UI/common/item_color_0/" + levelImageID);

    }
    void delayBtn()
    {

    }
    //public  void OnEventTrigger(Event _Event)
    //{
    //    Debug.Log(111);
    //}
    private void SendE()
    {
        Event e = new Event();
        e.EventID = 1111;
        e.EventParamObj = row;
        EventController.sInstance.PushEvent(e);
    }

    private void OnDestroy()
    {
        randomBtn.onClick.RemoveListener(randomCapacity);
        LBtn.onClick.RemoveListener(confirm);
        RBtn.onClick.RemoveListener(cancel);
    }



}

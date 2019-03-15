using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_WelfarePanel5Cell : BaseWindows {

    private int id;
    private Text Level;//等级/10的数字
    private Text Level2;

    void Start()
    {
        Find();
        id = int.Parse(name);
        Show();
    }

    void Find()
    {
        Level = transform.Find("Text1").GetComponent<Text>();
        Level2 = transform.Find("Image/Text1").GetComponent<Text>();
    }

    void Show()
    {
        Level.text = id.ToString();
        Level2.text = id.ToString();
    }

    //处理等级提升事件
    public override void OnEventTrigger(Event _Event)
    {
        base.OnEventTrigger(_Event);
    }

}

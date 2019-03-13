using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_WelfarePanel1Cell : MonoBehaviour {

    private int id;
    private Text dayCount;
    private Text Descript;

    void Start()
    {
        Find();
        id = int.Parse(name);
        Show();
        
    }

    void Find()
    {
        dayCount = transform.Find("Text2").GetComponent<Text>();
        Descript = transform.Find("Text4").GetComponent<Text>();
    }

    void Show()
    {
        dayCount.text = id.ToString();
        
    }


}

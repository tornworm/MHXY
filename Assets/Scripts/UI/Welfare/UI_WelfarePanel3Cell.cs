using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_WelfarePanel3Cell : MonoBehaviour 
{
    private Image HeadImg;
    private Text NameTxt;
    private Text PriceTxt;
    private Text DiscountTxt;

    void Start()
    {
        Find();
        Show();
        
    }

    void Find()
    {
        HeadImg = transform.Find("Image/Image").GetComponent<Image>();
        NameTxt = transform.Find("Text").GetComponent<Text>();
        PriceTxt = transform.Find("Image2/Text").GetComponent<Text>();
        DiscountTxt = transform.Find("Image1/Text").GetComponent<Text>();
    }

    void Show()
    {
        
        
    }


}

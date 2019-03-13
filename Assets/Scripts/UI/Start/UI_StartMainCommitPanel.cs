//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;




public class UI_StartMainCommitPanel : BaseWindows {


    private GameObject image1;//龙太子图片
    private GameObject image2;//虎头怪图片
    private GameObject image3;//剑侠客图片
    private GameObject image4;//狐狸精图片
    private GameObject true1;
    private GameObject true2;
    private GameObject true3;
    private GameObject true4;
    private Button SignUpBtn;//注册按钮

    private void Awake()
    {
        Find();
      

    }
    private void OnEnable()
    {

        Show();
    }
    private void Find()
    {
        image1 = transform.Find("area/longtaizi").gameObject;
        image2 = transform.Find("area/hutouguai").gameObject;
        image3 = transform.Find("area/jianxiake").gameObject;
        image4 = transform.Find("area/hulijing").gameObject;
        true1 = image1.transform.Find("Image").gameObject;
        true2 = image2.transform.Find("Image").gameObject;
        true3 = image3.transform.Find("Image").gameObject;
        true4 = image4.transform.Find("Image").gameObject;
        SignUpBtn = transform.Find("SignUp").GetComponent<Button>();
        SignUpBtn.onClick.AddListener(SignUp);
    }
    private void Show()
    {

        image1.transform.SetSiblingIndex(Random.Range(1, 4));
        image2.transform.SetSiblingIndex(Random.Range(1, 4));
        image3.transform.SetSiblingIndex(Random.Range(1, 4));
        image4.transform.SetSiblingIndex(Random.Range(1, 4));
        true1.SetActive(false);
        true2.SetActive(false);
        true3.SetActive(false);
        true4.SetActive(false);
    }
    public override void OnPointerClick(PointerEventData e)
    {
        if (e.pointerEnter.name == "longtaizi")
        {
            true1.SetActive(true);
            true2.SetActive(false);
            true3.SetActive(false);
            true4.SetActive(false);

        }
        if (e.pointerEnter.name == "hutouguai")
        {
            true1.SetActive(false);
            true2.SetActive(true);
            true3.SetActive(false);
            true4.SetActive(false);

        }
        if (e.pointerEnter.name == "jianxiake")
        {
            true1.SetActive(false);
            true2.SetActive(false);
            true3.SetActive(true);
            true4.SetActive(false);

        }
        if (e.pointerEnter.name == "hulijing")
        {
            true1.SetActive(false);
            true2.SetActive(false);
            true3.SetActive(false);
            true4.SetActive(true);

        }
    }
    private void SignUp()
    {
        if (true2.activeSelf==false)
        {
          
            UITools.Singeton.CreatHintBox("验证码错误!");
            gameObject.SetActive(false);
            transform.parent.Find("SignInPanel").gameObject.SetActive(true);
            return;
        }
        else
        {
            UITools.Singeton.CreatHintBox("注册成功!");
            gameObject.SetActive(false);
            //  StartMainManager.Singeton.SignUp();
            transform.parent.Find("StartBtn").gameObject.SetActive(true);
            transform.parent.Find("chooseServer").gameObject.SetActive(true);

        }
    }
}

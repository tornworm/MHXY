//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UI_StartMainChoosePanel : MonoBehaviour {

    private Button SignUpBtn;//注册按钮
    private Button SignInBtn;//登陆按钮
    private Button backBtn;//返回按钮
    private Button closeBtn;//关闭按钮
    private Button eyeBtn;//显示隐藏密码按钮

    private InputField AccountInput;//账号输入区域
    private InputField KeyInput;//密码输入区域
    private bool KeyShow = true;
	void Start () {
        Find();
	}
    private void Find()
    {
        SignUpBtn = transform.Find("bg/SignUpBtn").GetComponent<Button>();
        SignInBtn = transform.Find("bg/SignInBtn").GetComponent<Button>();
        backBtn = transform.Find("bg/backBtn").GetComponent<Button>();
        closeBtn = transform.Find("bg/closeBtn").GetComponent<Button>();
        AccountInput = transform.Find("bg/AccountInput").GetComponent<InputField>();
        KeyInput = transform.Find("bg/KeyInput").GetComponent<InputField>();
        eyeBtn = transform.Find("bg/eyeBtn").GetComponent<Button>();
        SignUpBtn.onClick.AddListener(SignUp);
        SignInBtn.onClick.AddListener(SignIn);
        backBtn.onClick.AddListener(back);
        closeBtn.onClick.AddListener(close);
        eyeBtn.onClick.AddListener(eye);
    }
    private void SignUp()
    {
        gameObject.SetActive(false);
        transform.parent.Find("SignUpPanel").gameObject.SetActive(true);
    }
    private void SignIn()
    {
        gameObject.SetActive(false);
        transform.parent.Find("StartBtn").gameObject.SetActive(true);
        transform.parent.Find("chooseServer").gameObject.SetActive(true);

        // UITools.Singeton.CreatHintBox("用户名或密码错误!");

    }
    private void back()
    {
        Debug.Log("111");
    }
    private void close()
    {
        Debug.Log("222");
    }
    private void eye()
    {
        KeyShow = !KeyShow;
        if (KeyShow)
        {

            KeyInput.contentType = InputField.ContentType.Password;
            KeyInput.Select();
        }
        else
        {


            KeyInput.contentType = InputField.ContentType.Standard;
            KeyInput.Select();
        }
    }


}

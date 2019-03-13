//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UI_StartMainChoosePanel : MonoBehaviour {

    private Button SignUpBtn;//注册按钮
    private Button SignInBtn;//登陆按钮
	void Start () {
        Find();
	}
    private void Find()
    {
        SignUpBtn = transform.Find("SignUpBtn").GetComponent<Button>();
        SignInBtn = transform.Find("SignInBtn").GetComponent<Button>();
        SignUpBtn.onClick.AddListener(SignUp);
        SignInBtn.onClick.AddListener(SignIn);
        
    }
    private void SignUp()
    {
        gameObject.SetActive(false);
        transform.parent.Find("SignUpPanel").gameObject.SetActive(true);
    }
    private void SignIn()
    {
        gameObject.SetActive(false);
        transform.parent.Find("SignInPanel").gameObject.SetActive(true);
    }
	
	
}

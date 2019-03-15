//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UI_StartMainSignUpPanel : MonoBehaviour {



    private InputField AccountInput;
    private InputField KeyInput;
    private Button SignUpBtn;
    private Button eyeBtn;
    private bool KeyShow = true;


	void Start () {
        Find();
	}
    private void Find()
    {
        AccountInput = transform.Find("bg/AccountInput").GetComponent<InputField>();
        KeyInput = transform.Find("bg/KeyInput").GetComponent<InputField>();
        SignUpBtn = transform.Find("bg/SignUpBtn").GetComponent<Button>();
        eyeBtn = transform.Find("bg/eyeBtn").GetComponent<Button>();
        eyeBtn.onClick.AddListener(eye);
        SignUpBtn.onClick.AddListener(SignUp);

    }
    private void Show()
    {
      
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
    private void SignUp()
    {
      
        if(AccountInput.text.Length>7|| AccountInput.text.Length < 3||KeyInput.text.Length>7||KeyInput.text.Length<3)
        {
            UITools.Singeton.CreatHintBox("格式不正确!");
            return;
              
        }
        StartMainManager.Singeton.Account = AccountInput.text;
        StartMainManager.Singeton.Key = KeyInput.text;
        transform.parent.Find("commitPanel").gameObject.SetActive(true);
        gameObject.SetActive(false);
  
    }
	
	
}

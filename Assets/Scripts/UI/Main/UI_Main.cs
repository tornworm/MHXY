//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UI_Main : BaseWindows {

    public  Text text;
   
	void Start () {
        EventController.sInstance.AddListener(this);
        
	}
    public override void OnEventTrigger(Event _Event)
    {
        text.text = _Event.EventParamObj.ToString();
    }


}

//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;




public class UI_ClickTest : MonoBehaviour,IPointerClickHandler {
    public void OnPointerClick(PointerEventData e)
    {
        Debug.Log(e.pointerEnter.gameObject.transform.parent.name);
    }

    void Start () {
		
	}
	
	
}

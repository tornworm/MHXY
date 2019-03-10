//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class UI_Main : MonoBehaviour, IEventListener
{
    private Text capacityText;
    
    void Start () {
       EventController.sInstance.AddListener(this);
        
        capacityText = transform.Find("capacityText").GetComponent<Text>();

     

    }


    public void OnEventTrigger(Event e)
    {
        if (e.EventID == 1111)
        {
            capacityText.text = ExcelEPP.Singeton.GetCapacity(int.Parse( e.EventParamObj.ToString()), 2);
        }
    }

}

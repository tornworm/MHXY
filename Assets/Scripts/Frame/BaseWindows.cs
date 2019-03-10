//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;



public class BaseWindows : MonoBehaviour,IPointerClickHandler
{
    public virtual void Init()
    {

    }
    public virtual void Enter()
    {

    }
    public virtual void Disable()
    {

    }
    public virtual void Destroy()
    {

    }

    public virtual void OnPointerClick(PointerEventData e)
    {
        Debug.Log("1111");
    }
}
  

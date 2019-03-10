//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LeanCloud;



public class AVInit : MonoBehaviour {

	
	void Awake () {
        AVClient.Initialize("{{appid}}", "{{appkey}}");
    }
	
	
}

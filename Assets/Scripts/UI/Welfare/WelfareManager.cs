using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelfareManager : MonoBehaviour {

	private static WelfareManager singeton;
    public static WelfareManager Singeton
    {
        get
        {
            if (singeton == null)
            {
                singeton = new WelfareManager();
            }
            return singeton;
        }
    }
    private WelfareManager() { }

    public int Panel1Count = 7;

}

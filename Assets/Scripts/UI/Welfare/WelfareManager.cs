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

    //Panel1里面的Cell数量
    public int Panel1Count = 7;

    //Panel3里面的Cell数量
    public int Panel3Count = 6;

    //Panel5里面的Cell数量
    public int Panel5Count = 12;


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV : MonoBehaviour   {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log (1);
			if(CharacterManager.Singleton.Lv<CharacterManager.Singleton.MaxLv)
			{
			CharacterManager.Singleton.Lv += 1;
			CharacterManager.Singleton.MaxHp += 70;
			CharacterManager.Singleton.MaxMp += 30;
			CharacterManager.Singleton.ATN += 5;
			CharacterManager.Singleton.INT += 3;
			CharacterManager.Singleton.DEL += 3;
			CharacterManager.Singleton.MDEL += 3;
			CharacterManager.Singleton.Speed += 1;
			CharacterManager.Singleton.MaxExp += 3700;
			SendE ();
			}

		}
	}
	private void SendE()

	{
		Event e = new Event ();
		e.EventID = 1002;
		EventController.sInstance.PushEvent (e);
	}
		

}

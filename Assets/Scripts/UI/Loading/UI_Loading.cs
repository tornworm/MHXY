//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UI_Loading : MonoBehaviour {

    public Image image;
    public Sprite[] sprites;
	void Start () {
        image.sprite = sprites[Random.Range(1, sprites.Length)];
	}
	
	
}

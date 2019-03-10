

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UI_TextBox : MonoBehaviour {


    public string textStr;
    private Transform box;
    private Image bg;
    private Text str;
    private Vector3 pos;
    void Start () {

        box = transform.Find("box").transform;
        bg = box.transform.Find("bg").GetComponent<Image>();
        str = box.transform.Find("Text").GetComponent<Text>();
        str.text = textStr;
        pos = box.position;
        StartCoroutine("UpSwim",0.2f);
        
	}
    IEnumerator UpSwim()
    {
        for (int i = 0; i < 20; i++)
        {
            box.position = pos + new Vector3(0, i*20, 0);
            bg.color = new Color(bg.color.r, bg.color.g, bg.color.b,1- i / 20f);
            str.color=new Color(str.color.r, str.color.g, str.color.b, 1 - i / 20f);
            yield return new WaitForSecondsRealtime(0.02f);
        }
        bg.color = new Color(0,0,0,0);
        str.color =  new Color(0, 0, 0, 0);
        yield return null;
        Destroy(gameObject);

    }
    private void OnDestroy()
    {
        CancelInvoke("UpSwim");
    }



}

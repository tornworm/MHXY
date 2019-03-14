using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_WelfarePanel3 : MonoBehaviour {

    private GameObject cell;

	// Use this for initialization
	void Start () {
        Find();
        Init();
	}
    void Find()
    {
        cell = transform.Find("Week/View/Content/WeekCell").gameObject;
    }
    void Init()
    {
        for (int i = 0; i < WelfareManager.Singeton.Panel3Count; i++)
        {
            GameObject tmpCell = Instantiate(cell);
            tmpCell.transform.parent = cell.transform.parent;
            tmpCell.SetActive(true);
            tmpCell.name = (i+1).ToString();
        }
    }
}

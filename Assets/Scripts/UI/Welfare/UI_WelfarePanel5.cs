﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_WelfarePanel5 : MonoBehaviour {

    private GameObject cell;

	// Use this for initialization
	void Start () {
        Find();
        Init();
	}
    void Find()
    {
        cell = transform.Find("Image/Gift/View/Content/Cell").gameObject;
    }

    //生成一定数量的表格
    void Init()
    {
        for (int i = 0; i < WelfareManager.Singeton.Panel5Count; i++)
        {
            GameObject tmpCell = Instantiate(cell);
            tmpCell.transform.parent = cell.transform.parent;
            tmpCell.SetActive(true);
            tmpCell.name = (i+1).ToString();
        }
    }

}

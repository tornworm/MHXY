//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UI_PetSkillChoose : MonoBehaviour {



    private GameObject ScrollView;//选择技能书滑动区域
    private GameObject Cell;//技能树基类Prefab
    private List<GameObject> CellList = new List<GameObject>();//技能书Prefab列表
    private List<int> SkillList = new List<int>();//技能书列表

	void Start () {

        ScrollView = transform.Find("S1").gameObject;
        Cell = ScrollView.transform.Find("S2/S3/cell").gameObject;
        CloneCell();


    }

    private void CloneCell()//克隆当前拥有的技能书
    {
        for (int i = 0; i < 30; i++)
        {
            GameObject tmpCell = Instantiate(Cell);
            tmpCell.transform.SetParent(Cell.transform.parent);
            tmpCell.transform.localPosition = Vector3.zero;
            tmpCell.transform.localScale = Vector3.one;
            tmpCell.SetActive(true);
            tmpCell.name = i.ToString();
            
        }
        
      

    }
	
	
}

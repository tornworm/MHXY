using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_CharacterPanel1 : BaseWindows {

     
    //数据



    //面板
    //左侧面板

    private Image characterIcon;//人物头像
    private Image characterGroup;//人物职业
    private Text characterNickName;//人物姓名
    private Text characterLevel;//人物级别
    private Text characterID;//人物ID
	private Text chengwei;//人物的称谓

	//右侧面板
	private Text hptext;//人物气血
	private Text maxhptext;//人物最大气血
	private Text mptext;//人物魔法
	private Text maxmptext;//人物最大魔法
	private Text nqtext;//人物愤怒
	private Text maxnqtext;//人物最大愤怒
	private Text hltext;//人物活力
	private Text maxhitext;//人物最大活力
	private Text exptext;//人物经验值
	private Text maxexptext;//人物最大经验值
	private Text yingliexp;//人物的盈利经验
	private Text ATN;//人物的攻击力
	private Text INT;//人物的魔法攻击力
	private Text DEL;//人物的物理防御力
	private Text MDEL;//人物的魔法防御力
	private Text CTA;//人物的暴击率
	private Text ICTA;//人物的魔法暴击率
	private Text CHR;//人物的暴击伤害
	private Text SEAL;//人物的封印命中
	private Text Speed;//人物的速度
	private Text ResisTanceSeal;//人物的抵抗封印
	private Text ResisTancecta;//人物的物理抗暴率
	private Text ResisTanceicta;//人物的魔法抗暴率
	private Text TreaTment;//人物的治疗强度

    private GameObject lowTab;//基础属性信息标签
    private GameObject highTab;//高级属性信息标签
    private GameObject lowPanel;//基础属性面板
    private GameObject HighPanel;//高级属性面板
    private List<GameObject> tabImg = new List<GameObject>();
    private List<GameObject> panel = new List<GameObject>();


    //右侧面板
	
	void Start () {

        Find();//动态找到面板中对应的组件
        Show();//将数据更新到面板上
		EventController.sInstance.AddListener(this);
	}

	public override void OnEventTrigger (Event _Event)
	{
		if (_Event.EventID == 1002)
		{
			Show ();
		}

	}


    private void Show() {
       // characterID.text=
        
		characterLevel.text = CharacterManager.Singleton.Lv.ToString();
		maxhptext.text = "/"+CharacterManager.Singleton.MaxHp.ToString();
		maxmptext.text = "/"+CharacterManager.Singleton.MaxMp.ToString ();
		ATN.text = CharacterManager.Singleton.ATN.ToString ();
		INT.text = CharacterManager.Singleton.INT.ToString ();
		DEL.text = CharacterManager.Singleton.DEL.ToString ();
		MDEL.text = CharacterManager.Singleton.MDEL.ToString ();
		Speed.text = CharacterManager.Singleton.Speed.ToString ();
		maxexptext.text = "/"+CharacterManager.Singleton.MaxExp.ToString ();

    }
    private void Find() {
        lowTab = transform.Find("right/jichu/jichuImage").gameObject;
        highTab = transform.Find("right/gaoji/gaojiImage").gameObject;
       lowPanel=  transform.Find("right/jichu/kuang").gameObject;
       HighPanel = transform.Find("right/gaoji/kuang").gameObject;
		characterIcon = transform.Find ("left/kuang/xiaotouxiang").GetComponent<Image> ();
		characterGroup = transform.Find ("left/biaoshi").GetComponent<Image> ();
		characterNickName = transform.Find ("left/Image/name").GetComponent<Text> ();
		characterLevel = transform.Find ("left/Image/lv").GetComponent<Text> ();
		characterID = transform.Find ("left/ID").GetComponent<Text> ();
		chengwei = transform.Find ("left/chengwei").GetComponent<Text> ();
		hptext = transform.Find ("right/HP/hptext").GetComponent<Text> ();
		maxhptext = transform.Find ("right/HP/maxhptext").GetComponent<Text> ();
		mptext = transform.Find ("right/MP/mptext").GetComponent<Text> ();
		maxmptext = transform.Find ("right/MP/maxmptext").GetComponent<Text> ();
		nqtext = transform.Find ("right/nuqi/nqtext").GetComponent<Text> ();
		maxnqtext = transform.Find ("right/nuqi/maxnuqitext").GetComponent<Text> ();
		hltext = transform.Find ("right/huoli/hl/Background/Fill/hltext").GetComponent<Text> ();
		maxhitext = transform.Find ("right/huoli/hl/Background/Fill/maxhltext").GetComponent<Text> ();
		exptext = transform.Find ("right/gaoji/exp/Background/Fill/exptext").GetComponent<Text> ();
		maxexptext = transform.Find ("right/gaoji/exp/Background/Fill/maxexptext").GetComponent<Text> ();
		yingliexp = transform.Find ("right/EXP/yingli/Text").GetComponent<Text> ();
		ATN = transform.Find ("right/jichu/kuang/ATN/Text").GetComponent<Text> ();
		INT = transform.Find ("right/jichu/kuang/INT/Text").GetComponent<Text> ();
		DEL = transform.Find ("right/jichu/kuang/DEL/Text").GetComponent<Text> ();
		MDEL = transform.Find ("right/jichu/kuang/MDEL/Text").GetComponent<Text> ();
		Speed = transform.Find ("right/jichu/kuang/Speed/Text").GetComponent<Text> ();
		TreaTment = transform.Find ("right/jichu/kuang/zl/Text").GetComponent<Text> ();



       tabImg.Clear();
       panel.Clear();
       tabImg.Add(lowTab);
       tabImg.Add(highTab);
       panel.Add(lowPanel);
       panel.Add(HighPanel);


		SetTab(0);
    }
	public override void OnPointerClick(PointerEventData e) 
    {
        if (e.pointerEnter.name == "jichu") {
            SetTab(0);
        } else if (e.pointerEnter.name == "gaoji") {
            SetTab(1);
        }

    }
    private void SetTab(int id) {
        for (int i = 0; i < 2; i++) {

            if (i == id) {

                tabImg[i].SetActive(true);
                panel[i].SetActive(true);
            } else {
                tabImg[i].SetActive(false);
                panel[i].SetActive(false);

            }
        }
    }
}

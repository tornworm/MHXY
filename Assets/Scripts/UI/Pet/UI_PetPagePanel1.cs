using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_PetPagePanel1 : BaseWindows
{
    //左侧面板
    private Text PetName;//宠物名称
    private Image PetImg;//宠物图片
    private Image BabyImg;//宠物状态--宝宝
    private Image WildImg;//宠物状态--野生
    private Image ChangeImg;//宠物状态--变异
    private Image Combat;//宠物出战图片
    private Text ScoreText;//宠物评分
    private GameObject PetCell;//宠物选择的头像预制体

    //面板
    private GameObject PanelLeft;//左侧面板
    private GameObject PanelBasicsShow;//基础属性右侧面板
    private GameObject PanelSkillShow;//资质技能右侧面板
    private GameObject PanelInsideShow;//宠物内丹右侧面板

    //三个点击的图片切换
    private GameObject BasicsClickImg;//点击时显示的基础属性图片
    private GameObject SkillClickImg;//点击时显示的资质技能图片
    private GameObject InsideClickImg;//点击时显示的宠物内丹图片

    //基础属性面板
    private Slider HpSlider;//血条
    private Text MaxHp;//最大血量
    private Text NowHp;//当前血量

    private Slider MpSlider;//蓝条
    private Text MaxMp;//最大蓝量
    private Text NowMp;//当前蓝量

    private Slider ExpSlider;//经验条
    private Text MaxExp;//需要经验
    private Text NowExp;//当前经验

    private Text PhyHarmNum;//物理伤害
    private Text PhyDefNum;//物理防御
    private Text MagicHarmNum;//法术伤害
    private Text MagicDefNum;//法术防御
    private Text SpeedNum;//速度
    private Text ResistNum;//抵抗封印

    //资质技能面板
    private Slider AtkSlider;//攻击资质滑动条
    private Text AtkNum;//攻击资质数值
    private Slider DefSlider;//防御资质滑动条
    private Text DefNum;//防御资质数值
    private Slider BodySlider;//体力资质滑动条
    private Text BodyNum;//体力资质数值
    private Slider MpAptSlider;//法力资质滑动条
    private Text MpAptNum;//法力资质数值
    private Slider SpeedAptSlider;//速度资质滑动条
    private Text SpeedAptNum;//速度资质数值
    private Text GrowNum;//宠物成长数值
    private Text LifeNum;//宠物寿命数值
    private GameObject Skillcell;//宠物技能格子

    //宠物内丹面板
    private Image CentreImg;//高级内丹图片
    private Image Circle01Img;//内丹1
    private Image Circle02Img;//内丹2
    private Image Circle03Img;//内丹3
    private Image Circle05Img;//内丹5

    private Image CentreAdd;//点击增加高级内丹
    private Image CircleAdd01;//点击增加内丹1
    private Image CircleAdd02;//点击增加内丹2
    private Image CircleAdd03;//点击增加内丹3
    private Image CircleAdd05;//点击增加内丹5

    private GameObject ChooseImg1;//选择内丹1
    private GameObject ChooseImg2;//选择内丹2
    private GameObject ChooseImg3;//选择内丹3
    private GameObject ChooseImg5;//选择内丹4
    private GameObject ChooseCentreImg;//选择高级内丹

    //面板表
    List<GameObject> PanelList = new List<GameObject>();
    //内丹选择表
    List<GameObject> ChooseImgList = new List<GameObject>();
    //点击图片切换表
    List<GameObject> ClickImgList = new List<GameObject>();

	void Start ()
    {
        Find();
        Show();
        PanelAndClickImg(0);
        Choose(0);
	}

	void Find()
    {
        //左侧面板
        PetName = transform.Find("BgLeft/LeftHead/PetName").GetComponent<Text >();
        PetImg = transform.Find("BgLeft/PetImgBg/PetImg").GetComponent<Image>();
        BabyImg = transform.Find("BgLeft/PetImgBg/BabyImg").GetComponent<Image>();
        WildImg = transform.Find("BgLeft/PetImgBg/WildImg").GetComponent<Image>();
        ChangeImg = transform.Find("BgLeft/PetImgBg/ChangeImg").GetComponent<Image>();
        Combat = transform.Find("BgLeft/PetImgBg/Combat").GetComponent<Image>();
        ScoreText = transform.Find("BgLeft/PetImgBg/Score/ScoreText").GetComponent<Text>();

        PetCell = transform.Find("BgLeft/DownBg/PetScrollView/Viewport/Content/PetCell").gameObject;

        //基础属性面板
        HpSlider = transform.Find("BgRight/BasicsShow/Hp/HpSlider").GetComponent<Slider>();
        MaxHp = transform.Find("BgRight/BasicsShow/Hp/MaxHpText").GetComponent<Text>();
        NowHp = transform.Find("BgRight/BasicsShow/Hp/NowHpText").GetComponent<Text>();

        MpSlider = transform.Find("BgRight/BasicsShow/Mp/MpSlider").GetComponent<Slider>();
        MaxMp = transform.Find("BgRight/BasicsShow/Mp/MaxMpText").GetComponent<Text>();
        NowMp = transform.Find("BgRight/BasicsShow/Mp/NowMpText").GetComponent<Text>();

        ExpSlider = transform.Find("BgRight/BasicsShow/Exp/ExpSlider").GetComponent<Slider>();
        MaxExp = transform.Find("BgRight/BasicsShow/Exp/MaxExpText").GetComponent<Text>();
        NowExp = transform.Find("BgRight/BasicsShow/Exp/NowExpText").GetComponent<Text>();

        PhyHarmNum = transform.Find("BgRight/BasicsShow/PhyHarm/PhyHarmNum").GetComponent<Text>();
        PhyDefNum = transform.Find("BgRight/BasicsShow/PhyDef/PhyDefNum").GetComponent<Text>();
        MagicHarmNum = transform.Find("BgRight/BasicsShow/MagicHarm/MagicHarmNum").GetComponent<Text>();
        MagicDefNum = transform.Find("BgRight/BasicsShow/MagicDef/MagicDefNum").GetComponent<Text>();
        SpeedNum = transform.Find("BgRight/BasicsShow/Speed/SpeedNum").GetComponent<Text>();
        ResistNum = transform.Find("BgRight/BasicsShow/Resist/ResistNum").GetComponent<Text>();

        //资质技能面板
        AtkSlider = transform.Find("BgRight/SkillShow/PetSlide/AtkApt/AtkSlider").GetComponent<Slider>();
        AtkNum = transform.Find("BgRight/SkillShow/PetSlide/AtkApt/AtkNum").GetComponent<Text>();

        DefSlider = transform.Find("BgRight/SkillShow/PetSlide/DefApt/DefSlider").GetComponent<Slider>();
        DefNum = transform.Find("BgRight/SkillShow/PetSlide/DefApt/DefNum").GetComponent<Text>();

        BodySlider = transform.Find("BgRight/SkillShow/PetSlide/BodyApt/BodySlider").GetComponent<Slider>();
        BodyNum = transform.Find("BgRight/SkillShow/PetSlide/BodyApt/BodyNum").GetComponent<Text>();

        MpAptSlider = transform.Find("BgRight/SkillShow/PetSlide/MpApt/MpSlider").GetComponent<Slider>();
        MpAptNum = transform.Find("BgRight/SkillShow/PetSlide/MpApt/MpNum").GetComponent<Text>();

        SpeedAptSlider = transform.Find("BgRight/SkillShow/PetSlide/SpeedApt/SpeedSlider").GetComponent<Slider>();
        SpeedAptNum = transform.Find("BgRight/SkillShow/PetSlide/SpeedApt/SpeedNum").GetComponent<Text>();

        GrowNum = transform.Find("BgRight/SkillShow/PetSlide/Grow/GrowNum").GetComponent<Text>();
        LifeNum = transform.Find("BgRight/SkillShow/PetSlide/Life/LifeNum").GetComponent<Text>();

        Skillcell = transform.Find("BgRight/SkillShow/SkillScrollView/Viewport/Content/SkillCell").gameObject;

        //宠物内丹面板
        CentreImg = transform.Find("BgRight/InsideShow/Centre/CentreImg").GetComponent<Image>();
        Circle01Img = transform.Find("BgRight/InsideShow/Circle01/Circle01Img").GetComponent<Image>();
        Circle02Img = transform.Find("BgRight/InsideShow/Circle02/Circle02Img").GetComponent<Image>();
        Circle03Img = transform.Find("BgRight/InsideShow/Circle03/Circle03Img").GetComponent<Image>();
        Circle05Img = transform.Find("BgRight/InsideShow/Circle05/Circle05Img").GetComponent<Image>();

        CentreAdd = transform.Find("BgRight/InsideShow/Centre/CentreAdd").GetComponent<Image>();
        CircleAdd01 = transform.Find("BgRight/InsideShow/Circle01/CircleAdd01").GetComponent<Image>();
        CircleAdd02 = transform.Find("BgRight/InsideShow/Circle02/CircleAdd02").GetComponent<Image>();
        CircleAdd03 = transform.Find("BgRight/InsideShow/Circle03/CircleAdd03").GetComponent<Image>();
        CircleAdd05 = transform.Find("BgRight/InsideShow/Circle05/CircleAdd05").GetComponent<Image>();

        
        //面板
        PanelLeft = transform.Find("BgLeft").gameObject;
        PanelBasicsShow = transform.Find("BgRight/BasicsShow").gameObject;
        PanelSkillShow = transform.Find("BgRight/SkillShow").gameObject;
        PanelInsideShow = transform.Find("BgRight/InsideShow").gameObject;

        //点击图片的切换
        BasicsClickImg = transform.Find("BgRight/BasicsImg/ClickImg").gameObject;
        SkillClickImg = transform.Find("BgRight/SkillImg/ClickImg").gameObject;
        InsideClickImg = transform.Find("BgRight/InsideImg/ClickImg").gameObject;

        //内丹选择
        ChooseImg1 = transform.Find("BgRight/InsideShow/Circle01/Choose").gameObject;
        ChooseImg2 = transform.Find("BgRight/InsideShow/Circle02/Choose").gameObject;
        ChooseImg3 = transform.Find("BgRight/InsideShow/Circle03/Choose").gameObject;
        ChooseImg5 = transform.Find("BgRight/InsideShow/Circle05/Choose").gameObject;
        ChooseCentreImg = transform.Find("BgRight/InsideShow/Centre/Choose").gameObject;

    }

    void Show()
    {
        PanelList.Clear();
        PanelList.Add(PanelBasicsShow);
        PanelList.Add(PanelSkillShow);
        PanelList.Add(PanelInsideShow);

        ChooseImgList.Clear();
        ChooseImgList.Add(ChooseImg1);
        ChooseImgList.Add(ChooseImg2);
        ChooseImgList.Add(ChooseImg3);
        ChooseImgList.Add(ChooseImg5);
        ChooseImgList.Add(ChooseCentreImg);

        ClickImgList.Clear();
        ClickImgList.Add(BasicsClickImg);
        ClickImgList.Add(SkillClickImg);
        ClickImgList.Add(InsideClickImg);
    }

    public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData e)
    {
        if (e.pointerEnter.name=="BasicsImg")
        {
            PanelAndClickImg(0);
        }
        else if (e.pointerEnter.name == "SkillImg")
        {
            PanelAndClickImg(1);
        }
        else if (e.pointerEnter.name == "InsideImg")
        {
            PanelAndClickImg(2);
        }

        if (e.pointerEnter.name == "CircleAdd01")
        {
            Choose(0);
        }
        else if (e.pointerEnter.name == "CircleAdd02")
        {
            Choose(1);
        }
        else if (e.pointerEnter.name == "CircleAdd03")
        {
            Choose(2);
        }
        else if (e.pointerEnter.name == "CircleAdd05")
        {
            Choose(3);
        }
        else if (e.pointerEnter.name == "CentreAdd")
        {
            Choose(4);
        }
    }

    private void PanelAndClickImg(int id)
    {
        for (int i = 0; i < 3; i++)
        {
            if (i==id)
            {
                PanelList[i].SetActive(true);
                ClickImgList[i].SetActive(true);
            }
            else
            {
                PanelList[i].SetActive(false);
                ClickImgList[i].SetActive(false);
            }
        }
    }


    private void Choose(int id)
    {
        for (int i = 0; i < 5; i++)
        {
            if (i == id)
            {
                ChooseImgList[i].SetActive(true);
            }
            else
            {
                ChooseImgList[i].SetActive(false);
            }
        }
    }

}

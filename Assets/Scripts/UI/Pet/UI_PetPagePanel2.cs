using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_PetPagePanel2 : BaseWindows
{
    //四个选项的点击切换
    private GameObject UpDateClick;//点击洗炼
    private GameObject JoinPetClick;//点击合宠
    private GameObject LearnClick;//点击学技能
    private GameObject CherishPetClick;//点击珍兽合宠

    //面板
    private GameObject PanelUpDate;//洗炼面板
    private GameObject PanelJionPet;//合宠面板
    private GameObject PanelLearn;//学技能面板
    private GameObject CherishPet;//珍兽合宠面板
    public GameObject PanelChangePet;//选择宠物面板

    //通用面板
    private Image PetImg;//宠物图片
    private Image BabyImg;//宠物状态--宝宝
    private Image WildImg;//宠物状态--野生
    private Image ChangeImg;//宠物状态--变异
    private Image Combat;//宠物出战图片
    private Text ScoreText;//宠物评分
    private GameObject PetCell;//宠物选择的头像预制体

    //洗炼面板
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
    private Button StartBtn;//洗炼开始按钮
    private Button MtlBtn;//金柳露按钮---可弹出金柳露使用作用

    //合宠面板左
    private Image PetAddLeft;//左边加号
    private Image PetImgLeft;//左侧宠物增加所使用图片
    private Text AtkNumLeft;//攻击资质数值
    private Text DefNumLeft;//防御资质数值
    private Text BodyNumLeft;//体力资质数值
    private Text MpNumLeft;//法力资质数值
    private Text SpeedNumLeft;//速度资质数值
    private Text GrowNumLeft;//成长数值
    private Text LifeNumLeft;//寿命数值
    private GameObject JionSkillCellLeft;//宠物技能栏
    private Button CenTreBtn;//合成按钮
    private Button Btn;//感叹号按钮

    //右
    private Image PetAddRight;//右边加号
    private Image PetImgRight;//右侧宠物增加所使用图片
    private Text AtkNumRight;//攻击资质数值
    private Text DefNumRight;//防御资质数值
    private Text BodyNumRight;//体力资质数值
    private Text MpNumRight;//法力资质数值
    private Text SpeedNumRight;//速度资质数值
    private Text GrowNumRight;//成长数值
    private Text LifeNumRight;//寿命数值
    private GameObject JionSkillCellRight;//宠物技能栏

    //学技能右侧面板
    private GameObject LearnSkillClass;//学技能面板所加入的要学的新技能
    private Text SkillName;//要学习的技能名称
    private Button LearnBtn;//学习按钮
    private GameObject SelfSkillClass;//本来有的技能

    //珍兽合宠右侧面板
    private Image AddGridRight;//添加变异宠物的框
    private Image PetAddImgRight;//变异宠物的图片
    private Text NamePetRight;//变异宠物名字
    private Text CherishAtkNumRight;//攻击资质数值
    private Text CherishDefNumRight;//防御资质数值
    private Text CherishBodyNumRight;//体力资质数值
    private Text CherishMpNumRight;//法力资质数值
    private Text CherishSpeedNumRight;//速度资质数值
    private Text CherishGrowNumRight;//成长数值
    private Text CherishLifeNumRight;//寿命数值
    private GameObject CherishSkillCellRight;//宠物技能栏

    //珍兽合宠左侧面板
    private Button CompoundBtn;//合成按钮
    private Image AddGridLeft;//添加变异宠物的框
    private Image PetAddImgLeft;//珍兽宠物的图片
    private Text NamePetLeft;//珍兽宠物名字
    private Text CherishAtkNumLeft;//攻击资质数值
    private Text CherishDefNumLeft;//防御资质数值
    private Text CherishBodyNumLeft;//体力资质数值
    private Text CherishMpNumLeft;//法力资质数值
    private Text CherishSpeedNumLeft;//速度资质数值
    private Text CherishGrowNumLeft;//成长数值
    private Text CherishLifeNumLeft;//寿命数值
    private GameObject CherishSkillCellLeft;//宠物技能栏

    //选择宠物面板
    private Text PetName;//宠物名字
    private Slider ChangePetAtkSlider;//攻击资质滑动条
    private Text ChangePetAtkNum;//攻击资质数值
    private Slider ChangePetDefSlider;//防御资质滑动条
    private Text ChangePetDefNum;//防御资质数值
    private Slider ChangePetBodySlider;//体力资质滑动条
    private Text ChangePetBodyNum;//体力资质数值
    private Slider ChangePetMpAptSlider;//法力资质滑动条
    private Text ChangePetMpAptNum;//法力资质数值
    private Slider ChangePetSpeedAptSlider;//速度资质滑动条
    private Text ChangePetSpeedAptNum;//速度资质数值
    private Text ChangePetGrowNum;//宠物成长数值
    private Text ChangePetLifeNum;//宠物寿命数值
    private GameObject ChangePetSkillcell;//宠物技能格子
    private Button ChooseBtn;//选择按钮
    private GameObject ChangePetcell;//宠物技能格子
    private Image BackBtn;//关闭选择面板按钮

    //面板表
    List<GameObject> PanelList = new List<GameObject>();
    //点击图片切换表
    List<GameObject> ClickImgList = new List<GameObject>();

	void Start () 
    {
        Find();
        Show();
        PanelChange(0);
        PetChange(0);
	}

    void Find()
    {
        //四个选项的点击切换
        UpDateClick = transform.Find("HeadBtn/UpDate/ClickImg").gameObject;
        JoinPetClick = transform.Find("HeadBtn/JoinPet/ClickImg").gameObject;
        LearnClick = transform.Find("HeadBtn/Learn/ClickImg").gameObject;
        CherishPetClick = transform.Find("HeadBtn/CherishPet/ClickImg").gameObject;

        //面板
        PanelUpDate = transform.Find("UpDateShow").gameObject;
        PanelJionPet = transform.Find("JionPetShow").gameObject;
        PanelLearn = transform.Find("LearnShow").gameObject;
        CherishPet = transform.Find("CherishPetShow").gameObject;
        PanelChangePet = transform.Find("JoinPetChange").gameObject;

        //通用面板
        PetImg = transform.Find("PetImgBg/PetImg").GetComponent<Image>();
        BabyImg = transform.Find("PetImgBg/BabyImg").GetComponent<Image>();
        WildImg = transform.Find("PetImgBg/WildImg").GetComponent<Image>();
        ChangeImg = transform.Find("PetImgBg/ChangeImg").GetComponent<Image>();
        Combat = transform.Find("PetImgBg/Combat").GetComponent<Image>();
        ScoreText = transform.Find("PetImgBg/Score/ScoreText").GetComponent<Text>();
        PetCell = transform.Find("PetImgBg/DownBg/PetScrollView/Viewport/Content/PetCell").gameObject;

        //洗炼面板
        AtkSlider = transform.Find("UpDateShow/PetSlide/AtkApt/AtkSlider").GetComponent<Slider>();
        AtkNum = transform.Find("UpDateShow/PetSlide/AtkApt/AtkNum").GetComponent<Text>();

        DefSlider = transform.Find("UpDateShow/PetSlide/DefApt/DefSlider").GetComponent<Slider>();
        DefNum = transform.Find("UpDateShow/PetSlide/DefApt/DefNum").GetComponent<Text>();

        BodySlider = transform.Find("UpDateShow/PetSlide/BodyApt/BodySlider").GetComponent<Slider>();
        BodyNum = transform.Find("UpDateShow/PetSlide/BodyApt/BodyNum").GetComponent<Text>();

        MpAptSlider = transform.Find("UpDateShow/PetSlide/MpApt/MpSlider").GetComponent<Slider>();
        MpAptNum = transform.Find("UpDateShow/PetSlide/MpApt/MpNum").GetComponent<Text>();

        SpeedAptSlider = transform.Find("UpDateShow/PetSlide/SpeedApt/SpeedSlider").GetComponent<Slider>();
        SpeedAptNum = transform.Find("UpDateShow/PetSlide/SpeedApt/SpeedNum").GetComponent<Text>();

        GrowNum = transform.Find("UpDateShow/PetSlide/Grow/GrowNum").GetComponent<Text>();
        LifeNum = transform.Find("UpDateShow/PetSlide/Life/LifeNum").GetComponent<Text>();

        Skillcell = transform.Find("UpDateShow/SkillScrollView/Viewport/Content/SkillCell").gameObject;
        StartBtn = transform.Find("UpDateShow/StartBtn").GetComponent<Button>();
        MtlBtn = transform.Find("UpDateShow/MtlBtn").GetComponent<Button>();

        //合宠面板左
        PetAddImgLeft = transform.Find("JionPetShow/JionPetLeft/AddGrid").GetComponent<Image>();
        PetImgLeft = transform.Find("JionPetShow/JionPetLeft/AddGrid/PetImg").GetComponent<Image>();
        AtkNumLeft = transform.Find("JionPetShow/JionPetLeft/AtkApt/AtkNum").GetComponent<Text>();
        DefNumLeft = transform.Find("JionPetShow/JionPetLeft/DefApt/DefNum").GetComponent<Text>();
        BodyNumLeft = transform.Find("JionPetShow/JionPetLeft/BodyApt/BodyNum").GetComponent<Text>();
        MpNumLeft = transform.Find("JionPetShow/JionPetLeft/MpApt/MpNum").GetComponent<Text>();
        SpeedNumLeft = transform.Find("JionPetShow/JionPetLeft/SpeedApt/SpeedNum").GetComponent<Text>();
        GrowNumLeft = transform.Find("JionPetShow/JionPetLeft/Grow/GrowNum").GetComponent<Text>();
        LifeNumLeft = transform.Find("JionPetShow/JionPetLeft/Life/LifeNum").GetComponent<Text>();
        JionSkillCellLeft = transform.Find("JionPetShow/JionPetLeft/SkillScrollView/Viewport/Content/SkillCell").gameObject;
        CenTreBtn = transform.Find("JionPetShow/JionPetLeft/CenTreBtn").GetComponent<Button>();
        Btn = transform.Find("JionPetShow/JionPetLeft/Btn").GetComponent<Button>();

        //合宠面板右
        PetAddImgRight = transform.Find("JionPetShow/JionPetRight/AddGrid").GetComponent<Image>();
        PetImgRight = transform.Find("JionPetShow/JionPetRight/AddGrid/PetImg").GetComponent<Image>();
        AtkNumRight = transform.Find("JionPetShow/JionPetRight/AtkApt/AtkNum").GetComponent<Text>();
        DefNumRight = transform.Find("JionPetShow/JionPetRight/DefApt/DefNum").GetComponent<Text>();
        BodyNumRight = transform.Find("JionPetShow/JionPetRight/BodyApt/BodyNum").GetComponent<Text>();
        MpNumRight = transform.Find("JionPetShow/JionPetRight/MpApt/MpNum").GetComponent<Text>();
        SpeedNumRight = transform.Find("JionPetShow/JionPetRight/SpeedApt/SpeedNum").GetComponent<Text>();
        GrowNumRight = transform.Find("JionPetShow/JionPetRight/Grow/GrowNum").GetComponent<Text>();
        LifeNumRight = transform.Find("JionPetShow/JionPetRight/Life/LifeNum").GetComponent<Text>();
        JionSkillCellLeft = transform.Find("JionPetShow/JionPetRight/SkillScrollView/Viewport/Content/SkillCell").gameObject;

        //学技能右侧面板
        LearnSkillClass = transform.Find("LearnShow/SkillCase/Skill01/SkillClass").gameObject;
        SkillName = transform.Find("LearnShow/SkillName").GetComponent<Text>();
        LearnBtn = transform.Find("LearnShow/LearnBtn").GetComponent<Button>();
        SelfSkillClass = transform.Find("LearnShow/SkillScrollView/Viewport/Content/SkillCell").gameObject;

        //珍兽合宠右侧面板
        AddGridRight = transform.Find("CherishPetShow/CherishPetRight/AddGrid").GetComponent<Image>();
        PetAddImgRight = transform.Find("CherishPetShow/CherishPetRight/AddGrid/PetImg").GetComponent<Image>();
        NamePetRight = transform.Find("CherishPetShow/CherishPetRight/AddGrid/Name").GetComponent<Text>();

        CherishAtkNumRight = transform.Find("CherishPetShow/CherishPetRight/AtkApt/AtkNum").GetComponent<Text>();
        CherishDefNumRight = transform.Find("CherishPetShow/CherishPetRight/DefApt/DefNum").GetComponent<Text>();
        CherishBodyNumRight = transform.Find("CherishPetShow/CherishPetRight/BodyApt/BodyNum").GetComponent<Text>();
        CherishMpNumRight = transform.Find("CherishPetShow/CherishPetRight/MpApt/MpNum").GetComponent<Text>();
        CherishSpeedNumRight = transform.Find("CherishPetShow/CherishPetRight/SpeedApt/SpeedNum").GetComponent<Text>();
        CherishGrowNumRight = transform.Find("CherishPetShow/CherishPetRight/Grow/GrowNum").GetComponent<Text>();
        CherishLifeNumRight = transform.Find("CherishPetShow/CherishPetRight/Life/LifeNum").GetComponent<Text>();
        CherishSkillCellRight = transform.Find("CherishPetShow/CherishPetRight/SkillScrollView/Viewport/Content/SkillCell").gameObject;

        //珍兽合宠左侧面板
        CompoundBtn = transform.Find("CherishPetShow/CherishPetLeft/CompoundBtn").GetComponent<Button>();

        AddGridLeft = transform.Find("CherishPetShow/CherishPetRight/AddGrid").GetComponent<Image>();
        PetAddImgLeft = transform.Find("CherishPetShow/CherishPetRight/AddGrid/PetImg").GetComponent<Image>();
        NamePetLeft = transform.Find("CherishPetShow/CherishPetRight/AddGrid/Name").GetComponent<Text>();

        CherishAtkNumLeft = transform.Find("CherishPetShow/CherishPetLeft/AtkApt/AtkNum").GetComponent<Text>();
        CherishDefNumLeft = transform.Find("CherishPetShow/CherishPetLeft/DefApt/DefNum").GetComponent<Text>();
        CherishBodyNumLeft = transform.Find("CherishPetShow/CherishPetLeft/BodyApt/BodyNum").GetComponent<Text>();
        CherishMpNumLeft = transform.Find("CherishPetShow/CherishPetLeft/MpApt/MpNum").GetComponent<Text>();
        CherishSpeedNumLeft = transform.Find("CherishPetShow/CherishPetLeft/SpeedApt/SpeedNum").GetComponent<Text>();
        CherishGrowNumLeft = transform.Find("CherishPetShow/CherishPetLeft/Grow/GrowNum").GetComponent<Text>();
        CherishLifeNumLeft = transform.Find("CherishPetShow/CherishPetLeft/Life/LifeNum").GetComponent<Text>();
        CherishSkillCellLeft = transform.Find("CherishPetShow/CherishPetLeft/SkillScrollView/Viewport/Content/SkillCell").gameObject;

        //选择宠物面板
        PetName = transform.Find("JoinPetChange/ChangeBg/UpImg/PetName").GetComponent<Text>();

        ChangePetAtkSlider = transform.Find("JoinPetChange/ChangeBg/UpImg/AtkApt/AtkSlider").GetComponent<Slider>();
        ChangePetAtkNum = transform.Find("JoinPetChange/ChangeBg/UpImg/AtkApt/AtkNum").GetComponent<Text>();

        ChangePetDefSlider = transform.Find("JoinPetChange/ChangeBg/UpImg/DefApt/DefSlider").GetComponent<Slider>();
        ChangePetDefNum = transform.Find("JoinPetChange/ChangeBg/UpImg/DefApt/DefNum").GetComponent<Text>();

        ChangePetBodySlider = transform.Find("JoinPetChange/ChangeBg/UpImg/BodyApt/BodySlider").GetComponent<Slider>();
        ChangePetBodyNum = transform.Find("JoinPetChange/ChangeBg/UpImg/BodyApt/BodyNum").GetComponent<Text>();

        ChangePetMpAptSlider = transform.Find("JoinPetChange/ChangeBg/UpImg/MpApt/MpSlider").GetComponent<Slider>();
        ChangePetMpAptNum = transform.Find("JoinPetChange/ChangeBg/UpImg/MpApt/MpNum").GetComponent<Text>();

        ChangePetSpeedAptSlider = transform.Find("JoinPetChange/ChangeBg/UpImg/SpeedApt/SpeedSlider").GetComponent<Slider>();
        ChangePetSpeedAptNum = transform.Find("JoinPetChange/ChangeBg/UpImg/SpeedApt/SpeedNum").GetComponent<Text>();

        ChangePetGrowNum = transform.Find("JoinPetChange/ChangeBg/UpImg/Grow/GrowNum").GetComponent<Text>();
        ChangePetLifeNum = transform.Find("JoinPetChange/ChangeBg/UpImg/Life/LifeNum").GetComponent<Text>();

        ChangePetSkillcell = transform.Find("JoinPetChange/ChangeBg/UpImg/SkillScrollView/Viewport/Content/SkillCell").gameObject;
        ChooseBtn = transform.Find("JoinPetChange/ChangeBg/Button").GetComponent<Button>();
        ChangePetcell = transform.Find("JoinPetChange/ChangeBg/PetScrollView/Viewport/Content/PetCell").gameObject;
        BackBtn = transform.Find("JoinPetChange/BackBtn").GetComponent<Image>();
    }

    void Show()
    {
        PanelList.Clear();
        PanelList.Add(PanelUpDate);
        PanelList.Add(PanelJionPet);
        PanelList.Add(PanelLearn);
        PanelList.Add(CherishPet);
        PanelList.Add(PanelChangePet);

        ClickImgList.Clear();
        ClickImgList.Add(UpDateClick);
        ClickImgList.Add(JoinPetClick);
        ClickImgList.Add(LearnClick);
        ClickImgList.Add(CherishPetClick);
    }

    public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData e)
    {
        if (e.pointerEnter.name == "UpDate")
        {
            PanelChange(0);
            PetChange(0);
        }
        else if (e.pointerEnter.name == "JoinPet")
        {
            PanelChange(1);
            PetChange(1);
        }
        else if (e.pointerEnter.name == "Learn")
        {
            PanelChange(2);
            PetChange(2);
        }
        else if (e.pointerEnter.name == "CherishPet")
        {
            PanelChange(3);
            PetChange(3);
        }
        else if (e.pointerEnter.name == "AddGrid")
        {
            PanelChange(4);
        }

        

    }

    private void PanelChange(int id)
    {
        for (int i = 0; i < 5; i++)
        {
            if (i == id)
            {
                PanelList[i].SetActive(true);
            }
            else
            {
                PanelList[i].SetActive(false);
            }
        }
    }

    private void PetChange(int id)
    {
        for (int i = 0; i < 4; i++)
        {
            if (i == id)
            {
                ClickImgList[i].SetActive(true);
            }
            else
            {
                ClickImgList[i].SetActive(false);
            }
        }
    }

}

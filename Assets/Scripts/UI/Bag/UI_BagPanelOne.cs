using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//背包面板的Panel1 View 类
public class UI_BagPanelOne : BaseWindows
{
    //包裹物品预制体
    GameObject goodPrefab;

    /***********右侧面板变量************/
    #region
    //礼品，整理按钮
    Button giftBtn , cleanBtn;
    //包裹ScrollView的内容父节点
    Transform goodContent , taskContent;
    //按钮点击显示的Image
    GameObject goodImage , taskImage;
    //物品和人物的ScrollView游戏对象
    GameObject goodScroll , taskScroll;
    //物品和任务Scroll中的所有对象
    List<GameObject> goodList , taskList;
    //定义两个List管理物品和任务的切换显示内容
    List<GameObject> imageList;
    List<GameObject> scrollList;
    #endregion

    /***********左侧面板变量************/
    #region
    //装饰，时装，金币增加，银币增加按钮
    Button clothBtn , clothTimeBtn , goldAddBtn , silverAddBtn;
    //金币和银币数量
    Text goldNum , silverNum;
    //人物评分
    Text characterScore;
    //八个装备栏Image
    Image equip1 , equip2 , equip3 , equip4 , equip5 , equip6 , equip7 , equip8;
    List<GameObject> equipList;
    //玩家显示的Image
    Image characterImage;
    #endregion

    void Start ( )
    {
        //查找各个变量
        Find ( );
        //设置默认显示界面(物品界面)
        int index = imageList.IndexOf ( goodImage );
        RightScrollPanelSet ( index );

        //设置物品和任务的格子数量
        ScrollItemCountInit(goodList,goodContent,100);
        ScrollItemCountInit(taskList,taskContent,73);

        //设置背包的物品
        for ( int i = 0 ; i < EquipManager.Singeton.equipDict.Count ; i++ )
        {
            
            Equip _equip;//定义一个装备
            bool isContain=EquipManager.Singeton.equipDict.TryGetValue(1001+i,out _equip);//从字典中读取装备
            if ( isContain )
            {
                Good _good=_equip;//封装成Good类型
                ScrollAddGood ( goodList , _good );//往两个表中添加
                ScrollAddGood ( taskList , _good );
            }
            else
            {
                Debug.Log("字典中不包含这个物品");
            }
            
        }
    }

    //查找各个变量方法
    void Find ( )
    {
        //Right panel variable 
        giftBtn = transform.Find ( "Right/GiftBtn" ).GetComponent<Button> ( );
        cleanBtn = transform.Find ( "Right/CleanBtn" ).GetComponent<Button> ( );
        //注册按钮点击事件
        //先清空所有监听
        giftBtn.onClick.RemoveAllListeners();
        cleanBtn.onClick.RemoveAllListeners();
        //注册监听方法
        giftBtn.onClick.AddListener(OnGiftBtnClick);
        cleanBtn.onClick.AddListener(OnCleanBtnClick);

        goodScroll = transform.Find ( "Right/GoodScroll" ).gameObject;
        goodContent = goodScroll.transform.Find ( "Scroll View/Viewport/Content" );
        taskScroll = transform.Find ( "Right/TaskScroll" ).gameObject;
        taskContent = taskScroll.transform.Find ( "Scroll View/Viewport/Content" );

        //查找物品格子预制体
        goodPrefab=goodContent.Find("GoodClone").gameObject;

        goodImage = transform.Find ( "Right/GoodBtn/ClickImage" ).gameObject;
        taskImage = transform.Find ( "Right/TaskBtn/ClickImage" ).gameObject;

        //初始化Scroll List
        goodList = new List<GameObject> ( );
        taskList = new List<GameObject> ( );

        scrollList = new List<GameObject> ( );
        imageList = new List<GameObject> ( );
        //把点击切换的对象存入List中
        if ( goodScroll != null && taskScroll != null )
        {
            scrollList.Add ( goodScroll );
            scrollList.Add ( taskScroll );
        }
        if ( goodImage != null && taskImage != null )
        {
            imageList.Add ( goodImage );
            imageList.Add ( taskImage );
        }

        //Left panel variable
        clothBtn = transform.Find ( "Left/ClothBtn" ).GetComponent<Button> ( );
        clothTimeBtn = transform.Find ( "Left/ClothTimeBtn" ).GetComponent<Button> ( );
        goldAddBtn = transform.Find ( "Left/GoldBG/GoldAddBtn" ).GetComponent<Button> ( );
        silverAddBtn = transform.Find ( "Left/SilverBG/SilverAddBtn" ).GetComponent<Button> ( );
        //按钮点击事件
        clothBtn.onClick.RemoveAllListeners ( );
        clothTimeBtn.onClick.RemoveAllListeners();
        goldAddBtn.onClick.RemoveAllListeners();
        silverAddBtn.onClick.RemoveAllListeners();

        clothBtn.onClick.AddListener ( OnClothBtnClick );
        clothTimeBtn.onClick.AddListener ( OnClothTimeBtnClick );
        goldAddBtn.onClick.AddListener ( OnGoldAddBtnClick );
        silverAddBtn.onClick.AddListener(OnSilverAddBtnClick);


        goldNum = transform.Find ( "Left/GoldBG/GoldNum" ).GetComponent<Text> ( );
        silverNum = transform.Find ( "Left/SilverBG/SilverNum" ).GetComponent<Text> ( );
        characterScore = transform.Find ( "Left/CharacterScore" ).GetComponent<Text> ( );

        equip1 = transform.Find ( "Left/Equip1" ).GetComponent<Image> ( );
        equip2 = transform.Find ( "Left/Equip2" ).GetComponent<Image> ( );
        equip3 = transform.Find ( "Left/Equip3" ).GetComponent<Image> ( );
        equip4 = transform.Find ( "Left/Equip4" ).GetComponent<Image> ( );
        equip5 = transform.Find ( "Left/Equip5" ).GetComponent<Image> ( );
        equip6 = transform.Find ( "Left/Equip6" ).GetComponent<Image> ( );
        equip7 = transform.Find ( "Left/Equip7" ).GetComponent<Image> ( );
        equip8 = transform.Find ( "Left/Equip8" ).GetComponent<Image> ( );
        equipList=new List<GameObject>();
        equipList.Add ( equip1.gameObject );
        equipList.Add ( equip2.gameObject );
        equipList.Add ( equip3.gameObject );
        equipList.Add ( equip4.gameObject );
        equipList.Add ( equip5.gameObject );
        equipList.Add ( equip6.gameObject );
        equipList.Add ( equip7.gameObject );
        equipList.Add ( equip8.gameObject );

        characterImage = transform.Find ( "Left/Character" ).GetComponent<Image> ( );

        Debug.Log ( "Panel1 Find Success!" );
    }    

    //重写父类的按钮点击物品获取器信息方法
    public override void OnPointerClick ( UnityEngine.EventSystems.PointerEventData e )
    {
        //根据点击到的是任务还是物品切换显示ScrollView内容
        for ( int i = 0 ; i < imageList.Count ; i++ )
        {
            if ( e.pointerEnter == imageList[ i ].transform.parent.gameObject )
            {
                RightScrollPanelSet ( i );
                return;
            }
        }

        //根据Scroll中的Item显示Selectimage
        //如果选中的物体为格子
        if ( e.pointerEnter.name.Contains("GoodClone") )
        {
            //区分是物品还是任务的格子
            if ( goodImage.activeInHierarchy )
            {
                ShowSelectImageInScroll(goodList,e.pointerEnter);
            }
            else
            {
                ShowSelectImageInScroll ( taskList , e.pointerEnter );
            }
        }

        //根据Equip面板选中的Equip显示SelectImage
        if ( e.pointerEnter.name.Contains("Equip") )
        {
           ShowSelectImageInList(equipList,e.pointerEnter);
        }


    }


    #region 右侧面板的方法
    //设置右侧面板物品和任务面板背包的切换
    void RightScrollPanelSet ( int index )
    {
        //索引安全校验
        if ( index < 0 || index >= imageList.Count )
        {
            return;
        }
        //设置显示
        for ( int i = 0 ; i < imageList.Count ; i++ )
        {
            //只显示点击的界面
            if ( i == index )
            {
                imageList[ i ].SetActive ( true );
                scrollList[ i ].SetActive ( true );
            }
            else
            {
                imageList[ i ].SetActive ( false );
                scrollList[ i ].SetActive ( false );
            }
        }
    }
    //礼品点击按钮监听方法
    void OnGiftBtnClick()
    {
        Debug.Log("您点击了礼品呢!");
    }
    //整理点击按钮监听方法
    void OnCleanBtnClick()
    {   
        Debug.Log("您点击了整理按钮呢!");
    }
    

    //往一个背包中添加物品
    public void ScrollAddGood ( List<GameObject> _list , Good _good , int _count = 1 )
    {
        //物品非空校验
        if (  _count > 0 )
        {
            //判断这个物品原来是否已经存在了
            for ( int i = 0 ; i < _list.Count ; i++ )
            {
                UI_BagScrollContentItem item = _list[ i ].GetComponent<UI_BagScrollContentItem> ( );
                if ( item.good.GoodID == _good.GoodID )
                {
                    item.SetGood ( _good , ( item.goodCount + _count ) );
                    //结束方法
                    return;
                }
            }
            //背包里无相同物品，添加物品到新的格子
            //判断是否还有空格子
            for ( int i = 0 ; i < _list.Count ; i++ )
            {
                UI_BagScrollContentItem item = _list[ i ].GetComponent<UI_BagScrollContentItem> ( );
                if ( item.isNone )
                {
                    //有空格子，添加物品到格子中
                    item.SetGood ( _good , _count );
                    //结束方法
                    return;
                }
            }
            //没有空格子了
            Debug.Log ( "您的背包已经满了" );
        }
        else
        {
            Debug.Log("您要往背包里添加的物品为一个空对象!");
        }
    }
    //实例化一个Scroll的格子数量
    public void ScrollItemCountInit ( List<GameObject> _list , Transform _Content , int _count )
    {
        //物品列表非空判断
        if ( _list == null )
        {
            _list = new List<GameObject> ( );
        }
        //实例化格子
        //格子预制体非空校验
        if ( goodPrefab != null )
        {
            //按指定数量实例化出所有格子
            for ( int i = 0 ; i < _count ; i++ )
            {
                GameObject go = Instantiate ( goodPrefab , _Content , false );//实例化出一个格子游戏对象
                go.SetActive(true);//设置其状态为激活
                _list.Add ( go );//添加到List中
            }
        }
        else
        {
            Debug.Log ( "格子的克隆预制体为空!" );
        }

    }
    //背包扩容方法
    public void ScrollItemCountAdd ( List<GameObject> _list ,Transform _Content, int _addCount )
    {
        //数量安全校验
        if ( _addCount<=0 )
        {
            Debug.Log("背包扩容失败，扩容数量不对啊!");
            return;
        }
        //背包非空校验
        if ( _list==null)
        {
            Debug.Log("您要扩容的背包为空啊!");
            return;
        }
        //背包格子预制体非空判断
        if ( goodPrefab==null )
        {
            Debug.Log("您的格子预制体为空哦!");
            return;
        }
        //按指定数量实例化出所有格子
        for ( int i = 0 ; i < _addCount ; i++ )
        {
            GameObject go = Instantiate ( goodPrefab , _Content , false );//实例化出一个格子游戏对象
            _list.Add ( go );//添加到List中
        }
    }
    //使用背包中的物品
    public void ScrollUseGood ( List<GameObject> _list , Good _good , int _count = 1 )
    {
        //先判断_good是否为空
        if ( _good!=null )
        {
            //判断背包中是否存在这个物品
            for ( int i = 0 ; i < _list.Count ; i++ )
            {
                UI_BagScrollContentItem item=_list[i].GetComponent<UI_BagScrollContentItem>();//拿到格子对象
                //判断格子是否为空，不为空判断物品是否相等
                if ( !item.isNone )
                {
                    //格子里已经有物品了,判断格子是否相等
                    if ( item.good.GoodID==_good.GoodID )
                    {
                        item.UseGood(_count);//使用物品
                        return;//结束方法
                    }
                }
            }
            //要使用的物品不存在
            Debug.Log("您要使用物品不存在!");
        }
        else
        {
               Debug.Log("您要使用的物品是一个空对象!");
        }
        
    }
    #endregion

    #region 左侧面板的方法
    //按钮点击监听方法
    void OnClothBtnClick()
    {
        Debug.Log ( "时装打开了哟." );
    }
    void OnClothTimeBtnClick()
    {
        Debug.Log ( "时装开启中........." );
    }
    void OnGoldAddBtnClick()
    {
        Debug.Log ( "金子++" );
    }
    void OnSilverAddBtnClick()
    {
        Debug.Log("银子++");
    }

    //装备点击

    #endregion

    #region 公用方法
    //显示被鼠标选中框
    void ShowSelectImage(Transform _parent,bool _show)
    {
        //  通过名称查找到parent的子物体SelectImage，设置其激活与否
        GameObject selectImage=_parent.Find("SelectImage").gameObject;
        selectImage.SetActive(_show);
    }
    //设置Scroll显示一个物品被选中
    void ShowSelectImageInScroll(List<GameObject> _list,GameObject _selectGo)
    {
       //安全校验
        if ( _list==null||_list.Count==0||_selectGo==null )
        {
            Debug.Log("您想要显示的SelectImage方法参数有null对象哦。。。。");
            return;
        }

        for ( int i = 0 ; i < _list.Count ; i++ )
        {
            UI_BagScrollContentItem item = _list[ i ].GetComponent<UI_BagScrollContentItem> ( );
            if (_list[i].name==_selectGo.name )
            {
                //显示被鼠标选中了
                item.ShowSelectImage(true);
                //开启自动隐藏SelectImage的协程
                //先关闭其他协程
                StopAllCoroutines();
                StartCoroutine(HideSelect(item.transform));
            }
            else
            {
                //显示没有被选中
                item.ShowSelectImage(false);
            }
        }

    }
    //设置List中显示一个物品被选中
    void ShowSelectImageInList ( List<GameObject> _list , GameObject _selectGo )
    {
        //安全校验
        if ( _list == null || _list.Count == 0 || _selectGo == null )
        {
            Debug.Log ( "您想要显示的SelectImage方法参数有null对象哦。。。。" );
            return;
        }

        for ( int i = 0 ; i < _list.Count ; i++ )
        {
            if ( _list[ i ].name==_selectGo.name )
            {
                ShowSelectImage(_list[i].transform,true);
                //开启自动隐藏SelectImage的协程
                //先关闭其他协程
                StopAllCoroutines ( );
                StartCoroutine ( HideSelect ( _list[ i ].transform.transform ) );
            }
            else
            {
                ShowSelectImage ( _list[ i ].transform , false );
            }
        }
    }
    //隐藏SelectImage的方法
    IEnumerator HideSelect(Transform _parent,float _hideTime=3f)
    {
        yield return new WaitForSeconds(_hideTime);
        ShowSelectImage(_parent,false);
    }
    #endregion

}

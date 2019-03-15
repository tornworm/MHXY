using UnityEngine;

/*物品模型类，封装了物品的通用属性和方法，包含道具和装备两种类型*/
public class Good
{
    //游戏对象的ID
    private int mGoodID;
    public int GoodID
    {
        get
        {
            return mGoodID;
        }
        set
        {
            mGoodID = value;
        }
    }
    //物品的名称
    private string mName;
    public string Name
    {
        get
        {
            return mName;
        }
        set
        {
            mName = value;
        }
    }
    //物品的价格
    private int mPrice;
    public int Price
    {
        get { return mPrice; }
        set { mPrice = value; }
    }

    //物品在背包中显示的图标
    private Sprite mSprite;
    public Sprite SpriteIcon
    {
        get { return mSprite; }
        set { mSprite = value; }
    }

    //物品的使用等级限制
    private int mLimitLevel;
    public int LimitLevel
    {
        get { return mLimitLevel; }
        set { mLimitLevel = value; }
    }

  

    //是否可以使用
    private int mCanUse;
    public int CanUse
    {
        get { return mCanUse; }
        set { mCanUse = value; }
    }

    //是否可以交易
    private int mCanTrade;
    public int CanTrade
    {
        get { return mCanTrade; }
        set { mCanTrade = value; }
    }

    //物品描述信息
    private string mDescription;
    public string Description
    {
        get
        {
            return mDescription;
        }
        set
        {
            mDescription=value;
        }
    }
}

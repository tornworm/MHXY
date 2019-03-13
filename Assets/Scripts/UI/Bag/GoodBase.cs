using UnityEngine;

/*物品模型类，封装了物品的通用属性和方法，包含道具和装备两种类型*/
public class GoodBase : MonoBehaviour
{
    //游戏对象的ID
    private int mID;
    public int ID
    {
        get
        {
            return mID;
        }
        set
        {
            mID = value;
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

    //物品的品质
    private GoodQuality mQuality;
    public GoodQuality Quality
    {
        get { return mQuality; }
        set { mQuality = value; }
    }

    //是否可以使用
    private bool mCanUse;
    public bool CanUse
    {
        get { return mCanUse; }
        set { mCanUse = value; }
    }

    //是否可以交易
    private bool mCanTrade;
    public bool CanTrade
    {
        get { return mCanTrade; }
        set { mCanTrade = value; }
    }

    //物品的类型
    private GoodType mType;
    public GoodType Type
    {
        get { return mType; }
        set { mType = value; }
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

/*事件对象类，封装了一个与事件所有信息都相关的数据结构*/
public class Event
{
    //事件的ID
    int mEventID;
    public int EventID
    {
        get { return mEventID; }
        set { mEventID = value; }
    }

    //事件信息触发的对象
    object mEventObj;
    public object EventObj
    {
        get { return mEventObj; }
        set { mEventObj = value; }
    }

    //事件的参数对象
    object mEventParamObj;
    public object EventParamObj
    {
        get { return mEventParamObj; }
        set { mEventParamObj = value; }
    }
}

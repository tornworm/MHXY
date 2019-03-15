//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//这个类是播放序列帧动画用的
public class UI_BagFrameAnim : MonoBehaviour
 {
    //序列帧动画图片集合
    public Sprite[] winds;
    //序列帧动画协程函数
    IEnumerator coroutine;
    //是否循环播放
    public bool isLoop=true;
    //播放次数
    public int playCount=-1;
    //每帧的间隔时间
   public float waitTime=0.1f;
    //开启序列帧
	void OnEnable () 
    {
       
        //Random.InitState ( 10 );
        //StartCoroutine ( UITools.Singeton.SequenceImage ( winds , GetComponent<Image> ( ) , 0.1f , Random.Range ( 1f , 3f ) ) );

        //赋值序列帧动画线程
        //判断是否需要循环播放
        if ( isLoop )
        {
            coroutine = UITools.Singeton.SequenceImage ( winds , GetComponent<Image> ( ) , waitTime );   
        }
        else
        {
           // coroutine = UITools.Singeton.SequenceImage ( winds , GetComponent<Image> ( ) , waitTime , playCount );   
            coroutine = UITools.Singeton.SequenceImage ( winds , GetComponent<Image> ( ) , waitTime  );   
        }
       
       //开启序列帧动画线程  
       StartCoroutine ( coroutine );
	}
    //关闭序列帧
    void OnDisable()
    {
        //如果已经开启了序列帧动画
        if ( coroutine!=null )
        {
            //关闭它
            StopCoroutine ( coroutine );
        }
       
        //StopAllCoroutines();
    }


}

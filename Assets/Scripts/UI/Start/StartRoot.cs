//this is a C#


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StartRoot : MonoBehaviour {




    private GameObject startPanel;//开始界面
    private GameObject Video;//过场动画物体
    private VideoPlayer videoPlayer;//过场动画物体Video组件
	void Start () {
        startPanel = transform.Find("UI_StartMain").gameObject;
        Video = transform.Find("opening").gameObject;

        videoPlayer= Video.GetComponent<VideoPlayer>();
	}
    private void Update()
    {

        if (Input.anyKeyDown)
        {
            videoPlayer.Stop();
            startPanel.SetActive(true);
            Video.SetActive(false);
        }
    }
   


}

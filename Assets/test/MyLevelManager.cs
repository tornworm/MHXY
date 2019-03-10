/*时间的泪眼撕去我伪装
你可记得我年少的模样*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyLevelManager : MonoBehaviour
{
    public static MyLevelManager _instance;
    private void Awake()
    {
        _instance = this;
    }
    static string nextLevel;
    //跳转的下一场景
    AsyncOperation async;

    public Text text;
    public Slider slider;
    private float tempProgress;
    public int loadingSpeed = 5;

    private void Start()
    {
        tempProgress = 0f;
        if (SceneManager.GetActiveScene().name == "Loading")
        //如果要跳转的场景为Loading
        {
            async = SceneManager.LoadSceneAsync(nextLevel);
            async.allowSceneActivation = false;
        }

    }
    public void LoadLoadingLevel(string nextLeveiName)
    {
        nextLevel = nextLeveiName;
        //要跳转的场景名称为nextLevel
        SceneManager.LoadScene("Loading");
    }
    private void Update()
    {
        //确认text和slider存在
        if (slider&&text)
        {
            tempProgress = Mathf.Lerp(tempProgress, async.progress, Time.deltaTime);
            //进度值（float类型）
            text.text = ((int)(tempProgress / 9 * 10 * 100)).ToString() + "%";
            slider.value = (int)(tempProgress / 9 * 10 * 100) * 0.01f;
            
            if (tempProgress / 9 * 10 > 0.995)
            {
                tempProgress = 9;
                text.text = 100.ToString() + "%";
                slider.value = 1f;

                async.allowSceneActivation = true;
            }
        }
    }
}
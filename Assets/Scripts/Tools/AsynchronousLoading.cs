// 异步加载
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// 挂载到camera上  异步加载
/// </summary>
public class AsynchronousLoading : MonoBehaviour
{
    /// <summary>
    /// 滑动条提交回答
    /// </summary>
    public Slider processBar;
    private AsyncOperation async;
    private int nowProcess;
    //StartCoroutine(loadScene());
    /// <summary>  
    /// 加载完场景后就会跳转  
    /// </summary>  
    /// <returns></returns>  
    private void Start()
    {
        StartCoroutine(loadScene());
    }
    IEnumerator loadScene()
    {
        async = SceneManager.LoadSceneAsync("Main");

        async.allowSceneActivation = false;

        yield return async;
    }
    void Update()
    {
        if (async == null)
        {
            return;
        }
        int toProcess;
        // async.progress 你正在读取的场景的进度值  0---0.9    

        // 如果当前的进度小于0.9，说明它还没有加载完成，就说明进度条还需要移动    

        // 如果，场景的数据加载完毕，async.progress 的值就会等于0.9  
        if (async.progress < 0.9f)
        {
            toProcess = (int)async.progress * 111;

        }
        else
        {
            toProcess = 100;
        }
        // 如果滑动条的当前进度，小于，当前加载场景的方法返回的进度   
        if (nowProcess < toProcess)
        {
            nowProcess++;
        }
        processBar.value = nowProcess / 100f;
        // 设置为true的时候，如果场景数据加载完毕，就可以自动跳转场景   
        if (nowProcess == 100)
        {
            async.allowSceneActivation = true;
        }
    }
    private void OnDestroy()
    {
        StopCoroutine(loadScene());
    }
}
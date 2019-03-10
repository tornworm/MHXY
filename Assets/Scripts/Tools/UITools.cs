
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI的工具类
/// </summary>
public class UITools {


    private static UITools singeton;
    public static UITools Singeton
    {
        get
        {
            if (singeton == null)
            {
                singeton = new UITools();
            }
            return singeton;
        }
    }
    private UITools() { }
    public void OpenWindow(string name)
    {
        //打开UI界面       
        if (GameObject.Find(name) != null)
        {
            
            return;
        }
        GameObject tmp = Object.Instantiate(Resources.Load("Canvas/"+name)) as GameObject;
    }
    public void OpenWindow(string name,bool closeAll)
    {
        //打开UI界面,可关闭其他界面
        if (!closeAll)
            return;

        else{
            foreach (var item in GameObject.FindGameObjectsWithTag("UI"))
            {
                Object.Destroy(item);
            }
        }
        if (GameObject.Find(name) != null)
            return;
        GameObject tmp = Object.Instantiate(Resources.Load("Canvas/"+name)) as GameObject;
    }
    public void CloseWindow(string name)
    {
        //关闭UI界面
        if (GameObject.Find(name+"(Clone)") == null)
            return;
        Object.Destroy(GameObject.Find(name+"(Clone)"));
    }
    public void CloseSelf(string name)
    {
        //关闭UI界面
        if (GameObject.Find(name) == null)
            return;
        Object.Destroy(GameObject.Find(name));
    }
    public void HintWindow(string name)
    {
        
       //隐藏UI界面
        if (GameObject.Find(name + "(Clone)") == null)
            return;
        GameObject.Find(name + "(Clone)").SetActive(false);
    }
    public void ShownWindow(string name)
    {
        //打开隐藏的UI界面
        
        if (GameObject.Find(name + "(Clone)") == null)
            return;
        GameObject.Find(name + "(Clone)").SetActive(true);
    }


    public string SetFont(string text,int Size)
    {
        //改变文字大小
        string newText = "<Size=" + Size + ">" + text + "</Size>";
        
        return newText;

    }
    public string SetFont(string text,string colorCode)
    {
        //改变文字颜色
        string newText = "<color=" + colorCode + ">" + text + "</color>";
        return newText;
    }
    public string SetFont(string text, int Size, string colorCode)
    {
        //改变文字大小和颜色
        string newText = "<color=" + colorCode + ">" + "<Size=" + Size + ">" + text + "</Size>" + "</color>";
       
        return newText;
    }
    public void CreatHintBox(string text)
    {
        //气泡提示弹窗
        if (Resources.Load("Canvas/UI_TextBox") == null)
        {
            Debug.LogError("Resources文件夹下没有UI_TextBox预制体");
            return;
        }
        GameObject tmp = Object.Instantiate(Resources.Load("Canvas/UI_TextBox")) as GameObject;
        tmp.GetComponent<UI_TextBox>().textStr = text;
    }
    public Sprite GetLevelImage(int level)
    {
      //得到品质图片
      return  Resources.Load<Sprite>("Textures/UI/common/item_color_0" + level);
    }

    public IEnumerator SequenceImage(Sprite[] sprites, Image image,float OnceTime)
    {
        //序列帧动画
        for (int i = 0; i < sprites.Length ; i++)
        {
            
         
            image.sprite = sprites[i];
            if (i == sprites.Length-1)
                i = -1;
            yield return OnceTime;
        }
        yield return null;
    

    }




}

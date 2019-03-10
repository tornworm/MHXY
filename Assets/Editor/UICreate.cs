
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 自定义UI组件
/// </summary>

public class UICreate
{

    //自定义Text
    [MenuItem("UI/Text", false, 1)]
    private static void MyCreateText()
    {
        if (GameObject.FindGameObjectWithTag("UI") == null)
        {
            Debug.LogError("没有Tag为UI的Canvas");
            return;
        }
        GameObject UItext = new GameObject("MyText");
        UItext.transform.parent=GameObject.FindGameObjectWithTag("UI").transform;
        UItext.transform.localPosition = Vector3.zero;
        UItext.AddComponent<Text>();
        Text MyText = UItext.GetComponent<Text>();
        MyText.fontSize = 30;
        MyText.text = "Gay里Gay气";
        MyText.raycastTarget = false;
    }
    //自定义Slider
    [MenuItem("UI/Slider", false, 2)]
    private static void MyCreateSlider()
    {
        if (GameObject.FindGameObjectWithTag("UI") == null)
        {
            Debug.LogError("没有Tag为UI的Canvas");
            return;
        }
        GameObject UISlider = new GameObject("MySlider");

        UISlider.transform.parent = GameObject.FindGameObjectWithTag("UI").transform;
        UISlider.transform.localPosition = Vector3.zero;
       
        UISlider.AddComponent<Slider>();
        UISlider.GetComponent<RectTransform>().sizeDelta = new Vector2(500, 50);

        GameObject UISliderBg = new GameObject("Bg");
        UISliderBg.transform.parent = UISlider.transform;
        UISliderBg.transform.localPosition = Vector3.zero;
        UISliderBg.AddComponent<Image>();
        UISliderBg.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0);
        UISliderBg.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0);

        GameObject UISliderFill = new GameObject("Fill");
        UISliderFill.transform.parent = UISliderBg.transform;
        UISliderFill.transform.localPosition = Vector3.zero;
        UISliderFill.AddComponent<Image>();
        UISliderFill.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0);
        UISliderFill.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0);

        Slider MySlider = UISlider.GetComponent<Slider>();
        MySlider.interactable = false;
        MySlider.fillRect = UISliderBg.transform as RectTransform;

        UISliderBg.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
        MySlider.fillRect = UISliderFill.transform as RectTransform;

    }
    //自定义Scroll View
    [MenuItem("UI/Scroll View", false, 3)]
    private static void MyCreateScrollView()
    {
        if (GameObject.FindGameObjectWithTag("UI") == null)
        {
            Debug.LogError("没有Tag为UI的Canvas");
            return;
        }
        //设置物体
        GameObject UIScrollView = new GameObject("MyScrollView");
        UIScrollView.transform.parent = GameObject.FindGameObjectWithTag("UI").transform;
        UIScrollView.transform.localPosition = Vector3.zero;
        UIScrollView.AddComponent<ScrollRect>();
        ScrollRect MyScrollView = UIScrollView.GetComponent<ScrollRect>();
        UIScrollView.GetComponent<RectTransform>().sizeDelta = new Vector2(1200, 800);


        GameObject UIViewPort = new GameObject("View");
        UIViewPort.transform.parent = UIScrollView.transform;
        UIViewPort.transform.localPosition = Vector3.zero;
        UIViewPort.AddComponent<Image>();
        UIViewPort.AddComponent<Mask>();
        UIViewPort.GetComponent<Mask>().showMaskGraphic = false;


        GameObject UIViewContent = new GameObject("Content");
        UIViewContent.transform.parent = UIViewPort.transform;
        UIViewContent.transform.localPosition = Vector3.zero;
        UIViewContent.AddComponent<RectTransform>();

        //设置位置
        MyScrollView.viewport = UIViewPort.transform as RectTransform;
        MyScrollView.content = UIViewContent.transform as RectTransform;
        UIViewPort.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0);
        UIViewPort.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0);
        UIViewPort.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
        UIViewPort.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
        UIViewPort.GetComponent<RectTransform>().pivot = new Vector2(0, 1);
        UIViewContent.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0);
        UIViewContent.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0);
        UIViewContent.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
        UIViewContent.GetComponent<RectTransform>().anchorMin = new Vector2(0, 1);
        UIViewContent.GetComponent<RectTransform>().pivot = new Vector2(0, 1);


        //设置组件
        UIViewContent.AddComponent<GridLayoutGroup>();
        GridLayoutGroup ContentGrid = UIViewContent.GetComponent<GridLayoutGroup>();
        ContentGrid.padding.left = 20;
        ContentGrid.padding.top = 20;
        ContentGrid.cellSize = new Vector2(200, 200);
        ContentGrid.spacing = new Vector2(40, 40);
        UIViewContent.AddComponent<ContentSizeFitter>();
        ContentSizeFitter ContentFitter = UIViewContent.GetComponent<ContentSizeFitter>();
        ContentFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

    }
}

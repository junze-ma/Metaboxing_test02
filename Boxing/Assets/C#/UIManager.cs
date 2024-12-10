using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("UIManager已实例化");
    }

    public List<GameObject> uiObjects = new List<GameObject>();
    public int uiLenth ;    // 存放所有 UI 元素的列表

    // 显示指定 UI
    public void ShowUI(int uiNumber)
    {
        if(uiNumber<=uiLenth)
            uiObjects[uiNumber].SetActive(true);

    }

    // 隐藏指定 UI
    public void HideUI(int uiNumber)
    {
        if (uiNumber <= uiLenth)
            uiObjects[uiNumber].SetActive(false);

    }




}

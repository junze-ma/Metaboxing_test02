using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("UIManager��ʵ����");
    }

    public List<GameObject> uiObjects = new List<GameObject>();
    public int uiLenth ;    // ������� UI Ԫ�ص��б�

    // ��ʾָ�� UI
    public void ShowUI(int uiNumber)
    {
        if(uiNumber<=uiLenth)
            uiObjects[uiNumber].SetActive(true);

    }

    // ����ָ�� UI
    public void HideUI(int uiNumber)
    {
        if (uiNumber <= uiLenth)
            uiObjects[uiNumber].SetActive(false);

    }




}

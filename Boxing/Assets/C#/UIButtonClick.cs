using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonClick : MonoBehaviour
{
    public void HideUINumber(int message)
    {
        UIManager.Instance.HideUI(message);
    }
    public void ShowUINumber(int message)
    {
        UIManager.Instance.ShowUI(message);
    }
}

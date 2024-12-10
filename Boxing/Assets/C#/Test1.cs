using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Test.Instance.GameStart();
        Debug.Log("订阅事件");
        // 订阅事件
        Test.Instance.OnScoreChanged += UpdateScoreDisplay;
    }

    private void OnDisable()
    {
        // 取消订阅事件
        Test.Instance.OnScoreChanged -= UpdateScoreDisplay;
    }

    // 当分数发生变化时，更新显示
    private void UpdateScoreDisplay(int newScore)
    {
        Debug.Log("New Score: " + newScore);
    }
}

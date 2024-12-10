using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test : Singleton<Test>
{
    public int score = 0;
    public event Action<int> OnScoreChanged;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameStart");
    }

    private void OnEnable()
    {
        Debug.Log("����test");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
            TriggerScoreChanged(score); // �����¼��������·���
        }
    }

    public void  GameStart()
        {
        Debug.Log("Im here");
        }

   

    public void TriggerScoreChanged(int score)
    {
        if (OnScoreChanged == null) 
            Debug.LogError("��ǰ�¼�δ����");
        else
            Debug.Log(score);
    }
}

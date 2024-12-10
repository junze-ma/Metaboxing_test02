using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    // ��ȡ����ʵ��
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                // ���ҳ����е�ʵ��
                _instance = FindObjectOfType<T>();

                // ���������û��ʵ�����ʹ���һ���µ�
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(T).Name);
                    _instance = singletonObject.AddComponent<T>();
                    DontDestroyOnLoad(singletonObject); // ���ֵ����ڳ����л�ʱ��������
                }
            }
            return _instance;
        }
    }

    // ���ʵ���Ѵ��ڣ��������ڳ����д������ʵ��
    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject); // ��֤�����ڳ����л�ʱ��������
        }
        else
        {
            Destroy(gameObject); // ����Ѿ���ʵ���������µ�ʵ��
        }
    }
}
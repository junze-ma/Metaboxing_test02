using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    // 获取单例实例
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                // 查找场景中的实例
                _instance = FindObjectOfType<T>();

                // 如果场景中没有实例，就创建一个新的
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(T).Name);
                    _instance = singletonObject.AddComponent<T>();
                    DontDestroyOnLoad(singletonObject); // 保持单例在场景切换时不被销毁
                }
            }
            return _instance;
        }
    }

    // 如果实例已存在，则不允许在场景中创建多个实例
    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject); // 保证对象在场景切换时不被销毁
        }
        else
        {
            Destroy(gameObject); // 如果已经有实例，销毁新的实例
        }
    }
}
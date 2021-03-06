using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestory : MonoBehaviour
{

    [Header("Singleton mode")]
    public static DontDestory instance;//静态变量，单例模式

    //单例模式
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

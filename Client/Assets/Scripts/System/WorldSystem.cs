using System;
using System.Collections;
using System.Collections.Generic;
using cn.bmob.api;
using UnityEngine;

public class WorldSystem : MonoBehaviour
{
    /// <summary>
    /// 世界类单例入口
    /// </summary>
    private static WorldSystem _instance = null;
    public static WorldSystem Instance
    {
        get
        {
            if (null==_instance)
            {
                _instance =new GameObject("WorldSystem").AddComponent<WorldSystem>(); 
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }

    /// <summary>
    /// 消息系统
    /// </summary>
    private PublishSubscribeSystem _publishSubscribeSystem = null;

    public PublishSubscribeSystem PubscribeSystem
    {
        get
        {
            if (null == _publishSubscribeSystem)
            {
               _publishSubscribeSystem= Instance.gameObject.AddComponent<PublishSubscribeSystem>(); 
            }
            return _publishSubscribeSystem;
        }
    }

    /// <summary>
    /// Bmon后端云
    /// </summary>
    private BmobUnity _bmobUnity = null;

    public BmobUnity BmobUnity
    {
        get
        {
            if (null == _bmobUnity)
            {
                _bmobUnity = Instance.gameObject.AddComponent<BmobUnity>();
            }
            return _bmobUnity;
        }
    }
}

using UnityEngine;
using System.Collections;

public class GlobalGenerator : MonoBehaviour 
{


    void Awake()
	{

	}



	void Start()
	{
	    Init();
	}

    void Init()
    {
        WorldSystem.Instance.BmobUnity.initialize("79623dc152c7ab6d20e97fd900fe0eca", "745f2826456fa0e1c9ee1a65ad9e2768");
    }

}


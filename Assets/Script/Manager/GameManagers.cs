using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour {

    public static GameManagers _instance;
    public PoolManager _poolManager;
    public AudioManager _AudioManager;
    private void Start()
    { 
        if (_instance == null)
        {
            _instance = this;
        }
        DontDestroyOnLoad(_instance);
        initManager();
    }

    public void initManager()
    {
        _poolManager = new PoolManager();
        _AudioManager = new AudioManager();
    }
 
}



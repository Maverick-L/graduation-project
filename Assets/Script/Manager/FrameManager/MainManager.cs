using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MainManager : MonoBehaviour {

    public static MainManager _instance;
    public PoolManager _poolManager;
    public AudioManager _audioManager;
    public GUIManager _guiManager;
    public LevelManager _levelManager;
    public GameManagers _gameManager;

  

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
            initManager();
        }
    }



    public void initManager()
    {
       
        _audioManager = new AudioManager();
        _guiManager = new GUIManager();
		_levelManager = new LevelManager();
        _gameManager = new GameManagers();
        _poolManager = new PoolManager(_gameManager.Getenum());
    }


    /// <summary>b
    /// 生成，创建
    /// </summary>
    public GameObject Create(GameObject go,Enum type = null)
    {
        return _poolManager.Create(go,type);
    }

    public void Destroy(GameObject go)
    {
        _poolManager.Destroy(go);
    }

    /// <summary>
    /// 清除对象池中所有数据
    /// </summary>
    public void ResetPool()
    {
        _poolManager.ResetPool();
    }
    /// <summary>
    /// 进入选择关卡
    /// </summary>
    public void CutChooseScene(string name)
    {
        _levelManager.ChooseScene(name);
    }
    /// <summary>
    /// 进入下一关
    /// </summary>
    public void CutNextNomalScene()
    {
        _levelManager.NomalScene();
    }
    /// <summary>
    /// 进入隐藏关卡
    /// </summary>
    public void CutHiddleScene()
    {
        _levelManager.HiddenScene();
    }
    /// <summary>
    /// 返回下一个场景的名称
    /// </summary>
    /// <returns></returns>
    public string  NextSceneName()
    {
        return _levelManager.NextSceneName;
    }
    /// <summary>
    /// 返回切换场景的名称
    /// </summary>
    /// <returns></returns>
    public string CutSceneName()
    {
        return _levelManager.CutSceneName;
    }


}



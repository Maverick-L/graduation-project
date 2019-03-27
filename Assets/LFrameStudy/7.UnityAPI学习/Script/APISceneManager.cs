using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class APISceneManager : MonoBehaviour
{
    private void Start()
    {
        SceneManager.activeSceneChanged += SceneManager_activeSceneChanged;
        SceneManager.sceneLoaded += SceneManager_sceneLoaded;
        SceneManager.sceneUnloaded += SceneManager_sceneUnloaded;
    }
    //01场景销毁前进行调用
    private void SceneManager_sceneUnloaded(Scene arg0)
    {
        print(arg0.name);
    }

    //01场景销毁后，02场景切换前加载
    private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
    {
        print(arg0.name);
        print(arg1.name);
    }

    //01场景销毁后，02场景切换完成之后调用
    private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        print(arg0.name + " "+arg1);
    }
  

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            SceneManager.LoadScene("02-MenuScene");
        }
    }


}

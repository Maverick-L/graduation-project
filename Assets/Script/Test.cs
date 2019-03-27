
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test : MonoBehaviour
{
    public Transform[] t;//存储位置
    private void Awake()
    {
        print(t[0].name);
      //  MainManager._instance._poolManager.Create(go, GameManagers.Type.NPC);
        StartCoroutine(CreatEnemy());

    }


    IEnumerator CreatEnemy()
    {
        foreach (Transform go in t)
        {
            //1.可以使用go.name找到怪物的名字然后把怪物取出来
            GameObject g = Resources.Load(Myconts.RSOURCE_PREFABS_PATH + go.name) as GameObject;
            //2.生成GameObject
            MainManager._instance._poolManager.Create(g, GameManagers.Type.NPC);
        }
        yield return 0;
    }

}

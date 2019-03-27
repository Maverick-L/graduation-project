using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] point;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform ts in point)
        {
           MainManager._instance._gameManager.CreatEnemy(ts,prefab);    
        }
    }

   
}

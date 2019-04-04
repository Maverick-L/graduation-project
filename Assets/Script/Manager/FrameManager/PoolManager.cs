using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PoolManager  {

 
    private bool isInpool;
    private Dictionary<Enum , Queue<GameObject>> pool = new Dictionary<Enum , Queue<GameObject>>();//创建对象池，存放所有对象

    /// <summary>
    /// 初始化PoolManager
    /// </summary>
    public PoolManager()
    {
        pool.Add(null,new Queue<GameObject>());
    }

    public PoolManager(params Enum[] type)
    {
        foreach(Enum e in type)
        {
            pool.Add(e, new Queue<GameObject>());
        }
    }

    /// <summary>
    /// 生成一个物体
    /// </summary>
    public GameObject Create(GameObject targetObject,Enum type)
    {
       
        foreach (GameObject ob in pool[type])
        {
            if (ob.name.Equals(targetObject.name) && ob.activeSelf == false)
            {
                return ob;
            }  
        }
        GameObject go=GameObject.Instantiate(targetObject);
        go.SetActive(false);
        go.name = targetObject.name;
        pool[type].Enqueue(go);
        return go;
    }


    /// <summary>
    /// 销毁一个物体  有错
    /// </summary>
    public void Destroy(GameObject targetObject,Enum type, float time=0)
    {
            foreach (GameObject go in pool[type])
            {
                if (go==targetObject && go.activeSelf == true)
                {
                targetObject.SetActive(false);
                return;
                }
            Debug.Log(go.name);
            }
        pool[type].Enqueue(targetObject);
        targetObject.SetActive(false);
    }
    /// <summary>
    /// 统一清除所有。
    /// </summary>
    public void ResetPool()
    {
     
        pool.Clear();
    }



}

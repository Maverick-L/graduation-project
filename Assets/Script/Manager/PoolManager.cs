using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour {

    public enum Type
    {
        NPC,
        Consumables,
        Arm
    }
    private bool isInpool;
    public NPCPoolManager _NPCinstance;
    public Consumables _Consumablesinstance;
    public Arm _Arminstance;
    private Dictionary<Type, Queue<GameObject>> pool = new Dictionary<Type, Queue<GameObject>>();

    /// <summary>
    /// 初始化PoolManager
    /// </summary>
    public PoolManager()
    {

        pool.Add(Type.NPC,   new Queue<GameObject>());
        pool.Add(Type.Arm, new Queue<GameObject>());
        pool.Add(Type.Consumables, new Queue<GameObject>());
    }

    /// <summary>
    /// 生成一个物体
    /// </summary>
    public GameObject Create(Transform targetTransform, GameObject targetObject, Type type)
    {
      
        foreach (GameObject ob in pool[type])
        {
            if (ob.name.Equals(targetObject.name) && ob.activeSelf == false)
            {
                return ob;
            }  
        }
            GameObject go=GameObject.Instantiate(targetObject);
            go.name = targetObject.name;
            pool[type].Enqueue(go);
          return go;


    }


    /// <summary>
    /// 销毁一个物体
    /// </summary>
    public void Destroy(GameObject targetObject, Type type, float time)
    {
        foreach(GameObject go in pool[type])
        {
            if (go.name .Equals(targetObject.name)&&targetObject.transform==go.transform&&go.activeSelf==true)
            {
                go.SetActive(false);
            }
           
        }
    }

    public void ResetPool()
    {
        foreach( Queue<GameObject> qu in pool.Values)
        {
            foreach(GameObject go in qu)
            {
                Destroy(go);
                
            }
            qu.Clear();
        }
        pool.Clear();
    }



}

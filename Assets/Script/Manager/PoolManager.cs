using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour {

    public enum Type
    {
        NPC,
        GOODS,
        ENEMY
    }
    private bool isInpool;
    public NPCPoolManager _NPCinstance;
    public GOODSPoolManager _GOODSinstance;
    public ENEMYPoolManager _ENEMYinstance;
    private Dictionary<Type, Queue<GameObject>> pool = new Dictionary<Type, Queue<GameObject>>();

    /// <summary>
    /// 初始化PoolManager
    /// </summary>
    public PoolManager()
    {
        //_NPCinstance = new NPCPoolManager(this);
        //_GOODSinstance = new GOODSPoolManager(this);
        //_ENEMYinstance = new ENEMYPoolManager(this);
        pool.Add(Type.NPC,   new Queue<GameObject>());
        pool.Add(Type.GOODS, new Queue<GameObject>());
        pool.Add(Type.ENEMY, new Queue<GameObject>());
    }

    /// <summary>
    /// 生成一个物体
    /// </summary>
    public void Create(Transform targetTransform, GameObject targetObject, Type type)
    {
        isInpool = false;
        foreach (GameObject go in pool[type])
        {
            if (go.name.Equals(targetObject.name) && go.activeSelf == false)
            {
                isInpool = true;
                go.transform.position = targetTransform.position;
                go.transform.rotation = targetTransform.rotation;
                go.SetActive (true);
                break;
            }
            
        }
        if (!isInpool)
        {
            GameObject go=GameObject.Instantiate(targetObject);
            go.transform.position = targetTransform.position;
            go.transform.rotation = targetTransform.rotation;
            go.name = targetObject.name;
            pool[type].Enqueue(go);
        }
       
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
            print(go.transform.position);
        }
    }



}

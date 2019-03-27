using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class APIGameObject : MonoBehaviour
    {
        public GameObject prefab;
        void Start()
        {
            //1.第一种创建方法
            //GameObject go= new GameObject("Cube");
            //2.第二种方法  可以根据Prefab和另一种物体clone
            //GameObject.Instantiate(prefab);
            //3.用CreatPrefrimitive 创建基础物体
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            Debug.Log(go.activeInHierarchy);
            go.SetActive(false);
            Debug.Log(go.activeInHierarchy);
      

        }
        


    }
}

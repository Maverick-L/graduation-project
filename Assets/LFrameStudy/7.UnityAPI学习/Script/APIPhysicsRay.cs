using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIPhysicsRay : MonoBehaviour
{
   
    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = new Ray(transform.position+transform.forward, transform.forward);
        RaycastHit rayhit;

        //碰撞到的所有物体
        Physics.RaycastAll(ray);

        if (Physics.Raycast(ray,out rayhit))
        {
            GameObject go = rayhit.collider.gameObject;
            print(rayhit.collider.name);
            //输出碰撞到的点
            print(rayhit.point);
        }
    }
}

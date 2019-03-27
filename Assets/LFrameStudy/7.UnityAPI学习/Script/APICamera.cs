 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APICamera : MonoBehaviour
{
    private Camera c;
    private void Start()
    {
        c = Camera.main;//通过标签查找MainCamera
    }

    private void Update()
    {
        //一直进行检测，不需要点击
       Ray ray= c.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit;
       if( Physics.Raycast(ray,out hit))
        {
            //hit.collider就是碰到的物体
            print(hit.collider.name);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class APIInputFunction : MonoBehaviour
    {
        void Start()
        {

        }
    
        void Update()
        {
        //非持续检测
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("KeyDown");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("KeyUp");
        }
        //持续检测
        if(Input.GetKey(KeyCode.Space))
        {
            print("Key");
        }
        //GetMouseButton, GetMouseButtonDown,GetMouseButtonUP和GetKey一样。
        //GetButton,GetButtonDown,GetButtonUp用来检测虚拟按键
        
        //拥有加速或者减速的过程
          Debug.Log(Input.GetAxis("Horizontal"));
        //直接到-1或者直接到1
          Debug.Log(Input.GetAxisRaw("Horizontal"));
   

        }

    
    }

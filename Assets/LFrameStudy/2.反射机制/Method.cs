using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class Method : MonoBehaviour
    {
        public static Method instance;
        private void Awake()
        {
            instance = this;
        }
        public void MethodInfoWithNoReturnNoParameter()
        {
            Debug.Log("无参数，无返回值反射测试");
        }

        public void MethodInfoWithNoReturn(int i)
        {
            Debug.Log("无返回值，有参数反射测试" + i);
        }

      public string MethodInfoWithNoParameter()
        {
            return "无参数，有返回值反射测试";
        }

        public string MethodInfo(int i)
        {
            return "有参数，有返回反射测试" + i;
        }

        public string MethodInfo(int i,string d)
        {
            return "有多个参数，有返回值反射测试" + i + d;
        }

        public void MethodInfoWithAsys()
        {
            Debug.Log("开始测试异步反射");
            
            Debug.Log("OK");
        }

    }
}

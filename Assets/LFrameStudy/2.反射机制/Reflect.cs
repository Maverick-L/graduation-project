using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
namespace LFrameStudy
{
    public class Reflect : MonoBehaviour
    {
        void Start()
        {
            /*
             * https://blog.csdn.net/linuxheik/article/details/71732107
             * MethodInfo 默认只能找到public方法，如果想找到private则需要设置BindingFlags
             */
            MethodInfo methodInfo;
            
            object obj;
            methodInfo = Method.instance.GetType().GetMethod("MethodInfoWithNoReturnNoParameter");
            obj = methodInfo.Invoke(Method.instance,null);

            methodInfo = Method.instance.GetType().GetMethod("MethodInfoWithNoReturn",new System.Type[] { typeof(int)}); 
            obj = methodInfo.Invoke(Method.instance,new object[] { 1});

            methodInfo = Method.instance.GetType().GetMethod("MethodInfoWithNoParameter");
            obj = methodInfo.Invoke(Method.instance,null);
            Debug.Log(obj.ToString());

            methodInfo = Method.instance.GetType().GetMethod("MethodInfo", new System.Type[] { typeof(int) });
            obj = methodInfo.Invoke(Method.instance, new object[] { 1 });
            Debug.Log(obj.ToString());

            methodInfo = Method.instance.GetType().GetMethod("MethodInfo", new System.Type[] { typeof(int),typeof(string) });
            obj = methodInfo.Invoke(Method.instance, new object[] { 1 ,"测试"});
            Debug.Log(obj.ToString());

           
        }
       
    }
}

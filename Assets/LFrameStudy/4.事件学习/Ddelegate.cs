using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class Ddelegate : MonoBehaviour
    {
        //创建委托
        public delegate void BossHp(int hp);
        //创建事件
        public event BossHp BossHpEvent;
        //创建一个带返回值的委托
        public delegate string BossHpWithReturn(int hp);
        public event BossHpWithReturn BossHpWithReturnEvent;

        public static Ddelegate instance;
        private void Awake()
        {
            instance = this;
        }
        private void Start()
        {
            //同步调用
            print(BossHpWithReturnEvent.Invoke(50));
            Debug.Log("同步回调成功");
            //异步回调
            BossHpEvent.BeginInvoke(70, AsyncInvoke, "no");
            Debug.Log("异步回调成功");
        }

        private void AsyncInvoke(IAsyncResult ar)
        {
            Debug.Log(ar.AsyncState);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class APITimeFunction : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("Time.deltaTime: " + Time.deltaTime);
            Debug.Log("Time.fixedDeltaTime: " + Time.fixedDeltaTime);
            Debug.Log("Time.fixedTime: " + Time.fixedTime);
            Debug.Log("Time.frameCount: " + Time.frameCount);
            Debug.Log("Time.realtimeSinceStartup: " + Time.realtimeSinceStartup);
            Debug.Log("Time.smoothDeltaTime: " + Time.smoothDeltaTime);
            Debug.Log("Time.time: " + Time.time);
            Debug.Log("Time.timeScale: " + Time.timeScale);
            Debug.Log("Time.timeSinceLevelLoad: " + Time.timeSinceLevelLoad);
            Debug.Log("Time.unscaledTime: " + Time.unscaledTime);
        }

        private void FixedUpdate()
        {
            Debug.Log("Time.fixedDeltaTime: " + Time.fixedDeltaTime);
            Debug.Log("Time.fixedTime: " + Time.fixedTime);
            Debug.Log("Time.time: " + Time.time);
            Debug.Log("Time.deltaTime: " + Time.deltaTime);
        }

        void Update()
        {
            //每一帧运行的秒数
            Debug.Log("Time.deltaTime: " + Time.deltaTime);
            //每一帧固定运行的秒数，可以通过改变此帧数来改变FixUpdate的运行次数
            Debug.Log("Time.fixedDeltaTime: " + Time.fixedDeltaTime);
            //每一帧固定的运行时间,在FixedUpdate中和Time完全相同
            Debug.Log("Time.fixedTime: " + Time.fixedTime);
            //游戏运行的总帧数
            Debug.Log("Time.frameCount: " + Time.frameCount);
            ////游戏开始运行的总时间
            Debug.Log("Time.realtimeSinceStartup: " + Time.realtimeSinceStartup);
            ////平滑达到Time.deltaTime
            Debug.Log("Time.smoothDeltaTime: " + Time.smoothDeltaTime);
            //这一帧开始的时间，受到暂停控制
            Debug.Log("Time.time: " + Time.time);
            // 时间流逝（0，1，2），控制时间的流逝
            Debug.Log("Time.timeScale: " + Time.timeScale);
            //此场景的加载所消耗的时间
            Debug.Log("Time.timeSinceLevelLoad: " + Time.timeSinceLevelLoad);
            //正常TimeScale下的Time
            Debug.Log("Time.unscaledTime: " + Time.unscaledTime);
        }
    }
}

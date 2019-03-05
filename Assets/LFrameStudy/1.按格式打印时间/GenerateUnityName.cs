using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using System;
namespace LFrameStudy
{
    public class GenerateUnityName : MonoBehaviour
    {
       #if UNITY_EDITOR
        [MenuItem("LFarmStudy/1.生成UntiyPackage名字")]
       #endif
        private static void MenuClick()
        {
            Debug.Log("LFarmStudy_" + DateTime.Now.ToString("yyyyMMdd_HH"));
        }


    }
}
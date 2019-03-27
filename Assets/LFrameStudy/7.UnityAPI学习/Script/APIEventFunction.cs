using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class APIEventFunction : MonoBehaviour
    {
        private void Reset()
        {
            Debug.Log("Reset");

        }
        private void Awake()
        {
            Debug.Log("Awake");
        }

        private void OnEnable()
        {
            Debug.Log("OnEnable");

        }
        private void Start()
        {
            Debug.Log("Start");
        }

        private void FixedUpdate()
        {
            Debug.Log("FixedUpdate");

        }

        void Update()
        {
            Debug.Log("Update");

        }

        private void LateUpdate()
        {
            Debug.Log("LateUpdate");

        }

        private void OnApplicationPause(bool pause)
        {
            Debug.Log("OnApplicationPause");

        }

        private void OnDisable()
        {
            Debug.Log("OnDisable");

        }
        private void OnApplicationQuit()
        {
            Debug.Log("OnApplicationQuit");


        }

        private void OnDestroy()
        {
            Debug.Log("OnDestroy");

        }


    }
}

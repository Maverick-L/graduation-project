using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSceneManager : MonoBehaviour
{
    private void Awake()
    {
        print("awake");
    }
    private void OnEnable()
    {
        print("enable");
    }

    private void Start()
    {
        print("start");
    }
}

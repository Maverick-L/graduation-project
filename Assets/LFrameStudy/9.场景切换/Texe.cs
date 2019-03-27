using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texe : MonoBehaviour
{
    public GameObject go;
    public Transform t;
    private void Awake()
    {
        Instantiate(go, t);
    }




  
}

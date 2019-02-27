using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a1233 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TarNpc;
    public Transform TargetNPC;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GameManagers._instance.Text();
        GameManagers._instance._levelManager.Text();
    
    }
}

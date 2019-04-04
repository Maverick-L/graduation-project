
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject nowArm;
    public GameObject text;

 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameManagers._instance.CutArm("Sphere");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GameManagers._instance.CutArm("Cube");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GameManagers._instance.CutArm("Capsule");
        }
        
    }

}

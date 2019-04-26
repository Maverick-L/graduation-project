
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject nowArm;
    public GameObject text;
    public Transform point;
 
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManagers._instance.Award(2, point);
        }
        
    }

}

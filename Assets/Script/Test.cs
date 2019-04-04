
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject nowArm;
    public GameObject text;

    private void Start()
    {
        GameManagers._instance.CutArm(nowArm, "Sphere");
        MainManager._instance._poolManager.Destroy(text, GameManagers.Type.NPC);
    }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DeathEventArgs :EventArgs
{
    public GameObject senderObject;
    public string deathSound;

    public DeathEventArgs(GameObject obj,string sound)
    {
        this.senderObject = obj;
        this.deathSound = sound;
    }
}

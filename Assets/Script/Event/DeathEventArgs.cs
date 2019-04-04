using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DeathEventArgs :EventArgs
{
    public GameObject senderObject;
    public string deathSound;
    public int grade;
}

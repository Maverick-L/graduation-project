using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class LevelAreaBase : MonoBehaviour
{
   public enum Area
    {
        Low=0,
        Middle=4,
        High=8,
        Boss
    }
    public event EventHandler LevelAreaEvent;

    public Area area;
    public static LevelAreaBase _instance;

    LevelAreaBase()
    {
        _instance = this;
    }


    private void OnTriggerEnter(Collider other)
    {
             LevelAreaEvent.Invoke(this,new EventArgs()); 
    }
}

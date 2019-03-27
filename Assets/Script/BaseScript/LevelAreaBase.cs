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
    private void Start()
    {
       print(area);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            
             LevelAreaEvent.Invoke(this,new EventArgs()); 
        }
        //如果进入此范围内的为玩家 则发送消息给UI控件，显示UI
        else if (other.tag == "player")
        {

        }
    
    }
}

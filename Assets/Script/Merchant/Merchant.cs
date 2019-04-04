using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
public class Merchant : NPC
{
    /*
     * 初始化设定此商人的售卖装备是什么，等级什么
     * 售卖的装备等级应该与商人等级划等号
     */
    private void Awake()
    {
        LevelAreaBase._instance.LevelAreaEvent += Initgrade;
        Spherecollider = GetComponent<SphereCollider>();
    }
  

    private void Initgrade(object sender, EventArgs e)
    {
        FieldInfo fieldInfo = sender.GetType().GetField("area");
        this.area = (LevelAreaBase.Area)fieldInfo.GetValue(LevelAreaBase._instance);
        if (area != LevelAreaBase.Area.Boss)
        {
            //随机产生一个等级；
            this.grade = UnityEngine.Random.Range((int)area + 1, (int)area + 4);
        }

    }

    public override void Massager()
    {
       
    }

    public override void Task()
    {
        
    }

    public override void Death(GameObject obj,string sound)
    {
        base.Death(obj,sound);
    }
}

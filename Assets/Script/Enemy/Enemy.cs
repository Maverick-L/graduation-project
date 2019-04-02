using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
public class Enemy : NPC
{
    /*
     * 一类怪物的攻击范围，初始伤害量应该是固定的，根据怪物的等级来逐步的加强怪物的攻击力，血量值
     * 提升数值要确定
     * 在达到什么等级或者初始赋予怪物什么攻击模式
     * 怪物等级的高低和掉落装备的等级画等号
     */

    private float Attackdamage;//伤害量

    Enemy()
    {
        Init();
    }

    private void Awake() 
    {
        LevelAreaBase._instance.LevelAreaEvent += Initgrade;
        Spherecollider = GetComponent<SphereCollider>();

    }
    private void Start()
    {
       
    }
    /// <summary>
    /// 初始化不随等级改变的值
    /// </summary>
    public override void Init()
    {
        base.Init();
        //可以采用在Excel里存储的方式获取
        this.type = NPCType.Enemy;
        this.Attackdamage = 10f;
      //  Spherecollider.radius = Range;
    }
    //监听LevelArea 确定其他的和等级有关系的初始值为多少
    private void Initgrade(object sender,EventArgs e)
    {
      
        FieldInfo fieldInfo = sender.GetType().GetField("area");
        this.area = (LevelAreaBase.Area)fieldInfo.GetValue(LevelAreaBase._instance);
        if (area != LevelAreaBase.Area.Boss)
        {
            //随机产生一个等级；
            this.grade = UnityEngine.Random.Range((int)area + 1, (int)area + 4);
        }
       
    }
    


    /// <summary>
    /// 声效控制方法
    /// </summary>
    public override void Massager()
    {
    //被击打声音
    //击打声音
    //死亡声音
    }
    /// <summary>
    /// 任务类
    /// </summary>
    public override void Task()
    {
        //巡逻

        //追击

        //攻击

        //死亡是否掉落物品

        //增加金钱
    }
    
    public override void Death(GameObject obj,string sound)
    {
        base.Death(obj,sound);      
    }
}

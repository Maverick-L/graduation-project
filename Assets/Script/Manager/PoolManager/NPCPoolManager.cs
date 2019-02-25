﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCPoolManager : MonoBehaviour
{
    protected enum NPCType
    {
        Enemy,
        Player,
        Merchant
    }

    protected string name;
    protected NPCType type;
    protected int grade;
    protected float blood;
    protected bool isDead;
    protected float speed;//运动速度

    public virtual void Init(float attackDamage, float attackRange, int grade, float speed, float blood) { }//初始化类
    abstract public void Task();//任务类 需要重载

    abstract public void Massager();//进入范围内应该播放的语音。

    abstract public void Death();//死亡设定
}
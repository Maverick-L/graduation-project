using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public abstract class NPC :MonoBehaviour
{
    #region enum
    protected enum NPCType
    {
        Enemy,
        Merchant
    }
    #endregion

    #region Event
    public static EventHandler<DeathEventArgs> DeathEvent;
    #endregion

    #region Filed
    protected string Name;
    protected NPCType type;
    protected int grade;//等级
    protected float blood;//血量
    protected bool isDead;//是否死亡
    protected float speed;//运动速度
    protected float Range;//范围
    protected SphereCollider Spherecollider;
    protected LevelAreaBase.Area area;
    #endregion

    public virtual void Init() {
      //  this.Name = this.gameObject.name;
        this.grade = 1;
        this.blood = 100f;
        this.speed = 1f;
        
    }//初始化类
    abstract public void Task();//任务类 需要重载

    abstract public void Massager();//进入范围内应该播放的语音。
    //死亡设定
    public virtual void Death(GameObject obj,string sound) {
        
        //调用音效
        //播放死亡动画
        DeathEvent.Invoke(this,new DeathEventArgs(obj,sound));
    }
}

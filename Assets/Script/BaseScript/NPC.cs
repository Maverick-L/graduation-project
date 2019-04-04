using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public abstract class NPC :MonoBehaviour
{
    #region enum
    public enum NPCType
    {
        Enemy,
        Merchant
    }
    #endregion

    #region Event
    public static EventHandler<DeathEventArgs> DeathEvent;
    #endregion

    #region Filed
    public new string name;
    public NPCType type;
    public int grade=1;//等级
    public float blood=100f;//血量
    public bool isDead;//是否死亡
    public float speed=1f;//运动速度
    public float Range;//范围
    protected SphereCollider Spherecollider;
    protected LevelAreaBase.Area area;
    #endregion
    

    abstract public void Task();//任务类 需要重载

    abstract public void Massager();//进入范围内应该播放的语音。
    //死亡设定
    public virtual void Death(GameObject obj,string sound) {

        //调用音效
        //播放死亡动画
        DeathEventArgs death = new DeathEventArgs();
        death.grade = this.grade;
        death.senderObject = obj;
        death.deathSound = sound;
        DeathEvent.Invoke(this,death);
        
    }
}

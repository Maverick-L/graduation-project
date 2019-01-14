using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : NPCPoolManager
{
    private float Attackrange;//攻击范围
    private float Attackdamage;//伤害量

  public float AttackRange {
        get { return Attackrange; }

    }

  public float AttackDamage
    {
        get { return Attackdamage; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Grade
    {
        get { return grade; }
    }
    public float Blood {
        get { return blood; }
  
    }
    public float Speed {

        get { return speed; }
    }

  
    public override void Init(float attackDamage,float attackRange,int grade,float speed,float blood)
    {
        this.grade = Grade;
        this.Attackdamage = AttackDamage*Grade;
        this.Attackrange = attackRange;
        this.speed = speed;
        this.type = NPCType.Enemy;
        this.blood = blood;
        this.name = this.gameObject.name;
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

    public override void Death()
    {

        //死亡设置
    }
}

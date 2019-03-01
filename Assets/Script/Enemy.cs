using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : NPC
{
    /*
     * 一类怪物的攻击范围，初始伤害量应该是固定的，根据怪物的等级来逐步的加强怪物的攻击力，血量值
     * 提升数值要确定
     * 在达到什么等级或者初始赋予怪物什么攻击模式
     * 怪物等级的高低和掉落装备的等级画等号
     */
    private float Attackrange;//攻击范围
    private float Attackdamage;//伤害量

  
    public override void Init(float attackDamage,float attackRange,int grade,float speed,float blood)
    {
        this.grade = grade;
        this.Attackdamage = attackDamage*grade;
        this.Attackrange = attackRange;
        this.speed = speed;
        this.type = NPCType.Enemy;
        this.blood = blood;
        this.Name = this.gameObject.name;
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

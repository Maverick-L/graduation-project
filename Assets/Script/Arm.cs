using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Arm : MonoBehaviour
{
   protected enum Effect
    {
        Normal,
        Dizziness,//眩晕
        Burn,//灼伤
        Repel,//击退
        Frozen,//冰冻
    }
    protected string name;//武器名字
    protected float  attackSpeed;//武器攻击速度
    protected float attackDamage;//武器伤害
    protected int grade;//武器等级
    protected float durable;//武器耐久
    protected int price;//武器售卖价格
    protected Effect effect;//武器的特殊效果

    public virtual void Init(float attackSpeed,float attackDamage,int grade,float durable,int price) { }
    abstract public void Attack();

    
}

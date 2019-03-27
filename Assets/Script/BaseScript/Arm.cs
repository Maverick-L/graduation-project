using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{

    protected string Name;//武器名字
    protected float attackSpeed;//武器攻击速度
    protected float attackDamage;//武器伤害
    protected int grade;//武器等级
    protected float durable;//武器耐久
    protected int price;//武器售卖价格
    protected Effect.Effects effect;//武器的特殊效果

    public float AttackSpeed { get { return attackSpeed; } }
    public float AttackDamage { get { return attackDamage; } }
    public int Grade { get { return grade; } }
    public float Durable { get { return durable; } }
    public int Price { get { return price; } }
    public Effect.Effects Effect { get { return effect; } }

    public virtual void Init(float attackSpeed,float attackDamage,int grade,float durable,int price) {
        this.attackSpeed = attackSpeed;
        this.attackDamage = attackDamage;
        this.grade = grade;
        this.durable = durable;
        this.price = price;
        Name = this.gameObject.name;

    }

   
    

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : Item
{
    #region Field

    public Effect.Effects effect=Effect.Effects.Nomal;//武器的特殊效果
    public float attackSpeed;
    public float attackDamage;
    #endregion

    public override void Init(ArmMassage items)
    {
        this.id = items.id;
        this.name = items.name;
        this.Intro = items.Intro;
        this.price = items.price;
        this.grade = items.grade;
        this.durable = items.durable;
        this.attackSpeed = items.attackSpeed;
        this.attackDamage = items.attackDamage;


    }



}

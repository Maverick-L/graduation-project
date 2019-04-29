using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct ArmMassage 
{
    public int id;
    public string name;
    public int grade;
    public string Intro;
    public int price;
    public int durable;
    public float attackSpeed;
    public float attackDamage;
    public int GradeUpMoney { get { return grade * 10; } }
    public Effect.Effects effect;
    public Sprite sprite;
}

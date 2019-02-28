using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NPCPoolManager
{
    public string Name
    {
        get { return name; }
    }

    public int Grade
    {
        set { grade = value; }
        get { return grade; }
    }
    public float Blood
    {
        get { return blood; }

    }
    public float Speed
    {
        set { speed = value; }
        get { return speed; }
    }

    public GameObject[] Arms;//人物的武器
    public GameObject[] Goods;//人物的药品

    public  void Init( int Grade, float speed, float blood)
    {
        this.name = this.gameObject.name;
        this.grade = Grade;
        this.blood = blood;
        this.speed = speed;
    }

    public override void Massager()
    {
        throw new System.NotImplementedException();
    }

    public override void Task()
    {
        throw new System.NotImplementedException();
    }
    public override void Death()
    {
        throw new System.NotImplementedException();
    }
}

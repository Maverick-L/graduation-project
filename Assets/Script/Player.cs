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

    public  void Init( int Grade, float speed, float blood)
    {
        this.type = NPCType.Player;
        this.name = this.gameObject.name;
        this.grade = Grade;
        this.blood = blood;
        this.speed = speed;
    }

    public override void Massager()
    {
       
    }

    public override void Task()
    {
       
    }
    public override void Death()
    {

    }

}

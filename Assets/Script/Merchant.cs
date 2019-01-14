using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : NPCPoolManager
{
    public string Name
    {
        get { return name; }
    }

    public int Grade
    {
        get { return grade; }
    }

    public void Init(int grade) {
        this.name = this.gameObject.name;
        this.type = NPCType.Merchant;
        this.grade = grade;

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

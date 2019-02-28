using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : NPCPoolManager
{
    /*
     * 初始化设定此商人的售卖装备是什么，等级什么
     * 售卖的装备等级应该与商人等级划等号
     */
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

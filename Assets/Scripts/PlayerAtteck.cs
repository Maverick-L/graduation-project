using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtteck : MonoBehaviour {

    public Animator ani;
    /// <summary>
    /// 进行攻击
    /// </summary>
    public void Atack()
    {
        //进入战斗模式
        print("v");
        PlayerContral._sigletion.state = PlayerContral.playerState.Attack;
        //攻击
        ani.SetTrigger("attack");
    }


}

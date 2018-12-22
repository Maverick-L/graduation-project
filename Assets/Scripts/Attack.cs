using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    public delegate void AttackName(string name);
    public static AttackName attack;
    private void OnEnable()
    {
        
        attack += Enemy_Left;
        attack += Enemy_Right;
        attack += player_Foot;
        attack += player_Left;
        attack += player_Right;
    }


    void Enemy_Left(string name)
    {
        if (name == "Attack_Left")
        {
            print(name + "攻击了");
        }
    }

    void Enemy_Right(string name)
    {

        if (name == "Attack_Right")
        {
            print(name + "攻击了");
        }
    }

    void player_Left(string name)
    {
        if (name == "Player_Left")
        {
            print(name + "攻击了");
        }
    }

    void player_Right(string name)
    {
        if (name == "Player_Right")
        {
            print(name + "攻击了");
        }
    }
    void player_Foot(string name)
    {
        if (name == "Player_Foot")
        {
            print(name + "攻击了");
        }
    }

}

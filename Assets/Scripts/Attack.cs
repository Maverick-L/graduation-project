using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    public delegate void AttackName(string name,string AttackName);
    public static AttackName attack;
    private void OnEnable()
    {
        
        attack += Enemy_Left;
        //attack += Enemy_Right;
        //attack += player_Foot;
        attack += player_Left;
        //attack += player_Right;
    }


    void Enemy_Left(string name, string AttackName)
    {
        if (name == "Enemy_Left")
        {
            print(name + "攻击了"+AttackName);
        }
    }

    void Enemy_Right(string name, string AttackName)
    {

        if (name == "Enemy_Right")
        {
            print(name + "攻击了" + AttackName);
        }
    }

    void player_Left(string name, string AttackName)
    {
        if (name == "Player_Left")
        {
            print(name + "攻击了" + AttackName);
        }
    }

    void player_Right(string name, string AttackName)
    {
        if (name == "Player_Right")
        {
            print(name + "攻击了" + AttackName);
        }
    }
    void player_Foot(string name, string AttackName)
    {
        if (name == "Player_Foot")
        {
            print(name + "攻击了" + AttackName);
        }
    }

}

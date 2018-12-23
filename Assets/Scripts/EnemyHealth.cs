using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public float blood = 100f;

    public float leftAttack = 20f;
    public float rightAttack = 10f;
    public float footAttack = 30f;

    private void OnEnable()
    {
        //订阅事件
        AnimationEventAttack.attack += new AnimationEventAttack.AttackName(Attack);
    }

    void Attack(string name, string AttackName)
    {
        if(AttackName== "Object001")
        {
            print(name + "攻击了" + AttackName);
        }
    }

}

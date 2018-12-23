using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public float blood = 100f;

    public float leftAttack = 20f;
    public float rightAttack = 10f;

    Animator ani;
    private void Awake()
    {
        ani = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        //订阅事件
        AnimationEventAttack.attack += new AnimationEventAttack.AttackName(Attack);
    }

    void Attack(string name, string AttackName)
    {
        if (AttackName == "char_ethan")
        {
            print(name + "攻击了" + AttackName);
            //进行攻击扣血表示

            if (blood <= 0)
            {
                ani.SetBool("isDie", true);
                //死亡后禁止移动
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;//禁止所有方向上的移动
            }
        }
    }

}

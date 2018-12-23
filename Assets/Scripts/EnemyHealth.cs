using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public float blood = 100f;

    public float leftAttack = 20f;
    public float rightAttack = 10f;
    public float footAttack = 30f;

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
        if(AttackName== "Object001")
        {
            print(name + "攻击了" + AttackName);
            //进行攻击扣血表示

            if (blood <= 0)
            {
                ani.SetBool("isDie", true);
                //死亡之后三秒后消失

                Destroy(this.gameObject, 3f);
                
            }
        }
    }

}

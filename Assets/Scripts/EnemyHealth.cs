using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyHealth : MonoBehaviour {
    public float blood = 100f;

    public float leftAttack = 20f;
    public float rightAttack = 10f;
    public float footAttack = 30f;

    public Transform initPos;
    public GameObject Enemy;
    Animator ani;

	public HUDText text;
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
        
        if(AttackName== "bull_king")
        {
            print(name + "攻击了" + AttackName);
			//进行攻击扣血表示
			switch (name)
            {
                case "Player_Lift": blood -= leftAttack;
                    //与UI交互
                    break;
                case "Player_Right":blood -= rightAttack;
                    break;
                case "Player_Foot":blood -= footAttack;
                    break;
            }

            if (blood <= 0)
            {
                ani.SetTrigger("isDle");
                ani.SetBool("IsAttackLayer", false); 
                GetComponent<NavMeshAgent>().enabled = false;
                GetComponent<EnemyContral>().enabled = false;
            }
        }
    }

    //属性 访问器

    public float Blood
    {
        get { return blood; }
    }

    public void Dle()
    {
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<Rigidbody>().MovePosition(new Vector3(0, -5, 0));
        Instantiate(Enemy, initPos);
         Destroy(this.gameObject, 10f);
    }
}

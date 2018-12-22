using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyContral : MonoBehaviour {

   public  enum Enemystate {
        Portrolint,
        Attack,
        Track //攻击状态
    }
    //public Transform attackinitPos;//攻击距离

    private float  attackDistance=10f;//攻击距离
    public static EnemyContral _instance;//单例
    public Enemystate state;//状态
    private Animator ani;
    public Transform[] waypoint;
    public int index;
    NavMeshAgent nav;
    public float time=0;
    [SerializeField]
    private float speedTime ;
    public Vector3 playerpos=Vector3.zero;
    private void Awake()
    {
        _instance = this;
        ani = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        //attackDistance = Vector3.Distance(transform.position,attackinitPos.position);//攻击距离初始化
        index = 0;
        speedTime = 3f;
        nav.destination = waypoint[index].position;
        state = Enemystate.Portrolint;
    }
    private void Update()
    {
        if (state == Enemystate.Portrolint)
        {
            nav.destination = waypoint[index].position;
            Portrolint();
        }else if (state == Enemystate.Track)
        {
            Track();
        }else if (state == Enemystate.Attack)
        {
            Attack();
        }

    }
    void Portrolint()
    {
        ani.SetBool("IsAttackLayer", false);
        ani.SetBool("isRun", false);
        ani.SetBool("isWalk", true);
        nav.speed = 1f;
        if (nav.remainingDistance < 0.1)
        {

            if (time >= speedTime)
            {
                index += 1;
                index = index % waypoint.Length;
                nav.destination = waypoint[index].position;
                time = 0;
            }
            else
            {
                ani.SetBool("isWalk", false);
                ani.SetBool("isRun", false);
                time += Time.deltaTime;
            }
        }
        else
        {
            ani.SetBool("isWalk", true);
        }
    }
    /// <summary>
    /// 进入视角范围，追踪敌人
    /// </summary>
    void Track()
    {
        ani.SetBool("IsAttackLayer", false);
        ani.SetBool("isRun", true);
        ani.SetBool("isWalk", false);
        nav.destination = playerpos;
        nav.speed = 3.5f;
        if (nav.remainingDistance <= attackDistance)
        {
            
            state = Enemystate.Attack;
           
        }
    }
    /// <summary>
    /// 进行攻击
    /// </summary>
    void Attack()
    {
       // ani.SetBool("IsRun", false);
        ani.SetBool("IsAttackLayer", true);
    }
}

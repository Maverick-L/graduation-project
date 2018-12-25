using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventAttack : MonoBehaviour {

    public Transform EventLiftPos;//武器挥动到的某一帧武器所在的位置
    public Transform EventRightPos;
    private Collider[] attaccollider;

    public Transform playerLiftPos;
    public Transform playerRightPos;
    public Transform playerFootpos;

    public delegate void AttackName(string name, string AttackName);
    public static event AttackName attack;

    /// <summary>
    /// 怪物左手攻击
    /// </summary>
    public void EnemyLift()
    {
        AttackCheck(EventLiftPos.position, true,"Enemy_Lift");
    }
    /// <summary>
    /// 怪物右手攻击
    /// </summary>
    public void EnemyRight()
    {
        AttackCheck(EventRightPos.position, true,"Enemy_Right");
    }
    /// <summary>
    /// 怪物双手攻击
    /// </summary>
    public void EnemyDouble()
    {
        AttackCheck(EventRightPos.position, true, "Enemy_Right");
        AttackCheck(EventLiftPos.position, true,"Enemy_Lift");
    }
    /// <summary>
    /// player左手攻击
    /// </summary>
    public void PlayerLift()
    {
        AttackCheck(playerLiftPos.position, false, "Player_Lift");
    }
    /// <summary>
    /// player右手攻击
    /// </summary>
    public void PlayerRight()
    {
        AttackCheck(playerRightPos.position, false, "Player_Right");
    }
    /// <summary>
    /// player脚攻击、
    /// </summary>
    public void PlayerFoot()
    {
        AttackCheck(playerFootpos.position, false, "Player_Foot");
    }

    /// <summary>
    /// 攻击检测，
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="isEnemy"></param>
    void AttackCheck(Vector3 pos,bool isEnemy,string name)
    {
        //检测发起攻击的对象是player还是enemy
        if (isEnemy)
        {
            attaccollider = Physics.OverlapSphere(pos, 15f, 1 << LayerMask.NameToLayer("Player"));
     
        }
        else
        {
            attaccollider = Physics.OverlapSphere(pos, 0.1f, 1 << LayerMask.NameToLayer("Enemy"));
        }
        if (attaccollider != null)
        {
            foreach (Collider go in attaccollider)
            {
                //调用攻击  collider返回的是被攻击的物体
                 AnimationEventAttack.attack(name, go.gameObject.name);
               // print(name);      
                
            }
        }
    }
}

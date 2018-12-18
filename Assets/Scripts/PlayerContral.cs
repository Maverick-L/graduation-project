using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContral : MonoBehaviour {
    public static PlayerContral _sigletion;

    public enum playerState {
        Normal,
        Attack,
        Fly
    }

    private Animator ani;
   public playerState state;

    private void Awake()
    {
        _sigletion = this;
        ani = GetComponent<Animator>();
    }

    private void Start()
    {
        state = playerState.Normal;

    }
    /// <summary>
    /// 时刻监视当前的状态
    /// </summary>
    private void Update()
    {
        switch (state)
        {
            case playerState.Normal :
                ani.SetBool("isAttackLayer", false);
                break;
            case playerState.Attack:
                ani.SetBool("isAttackLayer", true);
                break;
            case playerState.Fly:
                break;
        }
    }
}

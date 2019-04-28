using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{

    //每一把武器在爆出来之后都应该有一个可检测范围，碰到检测物品栏是否有空，有空捡起，没有空，扔掉
    #region Field

    public Effect.Effects effect=Effect.Effects.Nomal;//武器的特殊效果
    public float attackSpeed;
    public float attackDamage;

    private ArmMassage massage;
    #endregion


    public void Init(ArmMassage items)
    {
        massage = items;
    }



}

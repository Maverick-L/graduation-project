using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
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

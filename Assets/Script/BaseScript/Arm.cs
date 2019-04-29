using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    #region Field
    private ArmMassage massage;
    #endregion


    public void Init(ArmMassage items)
    {
        massage = items;
    }



}

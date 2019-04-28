using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmManager : GameManagers
{
    //1.将所有与武器有关系的方法封装在此类中
    //2.此类只使用于武器掉落，武器购买，武器升级，武器销毁
    //3.以ArmMassage为参数传递，不传递任何GameManager

    private Pooltype poolType=Pooltype.Arm;
    private GameObject Arm = new GameObject("Arm");


    #region Method Public
    /// <summary>
    /// 武器掉落
    /// </summary>
    public void ArmDrop(ArmMassage arm,Transform targetTrans)
    {
        GameObject go = CreateArm(arm.name);
        if (go == null)
        {
            return;
        }
        InitArm(go,arm);
        go.transform.position = targetTrans.position;
        go.transform.rotation = targetTrans.rotation;
    }

    /// <summary>
    /// 武器购买
    /// </summary>
    public void ArmPurchase(ArmMassage arm)
    {
        //1.判断背包
        //2.背包满格，是否替换
        //3.


    }
    
    /// <summary>
    /// 武器升级
    /// </summary>
    public void WeaponUpGrade(ArmMassage arm)
    {

    }

    /// <summary>
    /// 武器销毁
    /// </summary>
    public void WeaponDestory(ArmMassage arm)
    {

    }
    #endregion

    #region Method Private

    private GameObject CreateArm(string name)
    {
       GameObject go= base.CreateArm(name);
        return go;
    }

    private void InitArm(GameObject go,ArmMassage arm)
    {
        Transform t = Arm.transform;
        go.transform.parent = t;
        go.AddComponent<Arm>();
        go.GetComponent<Arm>().Init(arm);
    }
    #endregion 
}

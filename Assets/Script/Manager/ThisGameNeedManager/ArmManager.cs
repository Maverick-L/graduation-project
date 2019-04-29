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
    public void WeaponUpGrade(GameObject arm)
    {
        //1.获取升级所需要的金币数
        //3.查询人物的金币是否足够
        //4.不够不升级
        //5.足够升级，减少金币
        //6.升级之后arm更新

    }

    /// <summary>
    /// 武器销毁
    /// </summary>
    public void WeaponDestory(GameObject arm)
    {
        ArmMassage a = new ArmMassage();
        arm.GetComponent<Arm>().Init(a);
        MainManager._instance._poolManager.Destroy(arm, poolType);

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
        go.GetComponent<Arm>().Init(arm);
    }
    #endregion 
}

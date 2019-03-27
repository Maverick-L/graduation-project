using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManagers
{
    public EffectManager _effectManager;
    public GoldManager _goldManager;
    public TimeManager _timeManager;
    
    enum Type
    {
        NPC,
        Arm
    }

    
   public GameManagers()
    {
        //监听
        NPC.DeathEvent += Death;
    }

    /// <summary>
    /// 初始化PoolManager需要用到的枚举
    /// </summary>
    /// <returns></returns>
    public Enum[] Getenum()
    {
        Enum[] enums=new Enum[] { Type.NPC,Type.Arm };
        return enums;
    }


    /// <summary>
    /// 创建一个怪物
    /// </summary>
    public void CreatEnemy(Transform targetTransform, GameObject targetObject)
    {
       GameObject go= MainManager._instance.Create(targetObject,Type.NPC);
        go.transform.position = targetTransform.position;
        go.transform.rotation = targetTransform.rotation;
        go.transform.parent = targetTransform;
    }

    /// <summary>
    /// 创建商人Merchant
    /// </summary>
    public void CreateMerchant(Transform targetTransform, GameObject targetObject)
    {
        GameObject go = MainManager._instance.Create(targetObject);
    }


    //死亡处理
    public void Death(System.Object sender,DeathEventArgs e )
    {
        MainManager._instance._poolManager.Destroy(e.senderObject);
        switch (sender.GetType().Name)
        {
            case "Enemy":
                //进行奖励调用
                break;
            case "Player":
                //调用死亡之后的UI
                break;
        }
    }

}

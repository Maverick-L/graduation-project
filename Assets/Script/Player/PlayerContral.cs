using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContral : MonoBehaviour
{
    public static PlayerContral _instance;

    public string Name { get; set; }
    public int Grade { get; set; }
    public float Blood { get; set; }
    public float Speed { get; set; }
    public Transform ArmTrans;
    

    public ArmMassage[] Arms=new ArmMassage[3];//被带走的武器
    public GameObject[] Goods;//被带走的药品

    #region Mono Method
    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {

        InitPlayerArms();
        InitGoods();
    }
    #endregion

    #region InitPlayer
    public void InitPlayerMassage(string Name, int Grade, float Speed, float Blood)
    {
        //从Xml数据包中读取
        this.Name = Name;
        this.Grade = Grade;
        this.Speed = Speed;
        this.Blood = Blood;
    }

    public void InitPlayerArms()
    {
        //GameObject中获取
    }

    public void InitGoods()
    {
        //GameObject中获取
    }
    #endregion

    #region Method Arm

    /// <summary>
    /// 切换武器
    /// </summary>
    /// <param name="arm"></param>
    public void CutArm(ArmMassage arm)
    {
        

    }

    /// <summary>
    /// 捡起武器
    /// </summary>
    public void PickArm(GameObject arm)
    {
        //1,调用GameObject中的背包空间检测

    }

    #endregion

    public void Death()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public float Blood { get; set; }
    public float Speed { get; set; }
    

    public GameObject[] Arms;//人物的武器
    public GameObject[] Goods;//人物的药品

    #region InitPlayer
    public void InitPlayerMassage(string Name, int Grade, float Speed, float Blood)
    {
        this.Name = Name;
        this.Grade = Grade;
        this.Speed = Speed;
        this.Blood = Blood;
    }

    public void InitPlayerArms()
    {

    }

    public void InitGoods()
    {

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
    public void PickArm()
    {

    }

    #endregion

    public void Death()
    {
        
    }
}

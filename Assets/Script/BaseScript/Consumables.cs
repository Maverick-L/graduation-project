using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Consumables :MonoBehaviour
{
    protected string Name;//消耗品名字
    protected int price;//消耗品价格

    /// <summary>
    /// 初始化价格
    /// </summary>
    abstract public void  Init(int price);
    /// <summary>
    /// 次消耗品的作用
    /// </summary>
    abstract public void Task();
}

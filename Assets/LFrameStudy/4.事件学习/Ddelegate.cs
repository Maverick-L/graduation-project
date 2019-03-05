using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ddelegate : MonoBehaviour
{
    //创建委托
    public delegate void BossHp(int hp);
    //创建事件
    public event BossHp BossHpEvent;
    //创建一个带返回值的委托
    public delegate string BossHpWithReturn(int hp);

    public event BossHpWithReturn BossHpWithReturnEvent;

    public static Ddelegate instance;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        BossHpEvent.Invoke(50);
       print( BossHpWithReturnEvent.Invoke(50));
    }
}

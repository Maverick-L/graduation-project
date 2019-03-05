using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventText : MonoBehaviour
{

    void Start()
    {
        Ddelegate.instance.BossHpEvent += BossHp;
        Ddelegate.instance.BossHpEvent += privateBossHp;
        Ddelegate.instance.BossHpWithReturnEvent += BossHpWithReturn;
       
    }

    // Update is called once per frame

    public void BossHp(int hp)
    {
        Debug.Log(hp);
    }

    private void privateBossHp(int hp)
    {
        Debug.Log(hp+10);
    }

    private string  BossHpWithReturn(int hp)
    {
        Debug.Log(hp + 20);
        return "yes";
    }
}

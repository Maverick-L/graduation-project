using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{

    private float carnetTime=90;
    private int killEnemy = 10; 
    //通关时间小于多少秒
   public bool Task1(int time)
    {
        if (time < carnetTime)
        {
            return true;
        }
        return false;
    }
    //杀敌数为多少
    public bool Task2(int killenemy)
    {
        if (killenemy > killEnemy)
        {
            return true;
        }
        return false;
    }
}

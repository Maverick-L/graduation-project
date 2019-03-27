using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string Name;
    public int Grade;
    public float Blood;
    public float Speed;
    

    public GameObject[] Arms;//人物的武器
    public GameObject[] Goods;//人物的药品

    public void Init(string Name, int Grade, float Speed, float Blood)
    {
        this.Name = Name;
        this.Grade = Grade;
        this.Speed = Speed;
        this.Blood = Blood;
    }


    public  void Death()
    {
        
    }
}

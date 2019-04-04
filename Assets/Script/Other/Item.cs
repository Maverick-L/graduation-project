using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class   Item:MonoBehaviour
{
    public int id;
    public new string name;
    public int grade =1;
    public string Intro;
    public int price;
    public int durable=100;

    public virtual void Init() { }
}

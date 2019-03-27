using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  interface Task
{
    //任务简介
    string TaskIntro { get; }
    //任务判定
    bool TaskIsOver(System.Object @object);


}

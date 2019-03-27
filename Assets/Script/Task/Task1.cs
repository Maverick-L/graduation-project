using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : Task
{
    private string taskIntro;
    private int KillEnemyCount;

    public Task1()
    {
        Init();
    }
    public void Init()
    {
        taskIntro = "任务介绍";
        KillEnemyCount = 90;
    }
    public string TaskIntro
    {
        get
        {
            return taskIntro;
        }
    }


    /// <summary>
    /// 任务是否完成检测
    /// </summary>
    /// <param name="obj">传入int类型变量</param>
    /// <returns></returns>
    public  bool TaskIsOver(object @object)
    {
        int killEnemyCount = Convert.ToInt32(@object);
        if (killEnemyCount >= KillEnemyCount)
        {
            return true;
        }
        return false;
    }


}

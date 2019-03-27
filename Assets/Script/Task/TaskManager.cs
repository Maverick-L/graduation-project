using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class TaskManager : MonoBehaviour
{
    /*1.创建Task类数组，用来存储所有继承与Task类的任务
     * 2.通过InitTaskList()初始化所有的任务，存入数组中
     * 3.初始化信息
     * 4.发布任务到监听的类中去
     */

    private Task[] task;
    private int taskCount;
    public static TaskManager instance;
    public delegate void TaskDelegate(Task task);
    public event TaskDelegate TaskEvent;

    private TaskManager()
    {
        instance = this;
        InitTaskList();
        Init();
    }

    private void InitTaskList()
    {
        task=new Task[] { new Task1()};
    }
    private void Init()
    {
        taskCount =task.Length;
    }


    /// <summary>
    /// 随机选择任务,发布
    /// </summary>
    public void ChooseTask()
    {
        int index = UnityEngine.Random.Range(0, taskCount);
        TaskEvent.Invoke(task[index]);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class TaskManager : MonoBehaviour
{
    /*1.任务的书面介绍，此任务为什么类型
     * 2.传入进行解析，此任务的需要完成点为什么
     * 3.关卡通关成功后，判定是否完成任务
     * 4.通过反射可以执行Task内部的代码段
     * 5.通过事件和回调可以设置任务发布，任务是否完成
     */

    private Task[] task;
    private int taskCount;
    public static TaskManager instance;
    public delegate bool TaskDelegate(Task task);
    public event TaskDelegate TaskEvent;

    private TaskManager()
    {
        instance = this;
        InitTaskList();
        Init();
    }

    private void InitTaskList()
    {
        task[1] = new Task1();
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

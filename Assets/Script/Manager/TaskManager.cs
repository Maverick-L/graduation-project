using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
public class TaskManager : MonoBehaviour
{
    /*1.任务的书面介绍，此任务为什么类型
     * 2.传入进行解析，此任务的需要完成点为什么
     * 3.关卡通关成功后，判定是否完成任务
     * 4.通过反射可以执行Task内部的代码段
     * 5.通过事件和回调可以设置任务发布，任务是否完成
     */

    private MethodInfo[] methodInfo;
    private Task task;
    private int taskCount;

    public delegate bool TaskDelegate(MethodInfo methodInfo);
    public event TaskDelegate TaskEvent;
    public void Init()
    {
        methodInfo = task.GetType().GetMethods();
        taskCount = methodInfo.Length;
    }
/// <summary>
/// 随机选择任务
/// </summary>
    public void ChooseTask()
    {
        int index = Random.Range(0, taskCount);
        TaskIsOver( TaskEvent.Invoke(methodInfo[index]));
    }

    /// <summary>
    /// 任务是否完成判断
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public void TaskIsOver(bool isover)
    {
        if (isover == true)
        {

        }
        else
        {

        }
    }
}

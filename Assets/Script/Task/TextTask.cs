using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
public class TextTask : MonoBehaviour
{
    private Task task;
    void Start()
    {
        TaskManager.instance.TaskEvent += Task;

        TaskManager.instance.ChooseTask();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Task(Task task)
    {
        this.task = task;
        print(task.TaskIntro);
        task.TaskIsOver(50);
    }
}

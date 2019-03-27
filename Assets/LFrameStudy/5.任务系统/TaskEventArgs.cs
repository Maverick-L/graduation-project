using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class TaskEventArgs : MonoBehaviour
    {
        public string TaskId;//任务ID
        public int Amount;//任务数量
        public bool isFinish;//任务是否完成

        public TaskEventArgs(string TaskId,int amount)
        {
            this.TaskId = TaskId;
            this.Amount = amount;
        }

    }
}

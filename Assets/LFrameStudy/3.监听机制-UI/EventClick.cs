using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
namespace LFrameStudy
{
    public class EventClick : MonoBehaviour
    {
        public Button button1;
        // public Button button2;
        public static EventClick instence;
        private void Awake()
        {
            instence = this;
        }
        void Start()
        {

            AddTriggerListen(button1.gameObject, EventTriggerType.PointerClick, Click1);
            //    AddTriggerListen(button2.gameObject, EventTriggerType.PointerClick, Click2);

        }
        /// <summary>
        /// 注册事件，添加监听
        /// </summary>
        /// <param name="obj">加入监听的物体</param>
        /// <param name="eventId">监听的类型</param>
        /// <param name="action"></param>
        public void AddTriggerListen(GameObject obj, EventTriggerType eventId, UnityAction<BaseEventData> action)
        {
            EventTrigger trigger = obj.GetComponent<EventTrigger>();
            if (trigger == null)
            {
                trigger = obj.AddComponent<EventTrigger>();
            }
            if (trigger.triggers.Count == 0)
            {
                trigger.triggers = new List<EventTrigger.Entry>();
            }
            //设置回调函数
            UnityAction<BaseEventData> callback = new UnityAction<BaseEventData>(action);
            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = eventId;
            entry.callback.AddListener(callback);
            trigger.triggers.Add(entry);
        }

        void Click1(BaseEventData date)
        {

            Debug.Log("Click1" + date.selectedObject.name);
        }

        void Click2(BaseEventData date)
        {
            Debug.Log("Click2");
        }
    }
}

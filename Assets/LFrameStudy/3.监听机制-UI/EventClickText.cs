using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace LFrameStudy
{
    public class EventClickText : MonoBehaviour
    {
        public Button button1;
        private void Start()
        {
            EventClick.instence.AddTriggerListen(button1.gameObject, EventTriggerType.PointerClick, Click);
        }

        void Click(BaseEventData date)
        {
            Debug.Log("click2" + date.selectedObject.name);
        }
    }
}

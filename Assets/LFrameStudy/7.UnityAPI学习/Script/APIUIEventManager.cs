using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class APIUIEventManager : MonoBehaviour, IPointerDownHandler
{
    //接口方式只能监听到这个脚本所在的物体身上
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}

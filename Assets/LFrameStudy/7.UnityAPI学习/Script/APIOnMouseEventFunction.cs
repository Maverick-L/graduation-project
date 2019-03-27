using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIOnMouseEventFunction : MonoBehaviour
{
    //在collider上面点击的时候触发
  private void OnMouseDown()
    {
        Debug.Log("Down");   
    }
    //在Collider上面点击并且拖拽时候触发
    private void OnMouseDrag()
    {
        Debug.Log("Drag");   
        
    }
    //移入Collider后触发一次
    private void OnMouseEnter()
    {
        Debug.Log("Enter");

    }
    //移出Collider后触发，无论点击或者未点击
    private void OnMouseExit()
    {
        Debug.Log("Exit");

    }
    //在Collider上面放置一直触发
    private void OnMouseOver()
    {
        Debug.Log("Over");

    }
    //在Collider上面点击抬起后触发
    private void OnMouseUp()
    {
        Debug.Log("Up");

    }
    //在Collider上面点击并且松手触发
    private void OnMouseUpAsButton()
    {
        Debug.Log("UpAsButton");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
    public GameObject sliderblock;
    private float r;
    private bool inpress;
    private int touchID;
    private Vector2 clickPos;
    public Camera uicamera;
    private Vector2 movePos;
    private void Awake()
    {
        
        r = this.GetComponent<UISprite>().width / 2;
    }


    void OnPress(bool pressed)
    {
        inpress = pressed;
        touchID = UICamera.currentTouchID;
        print(touchID);
    }

    private void Update()
    {
        
        if (inpress)
        {
            //触碰的点的位置
            clickPos = UICamera.GetTouch(touchID,false).pos;
            //虚拟按键的点的屏幕坐标
            Vector2 JoyStick = new Vector2(uicamera.WorldToScreenPoint(this.transform.position).x, uicamera.WorldToScreenPoint(this.transform.position).y);
            if (Vector3.Distance(JoyStick,clickPos) <= r)
            {
                sliderblock.transform.position = UICamera.currentCamera.ScreenToWorldPoint(clickPos);
            }
            else
            {
                sliderblock.transform.localPosition = (clickPos-JoyStick).normalized * r;
            }
            
        }
        else
        {
            sliderblock.transform.localPosition = Vector3.zero;
        }
    }


}

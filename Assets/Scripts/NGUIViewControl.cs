using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGUIViewControl : MonoBehaviour {

    public Transform targetCamera;
    private int touchId;
    private bool ispress;
    public Transform player;
    public float speed = 6f;
    private Vector3 offsetPos;
    private void Start()
    {
        offsetPos = targetCamera.position - player.position;
    }
    private void Update()
    {
        if (ispress)
        {
          
            if (Input.touches[touchId].phase == TouchPhase.Moved)
            {
                Vector3 targetPos = Input.touches[touchId].deltaPosition;
                     
             //使用角度控制旋转  
             //未设置最大y转的角度
                if ((Vector3.Angle(targetPos, Vector3.up) < 105 && Vector3.Angle(targetPos, Vector3.up) > 85)|| (Vector3.Angle(targetPos, Vector3.down) < 105 && Vector3.Angle(targetPos, Vector3.down) > 85))
                {
                    targetCamera.RotateAround(player.position, Vector3.up, targetPos.normalized.x * speed);
                }
                //if ((Vector3.Angle(targetPos, Vector3.right) < 105 && Vector3.Angle(targetPos, Vector3.right) > 85)|| (Vector3.Angle(targetPos, Vector3.left) < 105 && Vector3.Angle(targetPos, Vector3.left                             ) > 85))
                //{
                //    targetCamera.RotateAround(player.position, targetCamera.right, targetPos.normalized.y * -speed);
                //}

            }
        }
    }
    void OnPress(bool pressed)
    {
        ispress = pressed;
        touchId = UICamera.currentTouchID;
    }

}

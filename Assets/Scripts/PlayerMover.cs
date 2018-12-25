using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public GameObject sliderblock;
    public Transform initPos;
    private float r;
    private bool inpress;
    private int touchID;
    private Vector2 clickPos;
    public Camera uicamera;
    private Vector2 movePos;

    public Transform player;
    private Quaternion initRot;
    public Animator ani;
    private void Awake()
    {


        r = this.GetComponent<UISprite>().width / 2;

        initRot = player.rotation;
    }


    void OnPress(bool pressed)
    {
        inpress = pressed;
        touchID = UICamera.currentTouchID;

    }

    private void Update()
    {

        if (inpress)
        {

          // GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().constraints=~RigidbodyConstraints.FreezePosition;

            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().constraints=~RigidbodyConstraints.FreezePosition;
            //触碰的点的位置
            clickPos = UICamera.GetTouch(touchID, false).pos;
            //虚拟按键的点的屏幕坐标
            Vector2 JoyStick = new Vector2(uicamera.WorldToScreenPoint(this.transform.position).x, uicamera.WorldToScreenPoint(this.transform.position).y);
            if (Vector3.Distance(JoyStick, clickPos) <= r)
            {
                sliderblock.transform.position = UICamera.currentCamera.ScreenToWorldPoint(clickPos);
            }
            else
            {
                sliderblock.transform.localPosition = (clickPos - JoyStick).normalized * r;
            }
           
            Vector3 angle = new Vector3(sliderblock.transform.localPosition.x, 0, sliderblock.transform.localPosition.y);
            Quaternion targetAngle = Quaternion.LookRotation(angle.normalized);
            player.rotation = Quaternion.Lerp(player.rotation, targetAngle, Time.deltaTime*2f);
            ani.SetFloat("Blend", 5.6f, 1f, Time.deltaTime);
         
        }
        else
        {
            sliderblock.transform.localPosition = Vector3.zero;
            //控制站住 不移动
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            ani.SetFloat("Blend", 0, 0.5f, Time.deltaTime);
        }
    }


}
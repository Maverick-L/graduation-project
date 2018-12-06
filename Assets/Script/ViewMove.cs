using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMove : MonoBehaviour {
    public Transform player;
    bool isRound;
    private Vector3 offsetPostion;//标识玩家到相机的距离
    public float speed=2f;
    private void Start()
    {
        offsetPostion = transform.position - player.position;
    }

    private void Update()
    {
        RoundView();
    }
   /// <summary>
    /// 旋转视角
    /// </summary>
    void RoundView()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isRound = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            isRound = false;
        }

        if (isRound)
        {
            transform.RotateAround(player.position, Vector3.up, Input.GetAxis("Mouse X") * speed);
            transform.RotateAround(player.position, transform.right, Input.GetAxis("Mouse Y") * -speed);

        }
        
    }
    

}

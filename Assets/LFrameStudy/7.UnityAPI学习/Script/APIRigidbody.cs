using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIRigidbody : MonoBehaviour
{
    public Rigidbody player;
    public Transform Enemy;
    public int force=1;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //使用Rigidbody来改变位置的效率要高于Transform
            player.MovePosition(player.transform.position + Vector3.forward * Time.deltaTime);
            Vector3 dir = Enemy.position - player.transform.position;
            dir.y = 0;
            player.MoveRotation(Quaternion.Slerp(player.transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime));
        }
        //使用力控制物体运动
        player.AddForce(Vector3.forward * force);
    }
}

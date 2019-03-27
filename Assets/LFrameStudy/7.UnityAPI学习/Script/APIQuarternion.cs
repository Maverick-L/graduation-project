using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIQuarternion : MonoBehaviour
{
    public Transform cube;

    public Transform player;
    public Transform Enemy;

    private void Start()
    {
        //    print(cube.eulerAngles);
        //    print(cube.rotation);
        //欧拉角转换为四元数
        cube.rotation = Quaternion.Euler(new Vector3(45, 45, 45));


    }
    private void Update()
    {

        Vector3 dir = Enemy.position - player.position;
        dir.y = 0;
        player.rotation = Quaternion.Slerp(player.rotation, Quaternion.LookRotation(dir), Time.deltaTime * 2);
    }

}

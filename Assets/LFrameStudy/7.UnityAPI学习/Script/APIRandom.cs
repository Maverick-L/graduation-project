using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIRandom : MonoBehaviour
{

    private void Start()
    {
        //设置随机数种子，生成同样的随机数序列
      //  Random.InitState(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print(Random.Range(0, 1000));
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //随机生成一个0-1之间的随机数，主要用于随机产生颜色
            print(Random.value);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            //随机生成一个四元数
            print(Random.rotation);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //在半径为1的圆内随机生成一个二维向量
            //可以用*控制这个圆的大小
            print(Random.insideUnitCircle*5);
            //在半径为1的球内随机生成一个三位向量
            print(Random.insideUnitSphere);
        }
        
    }
}

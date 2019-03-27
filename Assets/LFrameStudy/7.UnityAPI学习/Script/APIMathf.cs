using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIMathf : MonoBehaviour
{
    public GameObject prefab;
    public int a = 8;
    public int b = 20;
    public float t = 0;
    public float speed=0;
    void Start()
    {
        //弧度转角度
        Debug.Log(Mathf.Rad2Deg);
        //角度转弧度
        Debug.Log(Mathf.Deg2Rad);
        Debug.Log(Mathf.PI);
        //最大的数
        Debug.Log(Mathf.Infinity);
        //最小的数
        Debug.Log(Mathf.NegativeInfinity);
        //在0/1之间最小的数
        Debug.Log(Mathf.Epsilon);

        //取value离的最近的2的次方数
        Debug.Log(Mathf.ClosestPowerOfTwo(2));
        Debug.Log(Mathf.ClosestPowerOfTwo(3));
        //取数字中最大的数
        Debug.Log(Mathf.Max(1,2));
        Debug.Log(Mathf.Max(1,3,10));
        //取数字中最小的数
        Debug.Log(Mathf.Min(1,2));
        //取f的p次方
        Debug.Log(Mathf.Pow(4,3));
        //开根号
        Debug.Log(Mathf.Sqrt(4));
    }

    private void Update()
    {
        // Debug.Log(Mathf.Lerp(a, b, t));

        //current+MaxDelta 但是要小于target;
        //float newX = Mathf.MoveTowards(prefab.transform.position.x, 10, Time.deltaTime*speed);
        //prefab.transform.position = new Vector3(newX, prefab.transform.position.y, prefab.transform.position.z);


        //Mathf.pingpang: 在0-length之间运行，用t控制当前所在位置。
        prefab.transform.position = new Vector3(Mathf.PingPong(Time.time, 10), transform.position.y, prefab.transform.position.z);
    }
}

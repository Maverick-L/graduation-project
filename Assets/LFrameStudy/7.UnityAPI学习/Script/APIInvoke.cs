using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIInvoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Invoke("Attack", 5f);
        InvokeRepeating("Attack", 4f, 2f);
        //取消所有Invoke
        CancelInvoke();
        CancelInvoke("Attack");
    }

    private void Update()
    {
        bool res = IsInvoking("Attack");
        Debug.Log(res);
    }

    void Attack()
    {
        Debug.Log("攻击");
    }
}

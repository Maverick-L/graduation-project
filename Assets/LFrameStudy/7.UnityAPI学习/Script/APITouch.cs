using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APITouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.touches.Length);   
        if (Input.touches.Length > 0)
        {
            Touch touch1 = Input.touches[0];
            Vector2 v2=touch1.position;
            TouchPhase phase = touch1.phase;
            
        }
    }
}

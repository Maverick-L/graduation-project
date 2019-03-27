using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APICharacterContral : MonoBehaviour
{
    private CharacterController cc;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //有重力影响
        //cc.SimpleMove(new Vector3(h, 0, v) * speed);
        //无重力影响
        cc.Move(new Vector3(h, 0, v) * speed*Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log(hit.collider);
    }
}

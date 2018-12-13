using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public Transform player;
    private Vector3 targetPos;
    private Vector3 initpos;
	void Start () {
        targetPos = this.transform.position - player.position;
        initpos = player.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (initpos != player.position)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, targetPos + player.position, 2f);
            initpos = player.position;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APICoroutine : MonoBehaviour
{
    public GameObject cube;

    private void Start()
    {
       // print("a");
       //StartCoroutine( changeColor());
       // print("b");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        for(float i = 0; i <= 1; i += 0.1f)
        {
            
            cube.GetComponent<MeshRenderer>().material.color = new Color(i,i,i);
            yield return new WaitForSeconds(1f);
        }
        yield return null;
    }

    IEnumerator  changeColor()
    {
        yield return new WaitForSeconds(5f);
        print("c");
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        print("d");
    }
}

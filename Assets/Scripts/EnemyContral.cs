using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyContral : MonoBehaviour {

    public Transform[] waypoint;
    public int index;
    NavMeshAgent nav;
    public float time=0;
    [SerializeField]
    private float speedTime ;
    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        index = 0;
        speedTime = 3f;
        nav.destination = waypoint[index].position;
    }
    private void Update()
    {
        Portrolint();

    }
    void Portrolint()
    {
       
        if (nav.remainingDistance < 0.1)
            {
          
              if (time >= speedTime)
              {
                index += 1;
                index = index % waypoint.Length;
                nav.destination = waypoint[index].position;
                time = 0;
              }
              else
              {
                time += Time.deltaTime;
              }
            }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtteck : MonoBehaviour {
 
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")
        {
            EnemyContral._instance.state = EnemyContral.Enemystate.Track;
            EnemyContral._instance.playerpos = other.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            EnemyContral._instance.state = EnemyContral.Enemystate.Portrolint;
            EnemyContral._instance.playerpos = Vector3.zero;

        }
    }

}

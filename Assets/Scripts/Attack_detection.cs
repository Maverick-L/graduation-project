using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_detection: MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            print("aa");
          //  Attack.attack(this.gameObject.name);
        }
    }
}

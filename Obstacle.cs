using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    PLAYERMOVE pLAYERMOVE;
    void Start()
    {
        pLAYERMOVE = GameObject.FindObjectOfType<PLAYERMOVE>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            //Kill the player
            pLAYERMOVE.Die();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

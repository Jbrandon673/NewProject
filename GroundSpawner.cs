using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour {

    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    void spawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    internal void SpawnTile()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {   for (int i = 0; i < 15; i++)
        {
            spawnTile();
        }
        
        
    }
}

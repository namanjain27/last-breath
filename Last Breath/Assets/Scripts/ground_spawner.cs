using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_spawner : MonoBehaviour
{
    public GameObject ground_tile;
    Vector3 nextSpawnPoint;

    public void spawn_next()
    {
        GameObject recent = Instantiate(ground_tile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = recent.transform.GetChild(1).transform.position;
    }

    private void Start()
    {
        for(int i=0; i<9; i++)
        {
            spawn_next();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_tile : MonoBehaviour
{
    ground_spawner ground_spawner;

    private void Start()
    {
        ground_spawner = GameObject.FindObjectOfType<ground_spawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        ground_spawner.spawn_next();
        Destroy(gameObject, 1f);
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        
        GameObject current_obstacle = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        current_obstacle.transform.Rotate(new Vector3(0, 180, 0));
    }
}

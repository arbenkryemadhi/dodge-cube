using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnPoints;

    float timeBetweenWaves = 1f;
    float timeToSpawn = 0f;
    


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnObstacles();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnObstacles()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(spawnPoints[randomIndex], transform.position, Quaternion.identity);
    }
}

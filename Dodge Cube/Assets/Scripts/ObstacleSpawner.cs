using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject[] spawnPatterns;

    float timeBetweenWaves = 1f;
    float timeToSpawn = 1f;
    int randomIndex;
   
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnObstacles();
            timeToSpawn += timeBetweenWaves;
        }

        
    }

    void SpawnObstacles()
    {
        randomIndex = Random.Range(0, spawnPatterns.Length);
        Instantiate(spawnPatterns[randomIndex], transform.position, Quaternion.identity);
    }
}

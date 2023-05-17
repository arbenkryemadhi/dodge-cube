using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnPoints;

    float timeBetweenWaves = 1f;
    float lowestTimeBetweenWaves = 0.7f;
    float deltaTimeBetweenWaves = 0.01f;
    float timeToSpawn = 0f;




    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= timeToSpawn)
        {
            SpawnObstacles();
            timeToSpawn = Time.timeSinceLevelLoad + timeBetweenWaves;

            if (timeBetweenWaves > lowestTimeBetweenWaves)
            {
                timeBetweenWaves -= deltaTimeBetweenWaves;
                Debug.Log(timeBetweenWaves);
            }
        }
    }

    void SpawnObstacles()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(spawnPoints[randomIndex], transform.position, Quaternion.identity);
    }
}

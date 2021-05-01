using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SutureSpawn : MonoBehaviour
{
    public GameObject enemyprefab;

    //Store all the spawnpoint in an array
    public Transform[] spawnPoints;

    public float spawnDelay = .3f;
    float nextTimeToSpawn = 0f;

    void Update(){
        if (nextTimeToSpawn <= Time.time){
            SpawnEnemy();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }
    void SpawnEnemy(){
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        Instantiate(enemyprefab, spawnPoint.position, spawnPoint.rotation);
    }
}
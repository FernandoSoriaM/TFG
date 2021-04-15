using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformCount;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++){
            spawnPosition.x += Random.Range(.5f, 5f);
            spawnPosition.y = Random.Range(-5f, 1f);
            spawnPosition.z = 9;
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        
    }
}
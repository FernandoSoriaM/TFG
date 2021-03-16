using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    //Time they take to spawn
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    void Update(){
        if(Time.time > nextSpawn){
            nextSpawn = Time.time +spawnRate;
            randX = Random.Range (-8.4f, 8.4f);
            randY = Random.Range (-3f, 3f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
    /*
    public Transform[] spawnPoints;
	public GameObject[] monsters;
	int randomSpawnPoint, randomMonster;
	public static bool spawnAllowed;

	// Use this for initialization
	void Start () {
		spawnAllowed = true;
		InvokeRepeating ("SpawnAMonster", 0f, 1f);
	}

	void SpawnAMonster()
	{
		if (spawnAllowed) {
			randomSpawnPoint = Random.Range (0, spawnPoints.Length);
			randomMonster = Random.Range (0, monsters.Length);
			Instantiate (monsters [randomMonster], spawnPoints [randomSpawnPoint].position,
				Quaternion.identity);
		}
	}
    */
}

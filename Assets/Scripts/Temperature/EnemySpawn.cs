using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//GameHandler
public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 20;
    private float time = 1.5f;

    public GameObject[] enemies;

    public float progress = 0;
    public float topProgress;

    public GameObject winMenu;

    public CameraShakeAnimation cameraShake;

    public bool isStopped;

    public ProgressBar progressBar;

    public GameObject explosionParticle;

    void Start(){
        winMenu.SetActive(false);
        explosionParticle.SetActive(false); 

        StartCoroutine(SpawnAnEnemy());

        progressBar.SetProgress(progress);
    }

    void Update(){
        progressBar.SetProgress(progress += Time.deltaTime);
        if(progress >= topProgress){
            WinGame();
        }
    }

    IEnumerator SpawnAnEnemy(){
        Vector2 spawnPos = GameObject.FindGameObjectWithTag("Objective").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnAnEnemy());
    }
    void OnTriggerEnter2D(Collider2D col) {
        switch (col.gameObject.tag){      
            case "Enemy":
                explosionParticle.SetActive(true);
                StartCoroutine(cameraShake.Shake(.15f, .4f));
                if(progress > 5){
                    progressBar.SetProgress(progress -= 5);
                }
                Invoke("Esperar", 1);
                break;
        }
    }
    public void Esperar(){
        explosionParticle.SetActive(false);
    }

    public void WinGame(){
        winMenu.SetActive(true);
        Time.timeScale = 0f;
        isStopped = true;
    }
    public void GoToMainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
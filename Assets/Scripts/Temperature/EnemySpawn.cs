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

    //Canvas
    public GameObject winMenu;
    
    public bool isStopped;

    public GameObject winSound;
    public GameObject hurtSound;

    //Animation
    public CameraShakeAnimation cameraShake;

    public ProgressBar progressBar;

    public GameObject explosionParticle;

    void Start(){
        //Canvas and animation
        winMenu.SetActive(false);
        explosionParticle.SetActive(false); 

        //Spawn
        StartCoroutine(SpawnAnEnemy());

        progressBar.SetProgress(progress);
    }
    //Keeps advancing the progress bar
    void Update(){
        progressBar.SetProgress(progress += Time.deltaTime);
        if(progress >= topProgress){
            winSound.SetActive(true);
            WinGame();
        }
    }
    //Enemy Spawner around the object
    IEnumerator SpawnAnEnemy(){
        Vector2 spawnPos = GameObject.FindGameObjectWithTag("Objective").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnAnEnemy());
    }
    //Colliders and events on collision
    void OnTriggerEnter2D(Collider2D col) {
        switch (col.gameObject.tag){      
            case "Enemy":
                hurtSound.SetActive(true);
                explosionParticle.SetActive(true);
                StartCoroutine(cameraShake.Shake(.15f, .4f));
                if(progress > 5){
                    progressBar.SetProgress(progress -= 5);
                }
                Invoke("Esperar", 1);
                break;
        }
    }
    //Particle activator
    public void Esperar(){
        explosionParticle.SetActive(false);
        hurtSound.SetActive(false);
    }
    //WinCanvas
    public void WinGame(){
        winMenu.SetActive(true);
        Time.timeScale = 0f;
        isStopped = true;
    }
    //MainMenuBtn
    public void GoToMainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
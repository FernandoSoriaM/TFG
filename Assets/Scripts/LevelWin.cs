using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelWin : MonoBehaviour
{
    public GameObject winMenu;

    public bool isStopped;

    // Start is called before the first frame update
    void Start()
    {
        winMenu.SetActive(false);   
    }

    // Update is called once per frame
    /*void Update()
    {
        if(progress < topProgress){
            WinGame();
        }
    }*/

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

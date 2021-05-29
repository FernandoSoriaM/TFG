using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject winMenu;
    public bool isStopped;

    public GameObject winSound;
    
    void OnTriggerEnter2D(){
        winSound.SetActive(true);
        WinGame();
    }

    public void WinGame(){
        winMenu.SetActive(true);
        Time.timeScale = 0f;
        isStopped = true;
    }
}

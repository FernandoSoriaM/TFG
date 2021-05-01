using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject winMenu;
    public bool isStopped;
    
    void OnTriggerEnter2D(){
        WinGame();
    }

    public void WinGame(){
        winMenu.SetActive(true);
        Time.timeScale = 0f;
        isStopped = true;
    }
}

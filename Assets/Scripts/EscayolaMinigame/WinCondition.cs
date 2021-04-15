using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject winMenu;
    public bool isStopped;

    void OnTriggerEnter2D(Collider2D col) {
        switch (col.gameObject.tag){
            case "Player":
                WinGame();
                break;
        }
    }

    public void WinGame(){
        winMenu.SetActive(true);
        Time.timeScale = 0f;
        isStopped = true;
    }
}
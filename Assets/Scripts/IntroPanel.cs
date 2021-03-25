using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPanel : MonoBehaviour
{
    public GameObject startMenu;

    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);   
        Time.timeScale = 0f;
    }

    public void StartGame(){
        startMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
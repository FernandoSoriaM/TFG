﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHandler : MonoBehaviour
{
    public GameObject winSound;

    public LevelWin winMenu;

    public bool isStopped;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 15){
            winMenu.WinGame();
            winSound.SetActive(true);
        }
    }

    public void LessEnemy(){
        count += 1;
    }
}
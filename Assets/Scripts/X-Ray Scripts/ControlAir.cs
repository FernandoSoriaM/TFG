using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAir : MonoBehaviour
{
    public GameObject explosionSound;
    
    void OnCollisionEnter2D(Collision2D col) {
                switch (col.gameObject.tag){      
            case "Player":
                explosionSound.SetActive(true);
                Destroy(gameObject);
                break;
        }
    }
}
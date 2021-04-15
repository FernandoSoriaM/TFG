using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBehaviour : MonoBehaviour
{
    public CameraShakeAnimation cameraShake;
    
    public GameObject hitParticle;
    // Start is called before the first frame update
    void Start()
    {
        hitParticle.SetActive(false); 
        
    }
    //Colliders and events on collision
    void OnTriggerEnter2D(Collider2D col) {
        switch (col.gameObject.tag){      
            case "Player":
                hitParticle.SetActive(true);
                StartCoroutine(cameraShake.Shake(.1f, .3f));
                Invoke("Esperar", 0.5f);
                break;
        }
    }
    //Particle activator
    public void Esperar(){
        hitParticle.SetActive(false);
    }
}

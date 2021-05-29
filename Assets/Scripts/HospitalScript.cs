using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HospitalScript : MonoBehaviour
{
    public float timeTarget = 4f;

    public GameObject bocadillo;

    public GameObject hospitalSound;

    void Update(){
        timeTarget -= Time.deltaTime;

        if (timeTarget <=0.0f){
          Talking();  
        }
    }

    void Talking(){
        bocadillo.SetActive(true);
        hospitalSound.SetActive(true);
    }
}
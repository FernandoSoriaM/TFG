using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTemp : MonoBehaviour
{
    public GameObject target;
    private Vector3 moveDirection;
    public float moveSpeed;
    
    public GameObject explosionParticle;

    void Start(){
        explosionParticle.SetActive(false); 
    }

    void Update(){
        ProcessInputs();
    }

    private void FixedUpdate() {
        Move();        
    }

    void ProcessInputs(){
        float moveX = Input.GetAxisRaw("Horizontal");
        moveDirection = new Vector3(0f, 0f, moveX).normalized;
    }

    void Move(){
        transform.RotateAround(target.transform.position, moveDirection, moveSpeed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col) {
        switch (col.gameObject.tag){
            case "Enemy":
                explosionParticle.SetActive(true);
                Invoke("Esperar", 1);
                break;
        }
    }

    public void Esperar(){
        explosionParticle.SetActive(false);
    }
}
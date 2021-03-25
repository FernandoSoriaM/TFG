using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementTemp : MonoBehaviour
{
    public float speed;
    public float destroyingDistance;
    private Transform target;

    void Start(){ 
        target = GameObject.FindGameObjectWithTag("Objective").GetComponent<Transform>();
    }

    void Update(){
        if(Vector2.Distance(transform.position, target.position) > destroyingDistance){
            Vector3 difference = target.position - transform.position;
            difference.Normalize();
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        switch (col.gameObject.tag){
            case "Player":
                Destroy (gameObject);
                break;
            
            case "Objective":
                Destroy (gameObject);
                break;
        }
    }
}
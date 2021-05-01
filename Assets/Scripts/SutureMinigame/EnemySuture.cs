using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySuture : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minSpeed;
    public float maxSpeed;
    float speed;

    void Start(){
        speed = Random.Range(minSpeed, maxSpeed);
        StartCoroutine(SelfDestruct());
    }

    void FixedUpdate(){
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }

    IEnumerator SelfDestruct(){
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}

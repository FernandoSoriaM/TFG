using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTemp : MonoBehaviour
{
    public GameObject target;
    private Vector3 moveDirection;
    public float moveSpeed;

    void Update(){
        ProcessInputs();
    }

    private void FixedUpdate() {
        Move();        
    }

    void ProcessInputs(){
        float moveX = Input.GetAxisRaw("Horizontal");
        //float moveY = Input.GetAxisRaw("Vertical");
        //moveDirection = new Vector3(0f, 0f, moveX + moveY).normalized;
        moveDirection = new Vector3(0f, 0f, moveX).normalized;
    }

    void Move(){
        transform.RotateAround(target.transform.position, moveDirection, moveSpeed * Time.deltaTime);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    private void LateUpdate() {
        if (target.position.x > transform.position.x){
            Vector3 newPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
            transform.position = newPosition;
        }        
    }
}
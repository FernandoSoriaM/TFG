using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    private bool isDrag;

    public void OnMouseDown() {
        isDrag = true;        
    }
    public void OnMouseUp() {
        isDrag = false;          
    }
    void Update(){
        if (isDrag){
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
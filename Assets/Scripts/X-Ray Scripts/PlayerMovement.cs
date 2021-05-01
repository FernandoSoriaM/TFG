using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isDrag = false;

    void Update(){
        if(isDrag){
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);
        }
    }

    private void OnMouseDown() {
        if(Input.GetMouseButtonDown(0)){ //(0 Lo limita al click izquierdo únicamente)
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isDrag = true;
        }        
    }

    private void OnMouseUp() {
        isDrag = false;
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovementAuscultation : MonoBehaviour {

	public float speed;

	public Rigidbody2D rb;

	private float movement = 0f;

	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * speed;
        //movement = Input.GetAxisRaw("Horizontal") * speed;
	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
	}

	/*void OnCollisionEnter2D (Collision2D col)
	{
		if (col.collider.tag == "Ball")
		{

		}
	}*/

}
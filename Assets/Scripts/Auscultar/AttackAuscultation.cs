using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAuscultation : MonoBehaviour {

	public Transform player;

	public float speed = 2f;

    public GameObject bullet;

	public static bool IsFired;

	// Use this for initialization
	void Start () {
		IsFired = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space"))
		{
			IsFired = true;
		}
		
		if (IsFired)
		{
            //GameObject phonobullet = Instantiate(bullet, rb.position + Vector2.up * Time.deltaTime * speed / 4f, Quaternion.identity);
		//	transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
		} else
		{
            transform.position = player.position;
		    transform.localScale = new Vector3(1f, 0f, 1f);
		}

	}
}
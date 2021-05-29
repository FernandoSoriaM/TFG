using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAuscultation : MonoBehaviour {

	public float speed = 2f;

	public static bool IsFired;

	public Transform player;

	public SpriteRenderer bullet;

	public WinHandler winHandler;

	public GameObject splitSound;
	public GameObject shootSound;

	// Use this for initialization
	void Start () {
		IsFired = false;
		SpriteRenderer bullet = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space"))
		{
			shootSound.SetActive(true);
			IsFired = true;
			Invoke("WaitForShoot", 0.5f);
		}
		
		if (IsFired)
		{
 			bullet.enabled = true;
			transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
		} 
		else
		{
			bullet.enabled = false;
            transform.position = player.position;
		}

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		IsFired = false;

		if (col.tag == "Enemy")
		{	
			splitSound.SetActive(true);
			col.GetComponent<EnemyMovementAuscultation>().Split();
			winHandler.LessEnemy();
			Invoke("Esperar", 1);
		}
	}
	void Esperar(){
		splitSound.SetActive(false);
	}
	void WaitForShoot(){
		shootSound.SetActive(false);
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackColAuscultation : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col)
	{
		AttackAuscultation.IsFired = false;

		if (col.tag == "Enemy")
		{
			col.GetComponent<EnemyMovementAuscultation>().Split();
		}
	}
}
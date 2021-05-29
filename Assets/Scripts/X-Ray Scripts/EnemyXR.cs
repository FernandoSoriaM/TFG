using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyXR : MonoBehaviour
{
    public GameObject explosionParticle;

	public GameObject winSound;
	public GameObject hurtSound;

    public LevelWin winMenu;

	public float health = 3f;

	public static int EnemiesAlive = 0;

	void Start(){
		EnemiesAlive++;
	}

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		if (colInfo.relativeVelocity.magnitude > health)
		{
			Die();
		}
	}

	void Die ()
	{
		hurtSound.SetActive(true);
        explosionParticle.SetActive(true);
		EnemiesAlive--;
        Invoke("Wait", 1);
		if (EnemiesAlive <= 0){
			winSound.SetActive(true);
            winMenu.WinGame();
		}
		Destroy(gameObject);
	}
    void Wait(){
		hurtSound.SetActive(false);
        explosionParticle.SetActive(false);
    }
}
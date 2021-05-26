using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyXR : MonoBehaviour
{

    public CameraShakeAnimation cameraShake;
    public GameObject explosionParticle;

    public LevelWin winMenu;

    public bool isStopped;

	public float health = 4f;

	public static int EnemiesAlive = 3;

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		if (colInfo.relativeVelocity.magnitude > health)
		{
			Die();
		}
	}

	void Die ()
	{
        explosionParticle.SetActive(true);
		EnemiesAlive--;
        StartCoroutine(cameraShake.Shake(.15f, .4f));
        Invoke("Wait", 1);
		if (EnemiesAlive <= 0)
            winMenu.WinGame();
		Destroy(gameObject);
	}
    void Wait(){
        explosionParticle.SetActive(false);
    }
}
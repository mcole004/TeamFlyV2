using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
	public float timeBetweenAttacks = 0.5f;     
	public int attackDamage = 10;              
	public bool stunned;

	GameObject player;                          
	PlayerHealth playerHealth;                  
	bool playerInRange;                         
	float timer;                                
	
	
	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
	}
	
	
	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == player)
		{
			playerInRange = true;
		}
	}
	
	
	void OnTriggerExit (Collider other)
	{
		if(other.gameObject == player)
		{
			playerInRange = false;
		}
	}
	
	
	void Update ()
	{
		if (!stunned) {
						timer += Time.deltaTime;
						if (timer >= timeBetweenAttacks && playerInRange) {
								Attack ();
						}
				} else {
			StartCoroutine(wait_stunned());
				}
	}
	
	
	void Attack ()
	{
		timer = 0f;
		if(playerHealth.currentHealth > 0)
		{
			playerHealth.TakeDamage (attackDamage);
		}
	}

	IEnumerator wait_stunned()
	{
		yield return new WaitForSeconds (3);
		stunned = false;
	}
}
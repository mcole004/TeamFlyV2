using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public int startingHealth = 100;                            
	public int currentHealth;                                   
	//public Slider healthSlider;   
	public Image healthBar;
	public Image damageImage;                                   
	public float flashSpeed = 5f;                              
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     
	                                             				                     
	PlayerController playerController;    

	bool isDead;                                             
	bool damaged;                                              
	
	
	void Awake ()
	{
		playerController = GetComponent <PlayerController> ();
		currentHealth = startingHealth;
		//healthSlider.maxValue = startingHealth;
		healthBar.fillAmount = 1.0f;
	}
	
	
	void Update ()
	{
		if(damaged)
		{
			damageImage.color = flashColour;
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	}
	
	
	public void TakeDamage (int amount)
	{
		damaged = true;
		currentHealth -= amount;
		healthBar.fillAmount = (float)(currentHealth / 100.0f);
		//healthSlider.value = currentHealth;
		if(currentHealth <= 0 && !isDead)
		{
			Death ();
		}
	}
	
	
	void Death ()
	{
		// Set the death flag so this function won't be called again.
		isDead = true;
		playerController.enabled = false;
	}       
}
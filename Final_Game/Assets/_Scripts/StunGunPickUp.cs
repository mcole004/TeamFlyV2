using UnityEngine;
using System.Collections;
//created by Frank Lyons
public class StunGunPickUp : MonoBehaviour {


	//public GameObject player;
	public PlayerController item;
	public lightController lightsource;

	void Start()
	{
		GameObject gun = GameObject.FindGameObjectWithTag ("Player");
		item = gun.GetComponent<PlayerController>();

		GameObject pointLight = GameObject.FindGameObjectWithTag ("PulseLight");
		lightsource =  pointLight.GetComponent<lightController>();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			 
			Destroy(gameObject);
			lightsource.lightswitch = false;

			item.stungun = true;
		}
	}
}

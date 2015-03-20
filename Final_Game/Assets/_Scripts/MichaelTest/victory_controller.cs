using UnityEngine;
using System.Collections;

public class victory_controller : MonoBehaviour {
	
	public GameObject victory_screen;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			victory_screen.SetActive(true);
			Time.timeScale = 0.0f;
		}
	}
	
}

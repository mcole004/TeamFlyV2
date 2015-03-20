using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player_UI : MonoBehaviour {
	
	public GameObject interact;
	
	// Use this for initialization
	void Start () {
		interact.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter( Collider other)
	{
		if(other.tag == "Puzzle" || other.tag == "Door")
		{
			interact.SetActive(true);
		}
		if (other.tag == "StunGun") 
		{

			//other.gameObject.SetActive(false);
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Puzzle" || other.tag == "Door")
		{
			interact.SetActive(false);
		}
	}
}

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
		if(other.tag == "Puzzle")
		{
			interact.SetActive(true);
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Puzzle")
		{
			interact.SetActive(false);
		}
	}
}

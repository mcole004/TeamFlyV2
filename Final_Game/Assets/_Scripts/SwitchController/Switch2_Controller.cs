using UnityEngine;
using System.Collections;

public class Switch2_Controller : MonoBehaviour {

	public bool On;
	public int value;
	
	// Use this for initialization
	void Start () {
		On = false;
		gameObject.renderer.material.color = Color.red;
		value = 0;
	}
	
	void OnTriggerStay(Collider other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				ChangeColor();
			}
		}
	}
	
	
	
	public void ChangeColor()
	{
		if(gameObject.renderer.material.color == Color.green)
		{
			gameObject.renderer.material.color = Color.red;
			On = false;
			value = 0;
		}
		else
		{
			gameObject.renderer.material.color = Color.green;
			On = true;
			value = 2;
		}
	}
}

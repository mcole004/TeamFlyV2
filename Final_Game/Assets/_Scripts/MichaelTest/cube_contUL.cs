using UnityEngine;
using System.Collections;

public class cube_contUL : MonoBehaviour {

	public GameObject UM;
	public GameObject ML;
	public bool isGreen = false;
	
	cube_contUM UMcont; 
	cube_contML MLcont;
	
	// Use this for initialization
	void Start () {
		UMcont = UM.GetComponent<cube_contUM>();
		MLcont = ML.GetComponent<cube_contML>();
		gameObject.renderer.material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerStay(Collider other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			if(Input.GetKeyDown(KeyCode.F))
			{
				ChangeColor();
				UMcont.ChangeColor();
				MLcont.ChangeColor();
			}
			
			
		}
	}
	
	public void ChangeColor()
	{
		if(gameObject.renderer.material.color == Color.green)
		{
			gameObject.renderer.material.color = Color.red;
			isGreen = false;
		}
		else
		{
			gameObject.renderer.material.color = Color.green;
			isGreen = true;
		}
	}
}

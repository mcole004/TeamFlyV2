using UnityEngine;
using System.Collections;

public class cube_contUR : MonoBehaviour {

	public GameObject UM;
	public GameObject MR;
	public bool isGreen = false;
	
	cube_contUM UMcont; 
	cube_contMR MRcont;
	
	// Use this for initialization
	void Start () {
		UMcont = UM.GetComponent<cube_contUM>();
		MRcont = MR.GetComponent<cube_contMR>();
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
				MRcont.ChangeColor();
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

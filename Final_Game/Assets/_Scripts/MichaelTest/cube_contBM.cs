using UnityEngine;
using System.Collections;

public class cube_contBM : MonoBehaviour {
	
	//public variables
	public GameObject MM;
	public GameObject BL;
	public GameObject BR;
	public bool isGreen = false;
	
	//variables for the controllers of other cubes
	cube_contMM MMcont; 
	cube_contBL BLcont;
	cube_contBR BRcont;
	
	// get all the scripts from the adjacent cubes
	//set start color
	void Start () {
		MMcont = MM.GetComponent<cube_contMM>();
		BLcont = BL.GetComponent<cube_contBL>();
		BRcont = BR.GetComponent<cube_contBR>();
		gameObject.renderer.material.color = Color.red;
	}
	
	void OnTriggerStay(Collider other) 
	{
		
		if (other.gameObject.tag == "Player") 
		{
			if(Input.GetKeyDown(KeyCode.F))
			{
				ChangeColor();
				MMcont.ChangeColor();
				BLcont.ChangeColor();
				BRcont.ChangeColor();
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

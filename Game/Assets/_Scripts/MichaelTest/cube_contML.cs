using UnityEngine;
using System.Collections;

public class cube_contML : MonoBehaviour {

	public GameObject MM;
	public GameObject UL;
	public GameObject BL;
	public bool isGreen = false;
	
	cube_contMM MMcont;
	cube_contUL ULcont;
	cube_contBL BLcont;
	
	// Use this for initialization
	void Start () {
		MMcont = MM.GetComponent<cube_contMM>();
		ULcont = UL.GetComponent<cube_contUL>();
		BLcont = BL.GetComponent<cube_contBL>();
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
				MMcont.ChangeColor();
				ULcont.ChangeColor();
				BLcont.ChangeColor();
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

using UnityEngine;
using System.Collections;

public class cube_contUM : MonoBehaviour {

	public GameObject MM;
	public GameObject UL;
	public GameObject UR;
	public bool isGreen = true;
	
	cube_contMM MMcont; 
	cube_contUL ULcont;
	cube_contUR URcont;
	
	// Use this for initialization
	void Start () {
		MMcont = MM.GetComponent<cube_contMM>();
		ULcont = UL.GetComponent<cube_contUL>();
		URcont = UR.GetComponent<cube_contUR>();
		gameObject.renderer.material.color = Color.green;
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
				URcont.ChangeColor();
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

using UnityEngine;
using System.Collections;

public class cube_contMR : MonoBehaviour {

	public GameObject MM;
	public GameObject UR;
	public GameObject BR;
	public bool isGreen = false;
	
	cube_contMM MMcont; 
	cube_contUR URcont;
	cube_contBR BRcont;
	
	// Use this for initialization
	void Start () {
		MMcont = MM.GetComponent<cube_contMM>();
		URcont = UR.GetComponent<cube_contUR>();
		BRcont = BR.GetComponent<cube_contBR>();
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
				URcont.ChangeColor();
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

using UnityEngine;
using System.Collections;

public class cube_contBL : MonoBehaviour {

	public GameObject BM;
	public GameObject ML;
	public bool isGreen = true;
	
	cube_contBM BMcont; 
	cube_contML MLcont;
	
	// Use this for initialization
	void Start () {
		BMcont = BM.GetComponent<cube_contBM>();
		MLcont = ML.GetComponent<cube_contML>();
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
				BMcont.ChangeColor();
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

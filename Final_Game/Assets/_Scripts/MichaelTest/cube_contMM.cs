using UnityEngine;
using System.Collections;

public class cube_contMM : MonoBehaviour {
	
	public GameObject ML;
	public GameObject MR;
	public GameObject UM;
	public GameObject BM;
	public bool isGreen = true;
	
	cube_contML MLcont; 
	cube_contMR MRcont;
	cube_contUM UMcont;
	cube_contBM BMcont;
	
	// Use this for initialization
	void Start () {
		MLcont = ML.GetComponent<cube_contML>();
		MRcont = MR.GetComponent<cube_contMR>();
		UMcont = UM.GetComponent<cube_contUM>();
		BMcont = BM.GetComponent<cube_contBM>();
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
				MLcont.ChangeColor();
				MRcont.ChangeColor();
				UMcont.ChangeColor();
				BMcont.ChangeColor();
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

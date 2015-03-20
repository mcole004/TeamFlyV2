using UnityEngine;
using System.Collections;

public class colorchange : MonoBehaviour {

	MeshRenderer cube_shader;
	
	// Use this for initialization
	void Start () 
	{
		cube_shader = GetComponent <MeshRenderer> ();
		cube_shader.renderer.material.color = Color.gray;
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown(KeyCode.Q))
		{
			cube_shader.material.color = Color.green;
		}
		else if(Input.GetKeyDown(KeyCode.E))
		{
			cube_shader.material.color = Color.red;
		}*/
	}
	
	void OnTriggerStay(Collider other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			if(Input.GetKeyDown(KeyCode.F))
			{
				if(gameObject.renderer.material.color == Color.green)
				{
					gameObject.renderer.material.color = Color.red;
				}
				else
				{
					gameObject.renderer.material.color = Color.green;
				}
			}
			
			
		}
	}
}

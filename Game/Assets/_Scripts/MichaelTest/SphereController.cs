using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {
	
	public float speed = 500;
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		
		rigidbody.AddForce(movement * speed * Time.deltaTime);
		
	}

	/*void OnTriggerStay(Collider other) 
	{
		if (other.gameObject.tag == "Puzzle") 
		{
			if(Input.GetKeyDown(KeyCode.F))
			{
				if(other.gameObject.renderer.material.color == Color.green)
				{
					other.gameObject.renderer.material.color = Color.red;
				}
				else
				{
					other.gameObject.renderer.material.color = Color.green;
				}
			}
			
			
		}
		
	}*/
	

}

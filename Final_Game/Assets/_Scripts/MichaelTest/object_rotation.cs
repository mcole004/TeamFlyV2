using UnityEngine;
using System.Collections;

public class object_rotation : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
		gameObject.renderer.material.color = Color.yellow;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			Pause_controller.map2_obtained = true;
			Destroy(gameObject);
		}
	}
}

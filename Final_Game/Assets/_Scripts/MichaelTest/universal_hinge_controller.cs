using UnityEngine;
using System.Collections;

public class universal_hinge_controller : MonoBehaviour {
	
	public Transform initial;
	public Transform open;
	
	
	// Use this for initialization
	void Start () {
		initial = this.transform;
		open = this.transform;
		//open.rotation = initial.rotation - Vector3(0,90,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerStay(Collider other)
	{
		if(other.tag == "Player")
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				//this.transform = open;
			}
		}
		
	}
}

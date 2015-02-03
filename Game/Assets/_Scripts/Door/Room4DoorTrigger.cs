using UnityEngine;
using System.Collections;

public class Room4DoorTrigger : MonoBehaviour {
	
	private Transform hinge;
	public float doorSpeed = 5f;
	
	public Quaternion open = Quaternion.identity;
	
	
	
	void Awake()
	{
		hinge = GameObject.Find ("Hinge4").transform;
		open.eulerAngles = new Vector3 (0,-180,0);
		
	}
	
	void Update () 
	{
		hinge.rotation = Quaternion.Lerp(hinge.rotation,open,Time.deltaTime * doorSpeed);
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player") 
		{
			open.eulerAngles= new Vector3(0,-90,0);
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			open.eulerAngles = new Vector3(0,-180,0);
		}
		
		
	}
}


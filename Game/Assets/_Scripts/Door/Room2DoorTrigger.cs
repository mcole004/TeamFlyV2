using UnityEngine;
using System.Collections;

public class Room2DoorTrigger : MonoBehaviour {
	
	private Transform doorHingeRoom2;
	public float doorSpeed = 5f;
	
	public Quaternion open = Quaternion.identity;
	
	
	
	void Awake()
	{
		doorHingeRoom2 = GameObject.Find ("Hinge2").transform;
		open.eulerAngles = new Vector3 (0,0,0);
		
	}
	
	void Update () 
	{
		doorHingeRoom2.rotation = Quaternion.Lerp(doorHingeRoom2.rotation,open,Time.deltaTime * doorSpeed);
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player") 
		{
			open.eulerAngles= new Vector3(0,90,0);
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			open.eulerAngles = new Vector3(0,0,0);
		}
		
		
	}
}


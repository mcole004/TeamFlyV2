using UnityEngine;
using System.Collections;

public class door3 : MonoBehaviour {

	private Transform doorHingeRoom1;
	
	public float doorSpeed = 5f;
	
	public Quaternion open = Quaternion.identity;
	
	
	void Awake()
	{
		//doorHingeRoom1 = GameObject.Find ("Hinge0").transform;
		doorHingeRoom1 = GameObject.FindGameObjectWithTag ("Hinge3").transform;
		//want the door to be in closed position
		open.eulerAngles = new Vector3 (0,0,0);
		
		//gameObject.renderer.material.color = Color.gray;
	}
	
	void Update () 
	{
		//the update always triggering the door to stay closed 
		doorHingeRoom1.rotation = Quaternion.Lerp(doorHingeRoom1.rotation,open,Time.deltaTime * doorSpeed);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player") 
		{
			//The posoition the door is fully opened at
			open.eulerAngles= new Vector3(0,90,0);
			
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			//The position where the door is closed at
			open.eulerAngles = new Vector3(0,0,0);
		}
		
		
	}
}

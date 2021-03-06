﻿using UnityEngine;
using System.Collections;

public class Room1DoorTrigger: MonoBehaviour {

	private Transform doorHingeRoom1;
	
	public float doorSpeed = 5f;

	public Quaternion open = Quaternion.identity;

	private 

	void Awake()
	{
		doorHingeRoom1 = GameObject.Find ("Hinge1").transform;
		
		open.eulerAngles = new Vector3 (0,270,0);
		
		gameObject.renderer.material.color = Color.gray;
	}

	void Update () 
	{
		if(GameObject.Find("floor_puzzle").GetComponent<floor_puzzle_controller>().allGreen)
		{
			doorHingeRoom1.rotation = Quaternion.Lerp(doorHingeRoom1.rotation,open,Time.deltaTime * doorSpeed);
		}
	}
	
	/*void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player") 
		{
			open.eulerAngles= new Vector3(0,270,0);
			
	    }
	}*/

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			open.eulerAngles = new Vector3(0,0,0);
		}
						

	}
}

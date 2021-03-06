﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class EnemySight : MonoBehaviour {
	//private bool playerInSight = false;
	private bool chase;
	public float fieldOfViewAngle = 90f;
	//public float speed = 2.0f;
	private GameObject thePlayer;
	private SphereCollider col;
	Transform player;
	NavMeshAgent nav;
	public bool stunned;
	
	private PlayerController playerController;
	private float detectedTime;
	private Vector3 startPosition;
	private bool isRunning;

	PlayerHealth playerHealth;
	
	public Vector3 destination_1;
	public Vector3 destination_2;
	public Vector3 destination_3;
	public Vector3 destination_4;
	
	private int counter = 0;
	
	private List<Vector3> posList = new List<Vector3>();
	void Awake ()
	{
		thePlayer = GameObject.FindGameObjectWithTag ("Player");
		player = thePlayer.transform;
		//col = GetComponent <SphereCollider>();
		nav = GetComponent <NavMeshAgent> ();
		playerController = thePlayer.GetComponent<PlayerController> ();
		chase = false;
		playerHealth = thePlayer.GetComponent<PlayerHealth> ();
	}
	
	void Start() {
		startPosition = transform.position;
		Debug.Log (startPosition.x + " " + startPosition.y + " " + startPosition.z);
		posList.Add (destination_1);
		posList.Add (destination_2);
		posList.Add (destination_3);
		posList.Add (destination_4);
	}
	void Update()
	{
		if (!stunned) {
						if (chase == true && !playerHealth.isDead) {
								nav.speed = 6.0f;
								//nav.enabled = true;
								nav.SetDestination (player.position);
								if (Time.time - detectedTime >= 5.0f) {
										chase = false;
										nav.Stop ();
								}
						} else if (chase == false || playerHealth.isDead) {
								nav.speed = 3.0f;
								//nav.enabled = false;
								nav.SetDestination (posList [counter]);
								if (Math.Round (transform.position.x) == Math.Round (posList [counter].x)
										&& Math.Round (transform.position.z) == Math.Round (posList [counter].z)) {
										counter = (counter + 1) % posList.Count;
								}
						}
						detect_player ();
				} else {
			 			StartCoroutine(wait_stunned());
				}
	
	}

	
	void detect_player ()
	{
		

			//playerInSight = false;
			//Debug.Log("player in collider!");
			Vector3 direction = thePlayer.transform.position - transform.position;
			float angle = Vector3.Angle (direction, transform.forward);
			
			if (angle < 45.0f) 
			{
				RaycastHit hit;
				
				if (Physics.Raycast (transform.position + transform.up, direction.normalized, out hit, 10.0f)) 
				{
					if (hit.collider.gameObject == thePlayer && !playerHealth.isDead) 
					{
						//playerInSight = true;
						chase = true;
						detectedTime = Time.time;
						//Debug.Log("detect player!");
					}
				}
				
			}
			
			else if (angle < 180.0f) 
			{
				RaycastHit hit;
				
				if (Physics.Raycast (transform.position + transform.up, direction.normalized, out hit, 4.0f)) 
				{
				if (hit.collider.gameObject == thePlayer && !playerHealth.isDead) 
					{
						
						isRunning = playerController.isRunning;
						if(isRunning){
							//playerInSight = true;
							chase = true;
							detectedTime = Time.time;
							//Debug.Log("detect player!");
						}
					}
				}
				
			}
			

	}

	IEnumerator wait_stunned()
	{
		nav.enabled = false;
		yield return new WaitForSeconds (3);
		nav.enabled = true;
		stunned = false;
	}
}

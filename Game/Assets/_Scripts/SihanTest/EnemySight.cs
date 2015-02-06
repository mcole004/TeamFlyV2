using UnityEngine;
using System.Collections;

public class EnemySight : MonoBehaviour {

	public bool playerInSight;
	private bool chase;
	public float fieldOfViewAngle = 90f;
	public float speed = 8.0f;
	private GameObject thePlayer;
	private SphereCollider col;
	Transform player;
	NavMeshAgent nav;
	void Awake ()
	{
		thePlayer = GameObject.FindGameObjectWithTag ("Player");
		player = thePlayer.transform;
		col = GetComponent <SphereCollider>();
		nav = GetComponent <NavMeshAgent> ();
		chase = false;
	}
	void Update()
	{
		if (chase == true) 
		{
			nav.SetDestination (player.position);
		}
	}
	
	void OnTriggerStay (Collider other)
	{

		if (other.gameObject == thePlayer) 
		{
			playerInSight = false;
			Debug.Log("player in collider!");
			Vector3 direction = other.transform.position - transform.position;
			float angle = Vector3.Angle (direction, transform.forward);

			if (angle < fieldOfViewAngle * 0.5f) 
			{
				RaycastHit hit;

				if (Physics.Raycast (transform.position + transform.up, direction.normalized, out hit, col.radius)) 
				{
					if (hit.collider.gameObject == thePlayer) 
					{
						playerInSight = true;
						chase = true;
						Debug.Log("detect player!");
					}
				}
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float run = 10f;
	public float walk = 3f;
	Vector3 movement;
	Rigidbody playerRigidbody;
	int floorMask;
	float camRayLength = 50f;
	public bool isRunning = false;
	// Use this for initialization
	void Awake () {
		floorMask = LayerMask.GetMask ("Floor");
		playerRigidbody = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		Move (h, v);
		Turning ();
	}

	void Move(float h, float v){
		movement.Set (h, 0f, v);
		if (h == 0.0f && v == 0.0f) {
			isRunning = false;
		}
		float speed;
		if (Input.GetKey (KeyCode.LeftShift)) {
			speed = walk;
			isRunning = false;
		}
		else {
			speed = run;
			isRunning = true;
		}
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidbody.MovePosition (transform.position + movement);
	}

	void Turning ()
	{
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit floorHit;
		if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask)) {
			Vector3 playerToMouse = floorHit.point - transform.position;
			playerToMouse.y = 0f;
			Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
			playerRigidbody.MoveRotation (newRotation);
		}
	}
}

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float run = 10f;
	public float walk = 3f;
	Vector3 movement;
	Rigidbody playerRigidbody;
	int floorMask;
	float camRayLength = 50f;
	Animator anim;
	public bool stungun;
	public bool isRunning;
	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
		floorMask = LayerMask.GetMask ("Floor");
		playerRigidbody = GetComponent <Rigidbody> ();
		stungun = false;
		isRunning = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		Move (h, v);
		Turning ();
		Animating(h,v);
		if (gameObject.transform.position.y > 0.02f || gameObject.transform.position.y < -0.01f) {
						gameObject.transform.position = new Vector3 (transform.position.x, 0.0f, transform.position.z);
				}
	}

	void Move(float h, float v){
		movement.Set (h, 0f, v);
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
	void Animating (float h, float v)
	{
		// Create a boolean that is true if either of the input axes is non-zero.
		bool walking = h != 0f || v != 0f;
		
		// Tell the animator whether or not the player is walking.
		anim.SetBool ("IsMoving", walking);
	}
	
	
}

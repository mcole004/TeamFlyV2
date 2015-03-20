using UnityEngine;
using System.Collections;

public class universal_door_controller : MonoBehaviour {
	
	public float smooth = 2.0f;
	public float DoorOpenAngle = 90.0f;
	public float DoorCloseAngle = 0.0f;
	public bool open;
	
	public bool locked = false;
	public int unlock_total;
	
	void Awake()
	{
		
	}
	
	
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				if(!locked || (unlock_total == Addition_Controller.door_val))
				{
					open = !open;
				}
			}
		}
		
	}
	
	void Update()
	{
		if(open == true)
		{
			var target = Quaternion.Euler (0, DoorOpenAngle, 0);
			transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * smooth);
		}

		if(open == false)
		{
			var target1= Quaternion.Euler (0, DoorCloseAngle, 0);
			transform.localRotation = Quaternion.Slerp(transform.localRotation, target1, Time.deltaTime * smooth);
		}  
		
	}
}

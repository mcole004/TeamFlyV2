using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour {

	public PlayerController player;
	LineRenderer line;
	public Color StartColor = Color.red;
	public Color EndColor = new Color(1, 1, 1, 0);
	int shootableMask;

	void Start () 
	{
		GameObject gun = GameObject.FindGameObjectWithTag ("Player");
		player = gun.GetComponent<PlayerController>();

		line = gameObject.GetComponent<LineRenderer>();
		line.material = new Material(Shader.Find("Particles/Additive"));

		line.SetColors (StartColor,EndColor);

		line.enabled = false;

		shootableMask = LayerMask.GetMask ("Shootable");
	}
	void Update () 
	{
		if(Input.GetButtonDown("Fire1") && player.stungun == true )
		{
			StopCoroutine("FireLaser");
			StartCoroutine("FireLaser");
		}
	}
	IEnumerator FireLaser()
	{
		line.enabled = true;
		
		while(Input.GetButton("Fire1"))
		{
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
			
			line.SetPosition(0, ray.origin);
			
			if(Physics.Raycast(ray, out hit, 100, shootableMask))
			{
				line.SetPosition(1, hit.point);

				EnemySight enemySight = hit.collider.GetComponent<EnemySight>();
				EnemyAttack enemyAttack = hit.collider.GetComponent<EnemyAttack>();

				if(enemySight != null)
				{
					enemySight.stunned = true;
					enemyAttack.stunned = true;
				}

				/*if(hit.rigidbody)
				{
					hit.rigidbody.AddForceAtPosition(transform.forward * 10, hit.point);
				}*/
			}
			else
				line.SetPosition(1, ray.GetPoint(100));
			
			yield return null;
		}
		
		line.enabled = false;
     }
}
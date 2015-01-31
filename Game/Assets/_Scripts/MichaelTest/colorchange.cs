using UnityEngine;
using System.Collections;

public class colorchange : MonoBehaviour {

	MeshRenderer cube_shader;
	
	// Use this for initialization
	void Start () 
	{
		cube_shader = GetComponent <MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		cube_shader.material.color = Color.green;
	}
}

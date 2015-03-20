using UnityEngine;
using System.Collections;

public class Pause_controller : MonoBehaviour {
	
	public GameObject pause_panel;
	public GameObject map_image;
	public GameObject map_image2;
	public static bool map2_obtained;
	public bool paused;
	
	
	// Use this for initialization
	void Start () {
		pause_panel.SetActive(false);
		map_image.SetActive(false);
		map_image2.SetActive(false);
		paused = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(Time.timeScale != 0)
			{
				Time.timeScale = 0.0f;
				Screen.showCursor = true;
				pause_panel.SetActive(true);
				paused = true;
			}
			else
			{
				Time.timeScale = 1.0f;
				Screen.showCursor = false;
				pause_panel.SetActive(false);
				paused = false;
			}
		}
		
		if(Input.GetKey(KeyCode.Tab) && !paused)
		{
			//print ("Tab pressed");
			map_image.SetActive(true);
			if(map2_obtained)
			{
				map_image2.SetActive(true);
			}
		}
		else
		{
			map_image.SetActive(false);
			map_image2.SetActive(false);
		}
		
		
		
		
	}
	
	public void ResumeGame()
	{
		Time.timeScale = 1.0f;
		Screen.showCursor = false;
		pause_panel.SetActive(false);
		paused = false;
	}
}

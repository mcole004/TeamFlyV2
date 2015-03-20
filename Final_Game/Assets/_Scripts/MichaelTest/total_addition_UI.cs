using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class total_addition_UI : MonoBehaviour {

	public static int total;        
	
	Text text;                      
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		total = 0;
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = " " + total;
	}
}

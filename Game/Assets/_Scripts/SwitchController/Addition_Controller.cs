using UnityEngine;
using System.Collections;

public class Addition_Controller : MonoBehaviour {
	
	public int total_val;
	Switch1_Controller SW1;
	Switch2_Controller SW2;
	Switch3_Controller SW3;
	Switch4_Controller SW4;
	Switch5_Controller SW5;
	Switch6_Controller SW6;
	
	// Use this for initialization
	void Start () {
		SW1 = GameObject.Find("Switch1").GetComponent<Switch1_Controller>();
		SW2 = GameObject.Find("Switch2").GetComponent<Switch2_Controller>();
		SW3 = GameObject.Find("Switch3").GetComponent<Switch3_Controller>();
		SW4 = GameObject.Find("Switch4").GetComponent<Switch4_Controller>();
		SW5 = GameObject.Find("Switch5").GetComponent<Switch5_Controller>();
		SW6 = GameObject.Find("Switch6").GetComponent<Switch6_Controller>();
		total_val = SW1.value + SW2.value + SW3.value + SW4.value + SW5.value + SW6.value;
		//total_addition_UI.total = total_val;
	}
	
	// Update is called once per frame
	void Update () {
		total_val = SW1.value + SW2.value + SW3.value + SW4.value + SW5.value + SW6.value;
		total_addition_UI.total = total_val;
	}
}

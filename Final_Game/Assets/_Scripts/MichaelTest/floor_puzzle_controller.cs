using UnityEngine;
using System.Collections;

public class floor_puzzle_controller : MonoBehaviour {

	public GameObject MM;
	public GameObject ML;
	public GameObject MR;
	public GameObject UM;
	public GameObject UL;
	public GameObject UR;
	public GameObject BM;
	public GameObject BL;
	public GameObject BR;
	public bool allGreen = false;
	
	cube_contMM MMcont; 
	cube_contML MLcont;
	cube_contMR MRcont;
	cube_contUM UMcont; 
	cube_contUL ULcont;
	cube_contUR URcont;
	cube_contBM BMcont; 
	cube_contBL BLcont;
	cube_contBR BRcont;
	
	// Use this for initialization
	void Start () 
	{
		MMcont = MM.GetComponent<cube_contMM>();
		MLcont = ML.GetComponent<cube_contML>();
		MRcont = MR.GetComponent<cube_contMR>();
		UMcont = UM.GetComponent<cube_contUM>();
		ULcont = UL.GetComponent<cube_contUL>();
		URcont = UR.GetComponent<cube_contUR>();
		BMcont = BM.GetComponent<cube_contBM>();
		BLcont = BL.GetComponent<cube_contBL>();
		BRcont = BR.GetComponent<cube_contBR>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(	MMcont.isGreen && MLcont.isGreen && MRcont.isGreen &&
		   	UMcont.isGreen && ULcont.isGreen && URcont.isGreen &&
		    BMcont.isGreen && BLcont.isGreen && BRcont.isGreen)
		{
			allGreen = true;
		}
		else 
		{
			allGreen = false;
		}
	}
}

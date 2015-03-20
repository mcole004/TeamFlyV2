using UnityEngine;
using System.Collections;
//created by Frank Lyons 
public class lightController : MonoBehaviour {

	public float smooth;
	private float newIntensity;
	public float endIntensity;
	public float startIntensity;
	public bool lightswitch;
	void Awake ()
	{
		newIntensity = light.intensity;
		lightswitch = true;
	}
	
	void Update ()
	{
		if (lightswitch) 
		{
			if (light.intensity >= (endIntensity - 0.1f)) 
			{
				newIntensity = startIntensity;
			} 
			else if (light.intensity <= (startIntensity + 0.1f)) 
			{
				newIntensity = endIntensity;
			}
		
			IntensityChanging ();
		}
		else
		{
			light.intensity = 0.0f;
		}
	}
	
	void IntensityChanging ()
	{
		
		light.intensity = Mathf.Lerp(light.intensity, newIntensity, smooth * Time.deltaTime);
	}
}

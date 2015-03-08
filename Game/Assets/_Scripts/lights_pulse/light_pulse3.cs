using UnityEngine;
using System.Collections;

public class light_pulse3 : MonoBehaviour {

	public float smooth;
	private float newIntensity;
	public float endIntensity;
	public float startIntensity;
	
	void Awake ()
	{
		newIntensity = light.intensity;
	}
	
	void Update ()
	{
		if(light.intensity >= (endIntensity - 0.1f))
		{
			newIntensity = startIntensity;
		}
		else if(light.intensity <= (startIntensity + 0.1f))
		{
			newIntensity = endIntensity;
		}
		
		IntensityChanging();
	}
	
	void IntensityChanging ()
	{
		
		light.intensity = Mathf.Lerp(light.intensity, newIntensity, smooth * Time.deltaTime);
	}
}

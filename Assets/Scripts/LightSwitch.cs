using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

	 public bool isLit = true;
	 public GameObject myLight;

	//Enable/Disable light

	void OnMouseDown ()
	{
		isLit = !isLit;
	}

	
	// Update is called once per frame
	void Update () 
	{
		myLight.SetActive(isLit);
	}
}

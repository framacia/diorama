using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSwitch : MonoBehaviour {

	 public bool isColored = true;
	 public Color newColor = Color.red;
	 Renderer myRenderer;


	 Color originalColor;

	//Enable/Disable light

	void Start ()
	{
		myRenderer = GetComponent<Renderer>();
		originalColor = myRenderer.material.color;
	}

	void OnMouseDown ()
	{
		isColored = !isColored;

		if (!isColored)
		{
			myRenderer.material.color = originalColor;
		}
		else
		{
			myRenderer.material.color = newColor;
		}
	}

	
	// Update is called once per frame
	void Update () 
	{

	}
}

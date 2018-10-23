using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInteraction : MonoBehaviour {

	public GameObject halo;
	public GameObject camera;
	public AudioClip mouseClick;
	public GameObject panel;

    GameObject[] otherPanels;
	AudioSource audioSource;

	private void OnMouseOver() 
	{
		print("Mouse over " + gameObject.name);
		if (!halo.activeSelf)
		{
			halo.SetActive(true);
		}
	}

	private void OnMouseExit()
	{
		halo.SetActive(false);
	}

	private void OnMouseDown()
	{
		print(gameObject.name + " clicked");
		audioSource.PlayOneShot(mouseClick, 1.0F);
        otherPanels = GameObject.FindGameObjectsWithTag("Panel");
        foreach(GameObject otherPanel in otherPanels)
        otherPanel.SetActive(false);
		panel.SetActive(true);
	}

	// Use this for initialization
	void Start ()
	{
		audioSource = camera.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}

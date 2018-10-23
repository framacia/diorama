using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	private GameObject panel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			print("Application quitted");
			Application.Quit();
		}		
	}

	public void Quit() 
	{
		Debug.Log("Application quitted");
		Application.Quit();
	}

	public void LoadScene(string nextScene)
	{
		Debug.Log("Loading scene " + nextScene);
		SceneManager.LoadScene(nextScene);
	}

}

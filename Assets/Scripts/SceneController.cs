using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	private GameObject panel;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			MainMenu();
		}		
	}

	public void MainMenu() 
	{
		Debug.Log("Back to main menu");
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Debug.Log("Game quitted");
        Application.Quit();
    }

    public void Aerial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FirstPerson()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

   
}

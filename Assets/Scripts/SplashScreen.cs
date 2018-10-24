using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene(1);
    }

    // Use this for initialization
    void Start () {
        StartCoroutine(ExecuteAfterTime(10));
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

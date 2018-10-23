using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour {

	//FIX - TRY TO FREEZE EVERY ROTATION EXCEPT X

	public GameObject camera;
	public float moveSpeed = 5;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveVertical = Input.GetAxis("Vertical") * moveSpeed;
		float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed;

		transform.Translate(0, 0, moveVertical);
		transform.Translate(moveHorizontal, 0, 0);

		transform.rotation = transform.rotation = Quaternion.Euler(0, camera.transform.eulerAngles.y,0);;


	}
}

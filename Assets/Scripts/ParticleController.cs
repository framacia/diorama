using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ParticleController : MonoBehaviour {

	public ParticleSystem smokeParticle;
	public ParticleSystem explosionParticle;

	private bool hasExploded = false;

	void OnMouseDown() 
	{
		if(!hasExploded)
		{			
			smokeParticle.GetComponent<ParticleSystem>().enableEmission = true;
			explosionParticle.GetComponent<ParticleSystem>().Play(true);
            CameraShaker.Instance.ShakeOnce(10f, 10f, .1f, 2f);
			hasExploded = true;
		}		
	}

	// Use this for initialization
	void Awake () 
	{
		smokeParticle.GetComponent<ParticleSystem>().enableEmission = false;
		explosionParticle.GetComponent<ParticleSystem>().Stop(true);
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}

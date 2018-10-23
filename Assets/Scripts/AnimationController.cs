using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    private Animator myAnimator;
    public bool animate = false;

	// Use this for initialization
	void Start ()
    {
        myAnimator = GetComponent<Animator>();
	}

    void Update()
    {
        myAnimator.SetBool("Stop", animate);
    }
}
